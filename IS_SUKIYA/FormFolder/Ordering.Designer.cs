
namespace IS_SUKIYA.FormFolder
{
    partial class frmOrdering
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
            this.tclOrdering = new System.Windows.Forms.TabControl();
            this.tpgOrderCbx = new System.Windows.Forms.TabPage();
            this.tbxOrderCbxSubTotal = new System.Windows.Forms.TextBox();
            this.tbxOrderCbxTotal = new System.Windows.Forms.TextBox();
            this.labOrderCbxTotal = new System.Windows.Forms.Label();
            this.btnOrderCbxCheckOut = new System.Windows.Forms.Button();
            this.btnOrderCbxDelete = new System.Windows.Forms.Button();
            this.btnOrderCbxClearAll = new System.Windows.Forms.Button();
            this.gbxOrderCbxOrderList = new System.Windows.Forms.GroupBox();
            this.clbAddOn = new System.Windows.Forms.CheckedListBox();
            this.clbOrderList = new System.Windows.Forms.CheckedListBox();
            this.labOrderCbxSubTotal = new System.Windows.Forms.Label();
            this.gbxOrderCbxMakeOrder = new System.Windows.Forms.GroupBox();
            this.cbxOrderCbxOption3 = new System.Windows.Forms.ComboBox();
            this.cbxOrderCbxOption2 = new System.Windows.Forms.ComboBox();
            this.cbxOrderCbxOption1 = new System.Windows.Forms.ComboBox();
            this.nudOrderCbxQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbxOrderCbxUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxOrderCbxItem = new System.Windows.Forms.ComboBox();
            this.cbxOrderCbxCategory = new System.Windows.Forms.ComboBox();
            this.btnOrderCbxOrder = new System.Windows.Forms.Button();
            this.labOrderCbxQuantity = new System.Windows.Forms.Label();
            this.labOrderCbxUnitPrice = new System.Windows.Forms.Label();
            this.labOrderCbxItem = new System.Windows.Forms.Label();
            this.labOrderCbxCategory = new System.Windows.Forms.Label();
            this.tpgOrderDGV = new System.Windows.Forms.TabPage();
            this.gbxOrderDGVSubTotal = new System.Windows.Forms.GroupBox();
            this.btnOrderDGVOrder = new System.Windows.Forms.Button();
            this.tbxOrderDGVSubTotal = new System.Windows.Forms.TextBox();
            this.labOrderDGVSubTotal = new System.Windows.Forms.Label();
            this.nudOrderDGVQuantity = new System.Windows.Forms.NumericUpDown();
            this.labOrderDGVQuantity = new System.Windows.Forms.Label();
            this.gbxOrderDGVOrderList = new System.Windows.Forms.GroupBox();
            this.btnOrderDGVCheckOut = new System.Windows.Forms.Button();
            this.btnOrderDGVDelete = new System.Windows.Forms.Button();
            this.btnOrderDGVClearAll = new System.Windows.Forms.Button();
            this.tbxOrderDGVTotal = new System.Windows.Forms.TextBox();
            this.labDGVTotal = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.dgvOption = new System.Windows.Forms.DataGridView();
            this.dgvAddon = new System.Windows.Forms.DataGridView();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.cbxOrderDGVCategory = new System.Windows.Forms.ComboBox();
            this.labOrderDGVCategory = new System.Windows.Forms.Label();
            this.panSaveFileType = new System.Windows.Forms.Panel();
            this.cbnData = new System.Windows.Forms.CheckBox();
            this.labSaveFileType = new System.Windows.Forms.Label();
            this.cbnReport = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofdStore = new System.Windows.Forms.OpenFileDialog();
            this.sfdStore = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tclOrdering.SuspendLayout();
            this.tpgOrderCbx.SuspendLayout();
            this.gbxOrderCbxOrderList.SuspendLayout();
            this.gbxOrderCbxMakeOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderCbxQuantity)).BeginInit();
            this.tpgOrderDGV.SuspendLayout();
            this.gbxOrderDGVSubTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderDGVQuantity)).BeginInit();
            this.gbxOrderDGVOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.panSaveFileType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tclOrdering
            // 
            this.tclOrdering.Controls.Add(this.tpgOrderCbx);
            this.tclOrdering.Controls.Add(this.tpgOrderDGV);
            this.tclOrdering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclOrdering.Location = new System.Drawing.Point(12, 111);
            this.tclOrdering.Name = "tclOrdering";
            this.tclOrdering.SelectedIndex = 0;
            this.tclOrdering.Size = new System.Drawing.Size(708, 348);
            this.tclOrdering.TabIndex = 0;
            this.tclOrdering.SelectedIndexChanged += new System.EventHandler(this.tclOrdering_SelectedIndexChanged);
            // 
            // tpgOrderCbx
            // 
            this.tpgOrderCbx.Controls.Add(this.tbxOrderCbxSubTotal);
            this.tpgOrderCbx.Controls.Add(this.tbxOrderCbxTotal);
            this.tpgOrderCbx.Controls.Add(this.labOrderCbxTotal);
            this.tpgOrderCbx.Controls.Add(this.btnOrderCbxCheckOut);
            this.tpgOrderCbx.Controls.Add(this.btnOrderCbxDelete);
            this.tpgOrderCbx.Controls.Add(this.btnOrderCbxClearAll);
            this.tpgOrderCbx.Controls.Add(this.gbxOrderCbxOrderList);
            this.tpgOrderCbx.Controls.Add(this.labOrderCbxSubTotal);
            this.tpgOrderCbx.Controls.Add(this.gbxOrderCbxMakeOrder);
            this.tpgOrderCbx.Location = new System.Drawing.Point(4, 34);
            this.tpgOrderCbx.Name = "tpgOrderCbx";
            this.tpgOrderCbx.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOrderCbx.Size = new System.Drawing.Size(700, 310);
            this.tpgOrderCbx.TabIndex = 0;
            this.tpgOrderCbx.Text = "Order Process";
            this.tpgOrderCbx.UseVisualStyleBackColor = true;
            this.tpgOrderCbx.Enter += new System.EventHandler(this.tpgOrderCbx_Enter);
            // 
            // tbxOrderCbxSubTotal
            // 
            this.tbxOrderCbxSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderCbxSubTotal.Location = new System.Drawing.Point(110, 270);
            this.tbxOrderCbxSubTotal.Name = "tbxOrderCbxSubTotal";
            this.tbxOrderCbxSubTotal.ReadOnly = true;
            this.tbxOrderCbxSubTotal.Size = new System.Drawing.Size(80, 27);
            this.tbxOrderCbxSubTotal.TabIndex = 21;
            this.tbxOrderCbxSubTotal.Text = "0";
            // 
            // tbxOrderCbxTotal
            // 
            this.tbxOrderCbxTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxOrderCbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderCbxTotal.Location = new System.Drawing.Point(290, 270);
            this.tbxOrderCbxTotal.Name = "tbxOrderCbxTotal";
            this.tbxOrderCbxTotal.ReadOnly = true;
            this.tbxOrderCbxTotal.Size = new System.Drawing.Size(80, 27);
            this.tbxOrderCbxTotal.TabIndex = 22;
            this.tbxOrderCbxTotal.Text = "0";
            // 
            // labOrderCbxTotal
            // 
            this.labOrderCbxTotal.AutoSize = true;
            this.labOrderCbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxTotal.ForeColor = System.Drawing.Color.Olive;
            this.labOrderCbxTotal.Location = new System.Drawing.Point(230, 270);
            this.labOrderCbxTotal.Name = "labOrderCbxTotal";
            this.labOrderCbxTotal.Size = new System.Drawing.Size(56, 25);
            this.labOrderCbxTotal.TabIndex = 16;
            this.labOrderCbxTotal.Text = "Total";
            // 
            // btnOrderCbxCheckOut
            // 
            this.btnOrderCbxCheckOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderCbxCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCbxCheckOut.Location = new System.Drawing.Point(590, 260);
            this.btnOrderCbxCheckOut.Name = "btnOrderCbxCheckOut";
            this.btnOrderCbxCheckOut.Size = new System.Drawing.Size(100, 30);
            this.btnOrderCbxCheckOut.TabIndex = 15;
            this.btnOrderCbxCheckOut.Text = "Check Out";
            this.btnOrderCbxCheckOut.UseVisualStyleBackColor = false;
            this.btnOrderCbxCheckOut.Click += new System.EventHandler(this.btnOrderCbxCheckOut_Click);
            // 
            // btnOrderCbxDelete
            // 
            this.btnOrderCbxDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderCbxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCbxDelete.Location = new System.Drawing.Point(500, 260);
            this.btnOrderCbxDelete.Name = "btnOrderCbxDelete";
            this.btnOrderCbxDelete.Size = new System.Drawing.Size(80, 30);
            this.btnOrderCbxDelete.TabIndex = 14;
            this.btnOrderCbxDelete.Text = "Delete";
            this.btnOrderCbxDelete.UseVisualStyleBackColor = false;
            this.btnOrderCbxDelete.Click += new System.EventHandler(this.btnOrderCbxDelete_Click);
            // 
            // btnOrderCbxClearAll
            // 
            this.btnOrderCbxClearAll.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderCbxClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCbxClearAll.Location = new System.Drawing.Point(390, 260);
            this.btnOrderCbxClearAll.Name = "btnOrderCbxClearAll";
            this.btnOrderCbxClearAll.Size = new System.Drawing.Size(100, 30);
            this.btnOrderCbxClearAll.TabIndex = 13;
            this.btnOrderCbxClearAll.Text = "Clear All";
            this.btnOrderCbxClearAll.UseVisualStyleBackColor = false;
            this.btnOrderCbxClearAll.Click += new System.EventHandler(this.btnOrderCbxClearAll_Click);
            // 
            // gbxOrderCbxOrderList
            // 
            this.gbxOrderCbxOrderList.Controls.Add(this.clbAddOn);
            this.gbxOrderCbxOrderList.Controls.Add(this.clbOrderList);
            this.gbxOrderCbxOrderList.Location = new System.Drawing.Point(10, 116);
            this.gbxOrderCbxOrderList.Name = "gbxOrderCbxOrderList";
            this.gbxOrderCbxOrderList.Size = new System.Drawing.Size(680, 140);
            this.gbxOrderCbxOrderList.TabIndex = 1;
            this.gbxOrderCbxOrderList.TabStop = false;
            this.gbxOrderCbxOrderList.Text = "Order list";
            // 
            // clbAddOn
            // 
            this.clbAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAddOn.FormattingEnabled = true;
            this.clbAddOn.Location = new System.Drawing.Point(380, 25);
            this.clbAddOn.Name = "clbAddOn";
            this.clbAddOn.Size = new System.Drawing.Size(295, 80);
            this.clbAddOn.TabIndex = 1;
            this.clbAddOn.SelectedIndexChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // clbOrderList
            // 
            this.clbOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbOrderList.FormattingEnabled = true;
            this.clbOrderList.Location = new System.Drawing.Point(5, 25);
            this.clbOrderList.Name = "clbOrderList";
            this.clbOrderList.Size = new System.Drawing.Size(375, 80);
            this.clbOrderList.TabIndex = 0;
            // 
            // labOrderCbxSubTotal
            // 
            this.labOrderCbxSubTotal.AutoSize = true;
            this.labOrderCbxSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxSubTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderCbxSubTotal.Location = new System.Drawing.Point(10, 270);
            this.labOrderCbxSubTotal.Name = "labOrderCbxSubTotal";
            this.labOrderCbxSubTotal.Size = new System.Drawing.Size(97, 25);
            this.labOrderCbxSubTotal.TabIndex = 17;
            this.labOrderCbxSubTotal.Text = "Sub Total";
            // 
            // gbxOrderCbxMakeOrder
            // 
            this.gbxOrderCbxMakeOrder.Controls.Add(this.cbxOrderCbxOption3);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.cbxOrderCbxOption2);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.cbxOrderCbxOption1);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.nudOrderCbxQuantity);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.tbxOrderCbxUnitPrice);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.cbxOrderCbxItem);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.cbxOrderCbxCategory);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.btnOrderCbxOrder);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.labOrderCbxQuantity);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.labOrderCbxUnitPrice);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.labOrderCbxItem);
            this.gbxOrderCbxMakeOrder.Controls.Add(this.labOrderCbxCategory);
            this.gbxOrderCbxMakeOrder.Location = new System.Drawing.Point(10, 10);
            this.gbxOrderCbxMakeOrder.Name = "gbxOrderCbxMakeOrder";
            this.gbxOrderCbxMakeOrder.Size = new System.Drawing.Size(680, 100);
            this.gbxOrderCbxMakeOrder.TabIndex = 0;
            this.gbxOrderCbxMakeOrder.TabStop = false;
            this.gbxOrderCbxMakeOrder.Text = "Make an order";
            // 
            // cbxOrderCbxOption3
            // 
            this.cbxOrderCbxOption3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderCbxOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderCbxOption3.FormattingEnabled = true;
            this.cbxOrderCbxOption3.Location = new System.Drawing.Point(580, 25);
            this.cbxOrderCbxOption3.Name = "cbxOrderCbxOption3";
            this.cbxOrderCbxOption3.Size = new System.Drawing.Size(100, 28);
            this.cbxOrderCbxOption3.TabIndex = 23;
            this.cbxOrderCbxOption3.SelectedIndexChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // cbxOrderCbxOption2
            // 
            this.cbxOrderCbxOption2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderCbxOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderCbxOption2.FormattingEnabled = true;
            this.cbxOrderCbxOption2.Location = new System.Drawing.Point(480, 25);
            this.cbxOrderCbxOption2.Name = "cbxOrderCbxOption2";
            this.cbxOrderCbxOption2.Size = new System.Drawing.Size(100, 28);
            this.cbxOrderCbxOption2.TabIndex = 22;
            this.cbxOrderCbxOption2.SelectedIndexChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // cbxOrderCbxOption1
            // 
            this.cbxOrderCbxOption1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderCbxOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderCbxOption1.FormattingEnabled = true;
            this.cbxOrderCbxOption1.Location = new System.Drawing.Point(480, 60);
            this.cbxOrderCbxOption1.Name = "cbxOrderCbxOption1";
            this.cbxOrderCbxOption1.Size = new System.Drawing.Size(100, 28);
            this.cbxOrderCbxOption1.TabIndex = 21;
            this.cbxOrderCbxOption1.SelectedIndexChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // nudOrderCbxQuantity
            // 
            this.nudOrderCbxQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.nudOrderCbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOrderCbxQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudOrderCbxQuantity.Location = new System.Drawing.Point(390, 60);
            this.nudOrderCbxQuantity.Name = "nudOrderCbxQuantity";
            this.nudOrderCbxQuantity.Size = new System.Drawing.Size(80, 27);
            this.nudOrderCbxQuantity.TabIndex = 20;
            this.nudOrderCbxQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrderCbxQuantity.ValueChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // tbxOrderCbxUnitPrice
            // 
            this.tbxOrderCbxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderCbxUnitPrice.Location = new System.Drawing.Point(290, 60);
            this.tbxOrderCbxUnitPrice.Name = "tbxOrderCbxUnitPrice";
            this.tbxOrderCbxUnitPrice.ReadOnly = true;
            this.tbxOrderCbxUnitPrice.Size = new System.Drawing.Size(80, 27);
            this.tbxOrderCbxUnitPrice.TabIndex = 19;
            this.tbxOrderCbxUnitPrice.TextChanged += new System.EventHandler(this.computeSubTotal);
            // 
            // cbxOrderCbxItem
            // 
            this.cbxOrderCbxItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderCbxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderCbxItem.FormattingEnabled = true;
            this.cbxOrderCbxItem.Location = new System.Drawing.Point(150, 60);
            this.cbxOrderCbxItem.Name = "cbxOrderCbxItem";
            this.cbxOrderCbxItem.Size = new System.Drawing.Size(120, 28);
            this.cbxOrderCbxItem.TabIndex = 18;
            this.cbxOrderCbxItem.SelectedIndexChanged += new System.EventHandler(this.cbxOrderCbxItem_SelectedIndexChanged);
            // 
            // cbxOrderCbxCategory
            // 
            this.cbxOrderCbxCategory.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderCbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderCbxCategory.FormattingEnabled = true;
            this.cbxOrderCbxCategory.Items.AddRange(new object[] {
            "Donburi",
            "Curry",
            "Single"});
            this.cbxOrderCbxCategory.Location = new System.Drawing.Point(15, 60);
            this.cbxOrderCbxCategory.Name = "cbxOrderCbxCategory";
            this.cbxOrderCbxCategory.Size = new System.Drawing.Size(120, 28);
            this.cbxOrderCbxCategory.TabIndex = 13;
            this.cbxOrderCbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxOrderCbxCategory_SelectedIndexChanged);
            // 
            // btnOrderCbxOrder
            // 
            this.btnOrderCbxOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderCbxOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderCbxOrder.Location = new System.Drawing.Point(590, 60);
            this.btnOrderCbxOrder.Name = "btnOrderCbxOrder";
            this.btnOrderCbxOrder.Size = new System.Drawing.Size(80, 30);
            this.btnOrderCbxOrder.TabIndex = 5;
            this.btnOrderCbxOrder.Text = "Order";
            this.btnOrderCbxOrder.UseVisualStyleBackColor = false;
            this.btnOrderCbxOrder.Click += new System.EventHandler(this.btnOrderCbxOrder_Click);
            // 
            // labOrderCbxQuantity
            // 
            this.labOrderCbxQuantity.AutoSize = true;
            this.labOrderCbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxQuantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderCbxQuantity.Location = new System.Drawing.Point(390, 25);
            this.labOrderCbxQuantity.Name = "labOrderCbxQuantity";
            this.labOrderCbxQuantity.Size = new System.Drawing.Size(85, 25);
            this.labOrderCbxQuantity.TabIndex = 16;
            this.labOrderCbxQuantity.Text = "Quantity";
            // 
            // labOrderCbxUnitPrice
            // 
            this.labOrderCbxUnitPrice.AutoSize = true;
            this.labOrderCbxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxUnitPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderCbxUnitPrice.Location = new System.Drawing.Point(290, 25);
            this.labOrderCbxUnitPrice.Name = "labOrderCbxUnitPrice";
            this.labOrderCbxUnitPrice.Size = new System.Drawing.Size(95, 25);
            this.labOrderCbxUnitPrice.TabIndex = 15;
            this.labOrderCbxUnitPrice.Text = "Unit Price";
            // 
            // labOrderCbxItem
            // 
            this.labOrderCbxItem.AutoSize = true;
            this.labOrderCbxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderCbxItem.Location = new System.Drawing.Point(150, 25);
            this.labOrderCbxItem.Name = "labOrderCbxItem";
            this.labOrderCbxItem.Size = new System.Drawing.Size(49, 25);
            this.labOrderCbxItem.TabIndex = 14;
            this.labOrderCbxItem.Text = "Item";
            // 
            // labOrderCbxCategory
            // 
            this.labOrderCbxCategory.AutoSize = true;
            this.labOrderCbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderCbxCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderCbxCategory.Location = new System.Drawing.Point(10, 25);
            this.labOrderCbxCategory.Name = "labOrderCbxCategory";
            this.labOrderCbxCategory.Size = new System.Drawing.Size(92, 25);
            this.labOrderCbxCategory.TabIndex = 13;
            this.labOrderCbxCategory.Text = "Category";
            // 
            // tpgOrderDGV
            // 
            this.tpgOrderDGV.Controls.Add(this.gbxOrderDGVSubTotal);
            this.tpgOrderDGV.Controls.Add(this.gbxOrderDGVOrderList);
            this.tpgOrderDGV.Controls.Add(this.dgvOption);
            this.tpgOrderDGV.Controls.Add(this.dgvAddon);
            this.tpgOrderDGV.Controls.Add(this.dgvItem);
            this.tpgOrderDGV.Controls.Add(this.cbxOrderDGVCategory);
            this.tpgOrderDGV.Controls.Add(this.labOrderDGVCategory);
            this.tpgOrderDGV.Location = new System.Drawing.Point(4, 34);
            this.tpgOrderDGV.Name = "tpgOrderDGV";
            this.tpgOrderDGV.Padding = new System.Windows.Forms.Padding(3);
            this.tpgOrderDGV.Size = new System.Drawing.Size(700, 310);
            this.tpgOrderDGV.TabIndex = 2;
            this.tpgOrderDGV.Text = "Order";
            this.tpgOrderDGV.UseVisualStyleBackColor = true;
            this.tpgOrderDGV.Enter += new System.EventHandler(this.tpgOrderDGV_Enter);
            // 
            // gbxOrderDGVSubTotal
            // 
            this.gbxOrderDGVSubTotal.Controls.Add(this.btnOrderDGVOrder);
            this.gbxOrderDGVSubTotal.Controls.Add(this.tbxOrderDGVSubTotal);
            this.gbxOrderDGVSubTotal.Controls.Add(this.labOrderDGVSubTotal);
            this.gbxOrderDGVSubTotal.Controls.Add(this.nudOrderDGVQuantity);
            this.gbxOrderDGVSubTotal.Controls.Add(this.labOrderDGVQuantity);
            this.gbxOrderDGVSubTotal.Location = new System.Drawing.Point(420, 100);
            this.gbxOrderDGVSubTotal.Name = "gbxOrderDGVSubTotal";
            this.gbxOrderDGVSubTotal.Size = new System.Drawing.Size(270, 80);
            this.gbxOrderDGVSubTotal.TabIndex = 20;
            this.gbxOrderDGVSubTotal.TabStop = false;
            // 
            // btnOrderDGVOrder
            // 
            this.btnOrderDGVOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderDGVOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDGVOrder.Location = new System.Drawing.Point(185, 45);
            this.btnOrderDGVOrder.Name = "btnOrderDGVOrder";
            this.btnOrderDGVOrder.Size = new System.Drawing.Size(80, 30);
            this.btnOrderDGVOrder.TabIndex = 24;
            this.btnOrderDGVOrder.Text = "Order";
            this.btnOrderDGVOrder.UseVisualStyleBackColor = false;
            // 
            // tbxOrderDGVSubTotal
            // 
            this.tbxOrderDGVSubTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxOrderDGVSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderDGVSubTotal.Location = new System.Drawing.Point(95, 45);
            this.tbxOrderDGVSubTotal.Name = "tbxOrderDGVSubTotal";
            this.tbxOrderDGVSubTotal.Size = new System.Drawing.Size(80, 27);
            this.tbxOrderDGVSubTotal.TabIndex = 23;
            this.tbxOrderDGVSubTotal.Text = "0";
            // 
            // labOrderDGVSubTotal
            // 
            this.labOrderDGVSubTotal.AutoSize = true;
            this.labOrderDGVSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderDGVSubTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderDGVSubTotal.Location = new System.Drawing.Point(95, 15);
            this.labOrderDGVSubTotal.Name = "labOrderDGVSubTotal";
            this.labOrderDGVSubTotal.Size = new System.Drawing.Size(97, 25);
            this.labOrderDGVSubTotal.TabIndex = 22;
            this.labOrderDGVSubTotal.Text = "Sub Total";
            // 
            // nudOrderDGVQuantity
            // 
            this.nudOrderDGVQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.nudOrderDGVQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOrderDGVQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudOrderDGVQuantity.Location = new System.Drawing.Point(5, 45);
            this.nudOrderDGVQuantity.Name = "nudOrderDGVQuantity";
            this.nudOrderDGVQuantity.Size = new System.Drawing.Size(80, 27);
            this.nudOrderDGVQuantity.TabIndex = 21;
            this.nudOrderDGVQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labOrderDGVQuantity
            // 
            this.labOrderDGVQuantity.AutoSize = true;
            this.labOrderDGVQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderDGVQuantity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderDGVQuantity.Location = new System.Drawing.Point(5, 15);
            this.labOrderDGVQuantity.Name = "labOrderDGVQuantity";
            this.labOrderDGVQuantity.Size = new System.Drawing.Size(85, 25);
            this.labOrderDGVQuantity.TabIndex = 17;
            this.labOrderDGVQuantity.Text = "Quantity";
            // 
            // gbxOrderDGVOrderList
            // 
            this.gbxOrderDGVOrderList.Controls.Add(this.btnOrderDGVCheckOut);
            this.gbxOrderDGVOrderList.Controls.Add(this.btnOrderDGVDelete);
            this.gbxOrderDGVOrderList.Controls.Add(this.btnOrderDGVClearAll);
            this.gbxOrderDGVOrderList.Controls.Add(this.tbxOrderDGVTotal);
            this.gbxOrderDGVOrderList.Controls.Add(this.labDGVTotal);
            this.gbxOrderDGVOrderList.Controls.Add(this.dgvOrderList);
            this.gbxOrderDGVOrderList.Location = new System.Drawing.Point(10, 180);
            this.gbxOrderDGVOrderList.Name = "gbxOrderDGVOrderList";
            this.gbxOrderDGVOrderList.Size = new System.Drawing.Size(680, 120);
            this.gbxOrderDGVOrderList.TabIndex = 19;
            this.gbxOrderDGVOrderList.TabStop = false;
            this.gbxOrderDGVOrderList.Text = "Order list";
            // 
            // btnOrderDGVCheckOut
            // 
            this.btnOrderDGVCheckOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderDGVCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDGVCheckOut.Location = new System.Drawing.Point(575, 85);
            this.btnOrderDGVCheckOut.Name = "btnOrderDGVCheckOut";
            this.btnOrderDGVCheckOut.Size = new System.Drawing.Size(100, 30);
            this.btnOrderDGVCheckOut.TabIndex = 26;
            this.btnOrderDGVCheckOut.Text = "Check Out";
            this.btnOrderDGVCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnOrderDGVDelete
            // 
            this.btnOrderDGVDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderDGVDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDGVDelete.Location = new System.Drawing.Point(595, 50);
            this.btnOrderDGVDelete.Name = "btnOrderDGVDelete";
            this.btnOrderDGVDelete.Size = new System.Drawing.Size(80, 30);
            this.btnOrderDGVDelete.TabIndex = 25;
            this.btnOrderDGVDelete.Text = "Delete";
            this.btnOrderDGVDelete.UseVisualStyleBackColor = false;
            // 
            // btnOrderDGVClearAll
            // 
            this.btnOrderDGVClearAll.BackColor = System.Drawing.Color.OrangeRed;
            this.btnOrderDGVClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDGVClearAll.Location = new System.Drawing.Point(490, 50);
            this.btnOrderDGVClearAll.Name = "btnOrderDGVClearAll";
            this.btnOrderDGVClearAll.Size = new System.Drawing.Size(100, 30);
            this.btnOrderDGVClearAll.TabIndex = 24;
            this.btnOrderDGVClearAll.Text = "Clear All";
            this.btnOrderDGVClearAll.UseVisualStyleBackColor = false;
            // 
            // tbxOrderDGVTotal
            // 
            this.tbxOrderDGVTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.tbxOrderDGVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOrderDGVTotal.Location = new System.Drawing.Point(575, 20);
            this.tbxOrderDGVTotal.Name = "tbxOrderDGVTotal";
            this.tbxOrderDGVTotal.Size = new System.Drawing.Size(100, 27);
            this.tbxOrderDGVTotal.TabIndex = 23;
            this.tbxOrderDGVTotal.Text = "0";
            // 
            // labDGVTotal
            // 
            this.labDGVTotal.AutoSize = true;
            this.labDGVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDGVTotal.ForeColor = System.Drawing.Color.Olive;
            this.labDGVTotal.Location = new System.Drawing.Point(510, 20);
            this.labDGVTotal.Name = "labDGVTotal";
            this.labDGVTotal.Size = new System.Drawing.Size(56, 25);
            this.labDGVTotal.TabIndex = 20;
            this.labDGVTotal.Text = "Total";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(5, 25);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.Size = new System.Drawing.Size(480, 90);
            this.dgvOrderList.TabIndex = 19;
            // 
            // dgvOption
            // 
            this.dgvOption.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOption.Location = new System.Drawing.Point(420, 10);
            this.dgvOption.Name = "dgvOption";
            this.dgvOption.RowHeadersWidth = 51;
            this.dgvOption.RowTemplate.Height = 24;
            this.dgvOption.Size = new System.Drawing.Size(270, 90);
            this.dgvOption.TabIndex = 18;
            // 
            // dgvAddon
            // 
            this.dgvAddon.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvAddon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddon.Location = new System.Drawing.Point(200, 50);
            this.dgvAddon.Name = "dgvAddon";
            this.dgvAddon.RowHeadersWidth = 51;
            this.dgvAddon.RowTemplate.Height = 24;
            this.dgvAddon.Size = new System.Drawing.Size(210, 130);
            this.dgvAddon.TabIndex = 17;
            // 
            // dgvItem
            // 
            this.dgvItem.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(10, 50);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(180, 130);
            this.dgvItem.TabIndex = 16;
            // 
            // cbxOrderDGVCategory
            // 
            this.cbxOrderDGVCategory.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxOrderDGVCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderDGVCategory.FormattingEnabled = true;
            this.cbxOrderDGVCategory.Location = new System.Drawing.Point(110, 10);
            this.cbxOrderDGVCategory.Name = "cbxOrderDGVCategory";
            this.cbxOrderDGVCategory.Size = new System.Drawing.Size(300, 28);
            this.cbxOrderDGVCategory.TabIndex = 15;
            // 
            // labOrderDGVCategory
            // 
            this.labOrderDGVCategory.AutoSize = true;
            this.labOrderDGVCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrderDGVCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labOrderDGVCategory.Location = new System.Drawing.Point(10, 10);
            this.labOrderDGVCategory.Name = "labOrderDGVCategory";
            this.labOrderDGVCategory.Size = new System.Drawing.Size(92, 25);
            this.labOrderDGVCategory.TabIndex = 14;
            this.labOrderDGVCategory.Text = "Category";
            // 
            // panSaveFileType
            // 
            this.panSaveFileType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panSaveFileType.Controls.Add(this.cbnData);
            this.panSaveFileType.Controls.Add(this.labSaveFileType);
            this.panSaveFileType.Controls.Add(this.cbnReport);
            this.panSaveFileType.Controls.Add(this.btnSave);
            this.panSaveFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panSaveFileType.Location = new System.Drawing.Point(381, 12);
            this.panSaveFileType.Name = "panSaveFileType";
            this.panSaveFileType.Size = new System.Drawing.Size(200, 100);
            this.panSaveFileType.TabIndex = 1;
            // 
            // cbnData
            // 
            this.cbnData.AutoSize = true;
            this.cbnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnData.Location = new System.Drawing.Point(117, 33);
            this.cbnData.Name = "cbnData";
            this.cbnData.Size = new System.Drawing.Size(75, 29);
            this.cbnData.TabIndex = 15;
            this.cbnData.Text = "Data";
            this.cbnData.UseVisualStyleBackColor = true;
            // 
            // labSaveFileType
            // 
            this.labSaveFileType.AutoSize = true;
            this.labSaveFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSaveFileType.Location = new System.Drawing.Point(10, 5);
            this.labSaveFileType.Name = "labSaveFileType";
            this.labSaveFileType.Size = new System.Drawing.Size(182, 25);
            this.labSaveFileType.TabIndex = 12;
            this.labSaveFileType.Text = "File Type for saving";
            // 
            // cbnReport
            // 
            this.cbnReport.AutoSize = true;
            this.cbnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnReport.Location = new System.Drawing.Point(15, 33);
            this.cbnReport.Name = "cbnReport";
            this.cbnReport.Size = new System.Drawing.Size(91, 29);
            this.cbnReport.TabIndex = 14;
            this.cbnReport.Text = "Report";
            this.cbnReport.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(50, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(610, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofdStore
            // 
            this.ofdStore.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IS_SUKIYA.Properties.Resources.head_logo_sk_2x;
            this.pictureBox1.Location = new System.Drawing.Point(41, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::IS_SUKIYA.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(732, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panSaveFileType);
            this.Controls.Add(this.tclOrdering);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmOrdering";
            this.Text = "Meal Ordering";
            this.tclOrdering.ResumeLayout(false);
            this.tpgOrderCbx.ResumeLayout(false);
            this.tpgOrderCbx.PerformLayout();
            this.gbxOrderCbxOrderList.ResumeLayout(false);
            this.gbxOrderCbxMakeOrder.ResumeLayout(false);
            this.gbxOrderCbxMakeOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderCbxQuantity)).EndInit();
            this.tpgOrderDGV.ResumeLayout(false);
            this.tpgOrderDGV.PerformLayout();
            this.gbxOrderDGVSubTotal.ResumeLayout(false);
            this.gbxOrderDGVSubTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderDGVQuantity)).EndInit();
            this.gbxOrderDGVOrderList.ResumeLayout(false);
            this.gbxOrderDGVOrderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.panSaveFileType.ResumeLayout(false);
            this.panSaveFileType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tclOrdering;
        private System.Windows.Forms.TabPage tpgOrderCbx;
        private System.Windows.Forms.TabPage tpgOrderDGV;
        private System.Windows.Forms.Panel panSaveFileType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labSaveFileType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxOrderCbxMakeOrder;
        private System.Windows.Forms.Label labOrderCbxSubTotal;
        private System.Windows.Forms.Label labOrderCbxQuantity;
        private System.Windows.Forms.Label labOrderCbxUnitPrice;
        private System.Windows.Forms.Label labOrderCbxItem;
        private System.Windows.Forms.Label labOrderCbxCategory;
        private System.Windows.Forms.GroupBox gbxOrderCbxOrderList;
        private System.Windows.Forms.Button btnOrderCbxOrder;
        private System.Windows.Forms.Button btnOrderCbxCheckOut;
        private System.Windows.Forms.Button btnOrderCbxDelete;
        private System.Windows.Forms.Button btnOrderCbxClearAll;
        private System.Windows.Forms.NumericUpDown nudOrderCbxQuantity;
        private System.Windows.Forms.TextBox tbxOrderCbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxOrderCbxItem;
        private System.Windows.Forms.ComboBox cbxOrderCbxCategory;
        private System.Windows.Forms.TextBox tbxOrderCbxTotal;
        private System.Windows.Forms.Label labOrderCbxTotal;
        private System.Windows.Forms.TextBox tbxOrderCbxSubTotal;
        private System.Windows.Forms.ComboBox cbxOrderDGVCategory;
        private System.Windows.Forms.Label labOrderDGVCategory;
        private System.Windows.Forms.GroupBox gbxOrderDGVOrderList;
        private System.Windows.Forms.DataGridView dgvOption;
        private System.Windows.Forms.DataGridView dgvAddon;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.GroupBox gbxOrderDGVSubTotal;
        private System.Windows.Forms.Button btnOrderDGVOrder;
        private System.Windows.Forms.TextBox tbxOrderDGVSubTotal;
        private System.Windows.Forms.Label labOrderDGVSubTotal;
        private System.Windows.Forms.NumericUpDown nudOrderDGVQuantity;
        private System.Windows.Forms.Label labOrderDGVQuantity;
        private System.Windows.Forms.TextBox tbxOrderDGVTotal;
        private System.Windows.Forms.Label labDGVTotal;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnOrderDGVDelete;
        private System.Windows.Forms.Button btnOrderDGVClearAll;
        private System.Windows.Forms.Button btnOrderDGVCheckOut;
        private System.Windows.Forms.OpenFileDialog ofdStore;
        private System.Windows.Forms.SaveFileDialog sfdStore;
        private System.Windows.Forms.CheckedListBox clbOrderList;
        private System.Windows.Forms.CheckedListBox clbAddOn;
        private System.Windows.Forms.ComboBox cbxOrderCbxOption1;
        private System.Windows.Forms.ComboBox cbxOrderCbxOption3;
        private System.Windows.Forms.ComboBox cbxOrderCbxOption2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbnReport;
        private System.Windows.Forms.CheckBox cbnData;
    }
}