using MTsocketAPI.MT5;
using ScottPlot;
using ScottPlot.Plottable;

namespace MTsocketAPI_Chart
{
    public partial class Form1 : Form
    {
        MTsocketAPI.MT5.Terminal mt5;
        FinancePlot? fnplot;
        CancellationTokenSource cts = new CancellationTokenSource();
        Thread? updateThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Configure datagridview
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //Configure formsPlot
                formsPlot1.Plot.Grid(false);
                formsPlot1.Plot.XAxis.DateTimeFormat(true);
                formsPlot1.Plot.RightAxis.Ticks(true);
                formsPlot1.Plot.RightAxis.TickLabelFormat("F5", false);
                formsPlot1.Plot.LeftAxis.Ticks(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        DateTime RoundDown(DateTime dt, TimeSpan d)
        {
            var delta = dt.Ticks % d.Ticks;
            return new DateTime(dt.Ticks - delta, dt.Kind);
        }

        private void Mt5_OnPrice(object? sender, Quote e)
        {
            lock (this)
            {
                try
                {
                    if (fnplot != null)
                    {
                        if (Convert.ToDateTime(e.TIME) >= fnplot.Last().DateTime.Add(fnplot.Last().TimeSpan))
                        {
                            //New Candle
                            ScottPlot.OHLC candle = new OHLC(open: e.BID, high: e.BID, low: e.BID, close: e.BID, RoundDown(Convert.ToDateTime(e.TIME), fnplot.Last().TimeSpan), fnplot.Last().TimeSpan);
                            fnplot.Add(candle);
                        }
                        else
                        {
                            //Update existing candle
                            fnplot.Last().Close = e.BID;
                            if (e.BID > fnplot.Last().High) { fnplot.Last().High = e.BID; }
                            if (e.BID < fnplot.Last().Low) { fnplot.Last().Low = e.BID; }
                        }

                        this.formsPlot1.Invoke((EventHandler)delegate
                        {
                            formsPlot1.Refresh();
                        });
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        Terminal pos;
        void UpdateOrderList()
        {
            //Fill datagridview with opened orders from Metatrader
            try
            {
                if (pos == null)
                {
                    pos = new Terminal();
                    pos.Connect();
                }
                List<Position> lst = pos.GetOpenedOrders();
                if (lst.Count > 0)
                {
                    this.dataGridView1.Invoke((EventHandler)delegate
                    {
                        dataGridView1.Rows.Clear();
                        foreach (var item in lst)
                            dataGridView1.Rows.Add(item.SYMBOL, item.TICKET, item.OPEN_TIME, item.TYPE, item.VOLUME, item.PRICE_OPEN, item.SL, item.TP, item.SWAP, item.PROFIT);
                        dataGridView1.AutoResizeColumns();
                    });
                }
            }
            catch (Exception)
            {

            }
        }
        void UpdateOrderListLoop(CancellationTokenSource cancelTS)
        {
            do
            {
                System.Threading.Thread.Sleep(1000);
                if (cancelTS.IsCancellationRequested) return;
                UpdateOrderList();
            } while (true);
        }

        TimeSpan TimeSpanFromTF(TimeFrame tf)
        {
            switch (tf)
            {
                case TimeFrame.PERIOD_M1: return TimeSpan.FromMinutes(1);
                case TimeFrame.PERIOD_M2: return TimeSpan.FromMinutes(2);
                case TimeFrame.PERIOD_M3: return TimeSpan.FromMinutes(3);
                case TimeFrame.PERIOD_M4: return TimeSpan.FromMinutes(4);
                case TimeFrame.PERIOD_M5: return TimeSpan.FromMinutes(5);
                case TimeFrame.PERIOD_M6: return TimeSpan.FromMinutes(6);
                case TimeFrame.PERIOD_M10: return TimeSpan.FromMinutes(10);
                case TimeFrame.PERIOD_M15: return TimeSpan.FromMinutes(15);
                case TimeFrame.PERIOD_M20: return TimeSpan.FromMinutes(20);
                case TimeFrame.PERIOD_M30: return TimeSpan.FromMinutes(30);
                case TimeFrame.PERIOD_H1: return TimeSpan.FromHours(1);
                case TimeFrame.PERIOD_H2: return TimeSpan.FromHours(2);
                case TimeFrame.PERIOD_H3: return TimeSpan.FromHours(3);
                case TimeFrame.PERIOD_H4: return TimeSpan.FromHours(4);
                case TimeFrame.PERIOD_H6: return TimeSpan.FromHours(6);
                case TimeFrame.PERIOD_H8: return TimeSpan.FromHours(8);
                case TimeFrame.PERIOD_H12: return TimeSpan.FromHours(12);
                case TimeFrame.PERIOD_D1: return TimeSpan.FromDays(1);
                case TimeFrame.PERIOD_W1: return TimeSpan.FromDays(7);
                case TimeFrame.PERIOD_MN1: return TimeSpan.FromDays(30);
                default: return TimeSpan.FromSeconds(0);
            }
        }

        private void cmbSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        void UpdateChart()
        {
            try
            {
                formsPlot1.Plot.Clear();

                List<ScottPlot.OHLC> prices = new List<ScottPlot.OHLC>();

                TimeFrame tf = (TimeFrame)Enum.Parse(typeof(TimeFrame), cmbTimeframe.Text);

                var rates = mt5.PriceHistory(cmbSymbols.Text, tf, DateTime.Now.AddHours(-12).AddMinutes(-TimeSpanFromTF(tf).TotalMinutes * 30), DateTime.Now.AddDays(1));

                foreach (var item in rates)
                {
                    ScottPlot.OHLC candle = new OHLC(open: item.OPEN, high: item.HIGH, low: item.LOW, close: item.CLOSE, Convert.ToDateTime(item.TIME), TimeSpanFromTF(tf));
                    prices.Add(candle);
                }

                prices.Reverse();

                fnplot = formsPlot1.Plot.AddCandlesticks(prices.ToArray());
                fnplot.YAxisIndex = formsPlot1.Plot.RightAxis.AxisIndex;

                mt5.TrackPrices(new List<string>() { cmbSymbols.Text });

                formsPlot1.Plot.AxisAuto();
                formsPlot1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                TradeResult res = mt5.SendOrder(cmbSymbols.Text, (double)nVolume.Value, OrderType.ORDER_TYPE_BUY);
                if (res != null) UpdateOrderList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                TradeResult res = mt5.SendOrder(cmbSymbols.Text, (double)nVolume.Value, OrderType.ORDER_TYPE_SELL);
                if (res != null) UpdateOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //If we click the datagridview close button then we close the position
            if (e.ColumnIndex == 10)
            {
                try
                {
                    TradeResult res = mt5.OrderClose(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
                    if (res != null) if (res.TYPE == "FULLY_CLOSED") dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void cmbTimeframe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSymbols.Text.Length > 0) UpdateChart();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cts != null) cts.Cancel();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                mt5 = new Terminal();
                mt5.OnPrice += Mt5_OnPrice;
                mt5.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check that MTsocketAPI is running. \nError: " + ex.Message);
                Application.Exit();
                return;
            }

            //Fill TimeFrame list
            cmbTimeframe.DataSource = Enum.GetNames(typeof(TimeFrame));

            //Fill list with tradeable symbols
            cmbSymbols.DataSource = mt5.GetSymbolList().Where(x => x.TRADE_MODE != 0).Select(x => x.NAME).ToList();

            btnConnect.Text = "Connected";
            btnBuy.Enabled = true;
            btnSell.Enabled = true;
            btnConnect.Enabled = false;

            //Loop to retrieve opened positions from Metatrader
            updateThread = new Thread(() => UpdateOrderListLoop(cts));
            updateThread.IsBackground = true;
            updateThread.Start();
        }
    }
}
