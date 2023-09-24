
namespace IS_SUKIYA.FormFolder
{
    partial class frmSaleRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tclRecord = new System.Windows.Forms.TabControl();
            this.tpgQuery = new System.Windows.Forms.TabPage();
            this.dgvTransactionDetail = new System.Windows.Forms.DataGridView();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.cbxFileList = new System.Windows.Forms.ComboBox();
            this.tpgAnalysis = new System.Windows.Forms.TabPage();
            this.gbxSaleView = new System.Windows.Forms.GroupBox();
            this.rbnTransaction = new System.Windows.Forms.RadioButton();
            this.rbnTransactionTotal = new System.Windows.Forms.RadioButton();
            this.rbnTransactionItem = new System.Windows.Forms.RadioButton();
            this.rbnTransactionDate = new System.Windows.Forms.RadioButton();
            this.rbnTransactionCategory = new System.Windows.Forms.RadioButton();
            this.gbxChartStyle = new System.Windows.Forms.GroupBox();
            this.rbnPieChart = new System.Windows.Forms.RadioButton();
            this.rbnLineChart = new System.Windows.Forms.RadioButton();
            this.rbnBarChart = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tclRecord.SuspendLayout();
            this.tpgQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.tpgAnalysis.SuspendLayout();
            this.gbxSaleView.SuspendLayout();
            this.gbxChartStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tclRecord
            // 
            this.tclRecord.Controls.Add(this.tpgQuery);
            this.tclRecord.Controls.Add(this.tpgAnalysis);
            this.tclRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclRecord.Location = new System.Drawing.Point(25, 133);
            this.tclRecord.Name = "tclRecord";
            this.tclRecord.SelectedIndex = 0;
            this.tclRecord.Size = new System.Drawing.Size(708, 535);
            this.tclRecord.TabIndex = 0;
            // 
            // tpgQuery
            // 
            this.tpgQuery.Controls.Add(this.dgvTransactionDetail);
            this.tpgQuery.Controls.Add(this.dgvTransaction);
            this.tpgQuery.Controls.Add(this.cbxFileList);
            this.tpgQuery.Location = new System.Drawing.Point(4, 34);
            this.tpgQuery.Name = "tpgQuery";
            this.tpgQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpgQuery.Size = new System.Drawing.Size(700, 497);
            this.tpgQuery.TabIndex = 0;
            this.tpgQuery.Text = "Query";
            this.tpgQuery.UseVisualStyleBackColor = true;
            this.tpgQuery.Enter += new System.EventHandler(this.tpgQuery_Enter);
            // 
            // dgvTransactionDetail
            // 
            this.dgvTransactionDetail.AllowUserToAddRows = false;
            this.dgvTransactionDetail.AllowUserToDeleteRows = false;
            this.dgvTransactionDetail.AllowUserToResizeColumns = false;
            this.dgvTransactionDetail.AllowUserToResizeRows = false;
            this.dgvTransactionDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTransactionDetail.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvTransactionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetail.Location = new System.Drawing.Point(50, 210);
            this.dgvTransactionDetail.Name = "dgvTransactionDetail";
            this.dgvTransactionDetail.ReadOnly = true;
            this.dgvTransactionDetail.RowHeadersWidth = 51;
            this.dgvTransactionDetail.RowTemplate.Height = 24;
            this.dgvTransactionDetail.Size = new System.Drawing.Size(600, 130);
            this.dgvTransactionDetail.TabIndex = 18;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(50, 75);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.Size = new System.Drawing.Size(600, 130);
            this.dgvTransaction.TabIndex = 17;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            // 
            // cbxFileList
            // 
            this.cbxFileList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFileList.FormattingEnabled = true;
            this.cbxFileList.Location = new System.Drawing.Point(50, 40);
            this.cbxFileList.Name = "cbxFileList";
            this.cbxFileList.Size = new System.Drawing.Size(600, 28);
            this.cbxFileList.TabIndex = 14;
            this.cbxFileList.SelectedIndexChanged += new System.EventHandler(this.cbxFileList_SelectedIndexChanged);
            // 
            // tpgAnalysis
            // 
            this.tpgAnalysis.Controls.Add(this.zedGraphControl1);
            this.tpgAnalysis.Controls.Add(this.gbxSaleView);
            this.tpgAnalysis.Controls.Add(this.gbxChartStyle);
            this.tpgAnalysis.Location = new System.Drawing.Point(4, 34);
            this.tpgAnalysis.Name = "tpgAnalysis";
            this.tpgAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAnalysis.Size = new System.Drawing.Size(700, 497);
            this.tpgAnalysis.TabIndex = 1;
            this.tpgAnalysis.Text = "Analysis";
            this.tpgAnalysis.UseVisualStyleBackColor = true;
            // 
            // gbxSaleView
            // 
            this.gbxSaleView.Controls.Add(this.rbnTransaction);
            this.gbxSaleView.Controls.Add(this.rbnTransactionTotal);
            this.gbxSaleView.Controls.Add(this.rbnTransactionItem);
            this.gbxSaleView.Controls.Add(this.rbnTransactionDate);
            this.gbxSaleView.Controls.Add(this.rbnTransactionCategory);
            this.gbxSaleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSaleView.Location = new System.Drawing.Point(450, 80);
            this.gbxSaleView.Name = "gbxSaleView";
            this.gbxSaleView.Size = new System.Drawing.Size(240, 150);
            this.gbxSaleView.TabIndex = 3;
            this.gbxSaleView.TabStop = false;
            this.gbxSaleView.Text = "Sale View";
            // 
            // rbnTransaction
            // 
            this.rbnTransaction.AutoSize = true;
            this.rbnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTransaction.ForeColor = System.Drawing.Color.DimGray;
            this.rbnTransaction.Location = new System.Drawing.Point(8, 125);
            this.rbnTransaction.Name = "rbnTransaction";
            this.rbnTransaction.Size = new System.Drawing.Size(107, 22);
            this.rbnTransaction.TabIndex = 8;
            this.rbnTransaction.TabStop = true;
            this.rbnTransaction.Text = "Transaction";
            this.rbnTransaction.UseVisualStyleBackColor = true;
            // 
            // rbnTransactionTotal
            // 
            this.rbnTransactionTotal.AutoSize = true;
            this.rbnTransactionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTransactionTotal.ForeColor = System.Drawing.Color.DimGray;
            this.rbnTransactionTotal.Location = new System.Drawing.Point(8, 100);
            this.rbnTransactionTotal.Name = "rbnTransactionTotal";
            this.rbnTransactionTotal.Size = new System.Drawing.Size(144, 22);
            this.rbnTransactionTotal.TabIndex = 7;
            this.rbnTransactionTotal.TabStop = true;
            this.rbnTransactionTotal.Text = "Transaction Total";
            this.rbnTransactionTotal.UseVisualStyleBackColor = true;
            // 
            // rbnTransactionItem
            // 
            this.rbnTransactionItem.AutoSize = true;
            this.rbnTransactionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTransactionItem.ForeColor = System.Drawing.Color.DimGray;
            this.rbnTransactionItem.Location = new System.Drawing.Point(8, 75);
            this.rbnTransactionItem.Name = "rbnTransactionItem";
            this.rbnTransactionItem.Size = new System.Drawing.Size(139, 22);
            this.rbnTransactionItem.TabIndex = 6;
            this.rbnTransactionItem.TabStop = true;
            this.rbnTransactionItem.Text = "Transaction Item";
            this.rbnTransactionItem.UseVisualStyleBackColor = true;
            this.rbnTransactionItem.CheckedChanged += new System.EventHandler(this.displaychart);
            // 
            // rbnTransactionDate
            // 
            this.rbnTransactionDate.AutoSize = true;
            this.rbnTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTransactionDate.ForeColor = System.Drawing.Color.DimGray;
            this.rbnTransactionDate.Location = new System.Drawing.Point(8, 50);
            this.rbnTransactionDate.Name = "rbnTransactionDate";
            this.rbnTransactionDate.Size = new System.Drawing.Size(142, 22);
            this.rbnTransactionDate.TabIndex = 5;
            this.rbnTransactionDate.TabStop = true;
            this.rbnTransactionDate.Text = "Transaction Date";
            this.rbnTransactionDate.UseVisualStyleBackColor = true;
            // 
            // rbnTransactionCategory
            // 
            this.rbnTransactionCategory.AutoSize = true;
            this.rbnTransactionCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTransactionCategory.ForeColor = System.Drawing.Color.DimGray;
            this.rbnTransactionCategory.Location = new System.Drawing.Point(8, 25);
            this.rbnTransactionCategory.Name = "rbnTransactionCategory";
            this.rbnTransactionCategory.Size = new System.Drawing.Size(171, 22);
            this.rbnTransactionCategory.TabIndex = 4;
            this.rbnTransactionCategory.TabStop = true;
            this.rbnTransactionCategory.Text = "Transaction Category";
            this.rbnTransactionCategory.UseVisualStyleBackColor = true;
            // 
            // gbxChartStyle
            // 
            this.gbxChartStyle.Controls.Add(this.rbnPieChart);
            this.gbxChartStyle.Controls.Add(this.rbnLineChart);
            this.gbxChartStyle.Controls.Add(this.rbnBarChart);
            this.gbxChartStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxChartStyle.Location = new System.Drawing.Point(450, 0);
            this.gbxChartStyle.Name = "gbxChartStyle";
            this.gbxChartStyle.Size = new System.Drawing.Size(240, 80);
            this.gbxChartStyle.TabIndex = 2;
            this.gbxChartStyle.TabStop = false;
            this.gbxChartStyle.Text = "Chart Style";
            // 
            // rbnPieChart
            // 
            this.rbnPieChart.AutoSize = true;
            this.rbnPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPieChart.ForeColor = System.Drawing.Color.DimGray;
            this.rbnPieChart.Location = new System.Drawing.Point(8, 50);
            this.rbnPieChart.Name = "rbnPieChart";
            this.rbnPieChart.Size = new System.Drawing.Size(90, 22);
            this.rbnPieChart.TabIndex = 5;
            this.rbnPieChart.TabStop = true;
            this.rbnPieChart.Text = "Pie Chart";
            this.rbnPieChart.UseVisualStyleBackColor = true;
            // 
            // rbnLineChart
            // 
            this.rbnLineChart.AutoSize = true;
            this.rbnLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLineChart.ForeColor = System.Drawing.Color.DimGray;
            this.rbnLineChart.Location = new System.Drawing.Point(132, 25);
            this.rbnLineChart.Name = "rbnLineChart";
            this.rbnLineChart.Size = new System.Drawing.Size(96, 22);
            this.rbnLineChart.TabIndex = 4;
            this.rbnLineChart.TabStop = true;
            this.rbnLineChart.Text = "Line Chart";
            this.rbnLineChart.UseVisualStyleBackColor = true;
            // 
            // rbnBarChart
            // 
            this.rbnBarChart.AutoSize = true;
            this.rbnBarChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnBarChart.ForeColor = System.Drawing.Color.DimGray;
            this.rbnBarChart.Location = new System.Drawing.Point(8, 25);
            this.rbnBarChart.Name = "rbnBarChart";
            this.rbnBarChart.Size = new System.Drawing.Size(92, 22);
            this.rbnBarChart.TabIndex = 3;
            this.rbnBarChart.TabStop = true;
            this.rbnBarChart.Text = "Bar Chart";
            this.rbnBarChart.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(538, 54);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IS_SUKIYA.Properties.Resources._16pic_9250342_b;
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(31, 18);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(404, 453);
            this.zedGraphControl1.TabIndex = 4;
            // 
            // frmSaleRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::IS_SUKIYA.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(780, 672);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tclRecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmSaleRecord";
            this.Text = "Sale Record";
            this.tclRecord.ResumeLayout(false);
            this.tpgQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.tpgAnalysis.ResumeLayout(false);
            this.gbxSaleView.ResumeLayout(false);
            this.gbxSaleView.PerformLayout();
            this.gbxChartStyle.ResumeLayout(false);
            this.gbxChartStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclRecord;
        private System.Windows.Forms.TabPage tpgQuery;
        private System.Windows.Forms.TabPage tpgAnalysis;
        private System.Windows.Forms.ComboBox cbxFileList;
        private System.Windows.Forms.DataGridView dgvTransactionDetail;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxSaleView;
        private System.Windows.Forms.GroupBox gbxChartStyle;
        private System.Windows.Forms.RadioButton rbnTransaction;
        private System.Windows.Forms.RadioButton rbnTransactionTotal;
        private System.Windows.Forms.RadioButton rbnTransactionItem;
        private System.Windows.Forms.RadioButton rbnTransactionDate;
        private System.Windows.Forms.RadioButton rbnTransactionCategory;
        private System.Windows.Forms.RadioButton rbnPieChart;
        private System.Windows.Forms.RadioButton rbnLineChart;
        private System.Windows.Forms.RadioButton rbnBarChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}