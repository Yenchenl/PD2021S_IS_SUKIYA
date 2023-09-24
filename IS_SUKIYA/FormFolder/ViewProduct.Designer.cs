
namespace IS_SUKIYA.FormFolder
{
    partial class frmViewProduct
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
            this.labCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.dgvAddon = new System.Windows.Forms.DataGridView();
            this.dgvOption = new System.Windows.Forms.DataGridView();
            this.panProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).BeginInit();
            this.panProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCategory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labCategory.Location = new System.Drawing.Point(30, 112);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(92, 25);
            this.labCategory.TabIndex = 14;
            this.labCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Donburi",
            "Curry",
            "Single"});
            this.cbxCategory.Location = new System.Drawing.Point(128, 112);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(150, 33);
            this.cbxCategory.TabIndex = 15;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItem.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(0, 0);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(210, 350);
            this.dgvItem.TabIndex = 17;
            // 
            // dgvAddon
            // 
            this.dgvAddon.AllowUserToAddRows = false;
            this.dgvAddon.AllowUserToDeleteRows = false;
            this.dgvAddon.AllowUserToResizeColumns = false;
            this.dgvAddon.AllowUserToResizeRows = false;
            this.dgvAddon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAddon.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvAddon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddon.Location = new System.Drawing.Point(220, 0);
            this.dgvAddon.Name = "dgvAddon";
            this.dgvAddon.ReadOnly = true;
            this.dgvAddon.RowHeadersWidth = 51;
            this.dgvAddon.RowTemplate.Height = 24;
            this.dgvAddon.Size = new System.Drawing.Size(270, 350);
            this.dgvAddon.TabIndex = 18;
            // 
            // dgvOption
            // 
            this.dgvOption.AllowUserToAddRows = false;
            this.dgvOption.AllowUserToDeleteRows = false;
            this.dgvOption.AllowUserToResizeColumns = false;
            this.dgvOption.AllowUserToResizeRows = false;
            this.dgvOption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOption.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOption.Location = new System.Drawing.Point(500, 0);
            this.dgvOption.Name = "dgvOption";
            this.dgvOption.ReadOnly = true;
            this.dgvOption.RowHeadersWidth = 51;
            this.dgvOption.RowTemplate.Height = 24;
            this.dgvOption.Size = new System.Drawing.Size(180, 350);
            this.dgvOption.TabIndex = 19;
            // 
            // panProduct
            // 
            this.panProduct.Controls.Add(this.dgvAddon);
            this.panProduct.Controls.Add(this.dgvItem);
            this.panProduct.Controls.Add(this.dgvOption);
            this.panProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panProduct.Location = new System.Drawing.Point(35, 172);
            this.panProduct.Name = "panProduct";
            this.panProduct.Size = new System.Drawing.Size(680, 350);
            this.panProduct.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "ProductView";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IS_SUKIYA.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(301, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::IS_SUKIYA.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(751, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panProduct);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.labCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmViewProduct";
            this.Text = "ViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOption)).EndInit();
            this.panProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridView dgvAddon;
        private System.Windows.Forms.DataGridView dgvOption;
        private System.Windows.Forms.Panel panProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}