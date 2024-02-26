namespace MTsocketAPI_Chart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbSymbols = new ComboBox();
            cmbTimeframe = new ComboBox();
            formsPlot1 = new ScottPlot.FormsPlot();
            splitContainer1 = new SplitContainer();
            btnConnect = new Button();
            label3 = new Label();
            label2 = new Label();
            nVolume = new NumericUpDown();
            btnBuy = new Button();
            label1 = new Label();
            btnSell = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dgvSymbol = new DataGridViewTextBoxColumn();
            dgvTicket = new DataGridViewTextBoxColumn();
            dgvTime = new DataGridViewTextBoxColumn();
            dgvType = new DataGridViewTextBoxColumn();
            dgvVolume = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvSL = new DataGridViewTextBoxColumn();
            dgvTP = new DataGridViewTextBoxColumn();
            dgvSwap = new DataGridViewTextBoxColumn();
            dgvProfit = new DataGridViewTextBoxColumn();
            dgvClose = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbSymbols
            // 
            cmbSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSymbols.FormattingEnabled = true;
            cmbSymbols.Location = new Point(577, 10);
            cmbSymbols.Margin = new Padding(3, 4, 3, 4);
            cmbSymbols.Name = "cmbSymbols";
            cmbSymbols.Size = new Size(139, 28);
            cmbSymbols.TabIndex = 1;
            cmbSymbols.SelectedIndexChanged += cmbSymbols_SelectedIndexChanged;
            // 
            // cmbTimeframe
            // 
            cmbTimeframe.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimeframe.FormattingEnabled = true;
            cmbTimeframe.Location = new Point(577, 44);
            cmbTimeframe.Margin = new Padding(3, 4, 3, 4);
            cmbTimeframe.Name = "cmbTimeframe";
            cmbTimeframe.Size = new Size(139, 28);
            cmbTimeframe.TabIndex = 2;
            cmbTimeframe.SelectedIndexChanged += cmbTimeframe_SelectedIndexChanged;
            // 
            // formsPlot1
            // 
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Margin = new Padding(5, 4, 5, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(1095, 526);
            formsPlot1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 3, 2, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnConnect);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(nVolume);
            splitContainer1.Panel1.Controls.Add(btnBuy);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btnSell);
            splitContainer1.Panel1.Controls.Add(cmbTimeframe);
            splitContainer1.Panel1.Controls.Add(cmbSymbols);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1095, 765);
            splitContainer1.SplitterDistance = 77;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 15F);
            btnConnect.Location = new Point(289, 20);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(152, 49);
            btnConnect.TabIndex = 63;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(472, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 62;
            label3.Text = "Timeframe:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(500, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 61;
            label2.Text = "Symbol:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nVolume
            // 
            nVolume.DecimalPlaces = 2;
            nVolume.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            nVolume.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nVolume.Location = new Point(883, 20);
            nVolume.Margin = new Padding(1);
            nVolume.Name = "nVolume";
            nVolume.Size = new Size(79, 41);
            nVolume.TabIndex = 58;
            nVolume.TextAlign = HorizontalAlignment.Center;
            nVolume.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.SteelBlue;
            btnBuy.Enabled = false;
            btnBuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuy.ForeColor = Color.Transparent;
            btnBuy.Location = new Point(979, 16);
            btnBuy.Margin = new Padding(1);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(79, 45);
            btnBuy.TabIndex = 57;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(56, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 46);
            label1.TabIndex = 61;
            label1.Text = "MTsocketAPI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.Brown;
            btnSell.Enabled = false;
            btnSell.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSell.ForeColor = Color.Transparent;
            btnSell.Location = new Point(787, 16);
            btnSell.Margin = new Padding(1);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(79, 45);
            btnSell.TabIndex = 56;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(2, 3, 2, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView1);
            splitContainer2.Size = new Size(1095, 685);
            splitContainer2.SplitterDistance = 526;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 4;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(2, 3, 2, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(formsPlot1);
            splitContainer3.Panel2Collapsed = true;
            splitContainer3.Panel2MinSize = 240;
            splitContainer3.Size = new Size(1095, 526);
            splitContainer3.SplitterDistance = 25;
            splitContainer3.SplitterWidth = 3;
            splitContainer3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvSymbol, dgvTicket, dgvTime, dgvType, dgvVolume, dgvPrice, dgvSL, dgvTP, dgvSwap, dgvProfit, dgvClose });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1095, 156);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dgvSymbol
            // 
            dgvSymbol.HeaderText = "Symbol";
            dgvSymbol.MinimumWidth = 8;
            dgvSymbol.Name = "dgvSymbol";
            dgvSymbol.ReadOnly = true;
            dgvSymbol.Width = 150;
            // 
            // dgvTicket
            // 
            dgvTicket.HeaderText = "Ticket";
            dgvTicket.MinimumWidth = 8;
            dgvTicket.Name = "dgvTicket";
            dgvTicket.ReadOnly = true;
            dgvTicket.Width = 150;
            // 
            // dgvTime
            // 
            dgvTime.HeaderText = "Time";
            dgvTime.MinimumWidth = 8;
            dgvTime.Name = "dgvTime";
            dgvTime.ReadOnly = true;
            dgvTime.Width = 150;
            // 
            // dgvType
            // 
            dgvType.HeaderText = "Type";
            dgvType.MinimumWidth = 8;
            dgvType.Name = "dgvType";
            dgvType.ReadOnly = true;
            dgvType.Width = 150;
            // 
            // dgvVolume
            // 
            dgvVolume.HeaderText = "Volume";
            dgvVolume.MinimumWidth = 8;
            dgvVolume.Name = "dgvVolume";
            dgvVolume.ReadOnly = true;
            dgvVolume.Width = 150;
            // 
            // dgvPrice
            // 
            dgvPrice.HeaderText = "Price";
            dgvPrice.MinimumWidth = 8;
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            dgvPrice.Width = 150;
            // 
            // dgvSL
            // 
            dgvSL.HeaderText = "S / L";
            dgvSL.MinimumWidth = 8;
            dgvSL.Name = "dgvSL";
            dgvSL.ReadOnly = true;
            dgvSL.Width = 150;
            // 
            // dgvTP
            // 
            dgvTP.HeaderText = "TP";
            dgvTP.MinimumWidth = 8;
            dgvTP.Name = "dgvTP";
            dgvTP.ReadOnly = true;
            dgvTP.Width = 150;
            // 
            // dgvSwap
            // 
            dgvSwap.HeaderText = "Swap";
            dgvSwap.MinimumWidth = 8;
            dgvSwap.Name = "dgvSwap";
            dgvSwap.ReadOnly = true;
            dgvSwap.Width = 150;
            // 
            // dgvProfit
            // 
            dgvProfit.HeaderText = "Profit";
            dgvProfit.MinimumWidth = 8;
            dgvProfit.Name = "dgvProfit";
            dgvProfit.ReadOnly = true;
            dgvProfit.Width = 150;
            // 
            // dgvClose
            // 
            dgvClose.FlatStyle = FlatStyle.System;
            dgvClose.HeaderText = "Close";
            dgvClose.MinimumWidth = 8;
            dgvClose.Name = "dgvClose";
            dgvClose.ReadOnly = true;
            dgvClose.Text = "X";
            dgvClose.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 765);
            Controls.Add(splitContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Trading Application Example - https://www.mtsocketapi.com";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nVolume).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        //private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ComboBox cmbSymbols;
        private ComboBox cmbTimeframe;
        private ScottPlot.FormsPlot formsPlot1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private DataGridView dataGridView1;
        private NumericUpDown nVolume;
        private Button btnBuy;
        private Button btnSell;
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn dgvSymbol;
        private DataGridViewTextBoxColumn dgvTicket;
        private DataGridViewTextBoxColumn dgvTime;
        private DataGridViewTextBoxColumn dgvType;
        private DataGridViewTextBoxColumn dgvVolume;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvSL;
        private DataGridViewTextBoxColumn dgvTP;
        private DataGridViewTextBoxColumn dgvSwap;
        private DataGridViewTextBoxColumn dgvProfit;
        private DataGridViewButtonColumn dgvClose;
        private Button btnConnect;
    }
}
