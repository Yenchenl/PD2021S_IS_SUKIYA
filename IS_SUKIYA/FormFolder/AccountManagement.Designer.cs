
namespace IS_SUKIYA.FormFolder
{
    partial class frmAccountManagement
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
            this.gpbNew = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.cbxAccountLevel = new System.Windows.Forms.ComboBox();
            this.labAuthorization = new System.Windows.Forms.Label();
            this.tbxPasswordRep = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.labAccount = new System.Windows.Forms.Label();
            this.panDataGridView = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.gpbNew.SuspendLayout();
            this.panDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbNew
            // 
            this.gpbNew.Controls.Add(this.btnExit);
            this.gpbNew.Controls.Add(this.btnUpdate);
            this.gpbNew.Controls.Add(this.btnNew);
            this.gpbNew.Controls.Add(this.tbxName);
            this.gpbNew.Controls.Add(this.labName);
            this.gpbNew.Controls.Add(this.cbxAccountLevel);
            this.gpbNew.Controls.Add(this.labAuthorization);
            this.gpbNew.Controls.Add(this.tbxPasswordRep);
            this.gpbNew.Controls.Add(this.tbxPassword);
            this.gpbNew.Controls.Add(this.labPassword);
            this.gpbNew.Controls.Add(this.tbxAccount);
            this.gpbNew.Controls.Add(this.labAccount);
            this.gpbNew.Location = new System.Drawing.Point(0, 0);
            this.gpbNew.Name = "gpbNew";
            this.gpbNew.Size = new System.Drawing.Size(400, 400);
            this.gpbNew.TabIndex = 0;
            this.gpbNew.TabStop = false;
            this.gpbNew.Text = "New";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(10, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(230, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(230, 290);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 40);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(230, 240);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(150, 38);
            this.tbxName.TabIndex = 12;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(10, 240);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(90, 32);
            this.labName.TabIndex = 11;
            this.labName.Text = "Name";
            // 
            // cbxAccountLevel
            // 
            this.cbxAccountLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccountLevel.FormattingEnabled = true;
            this.cbxAccountLevel.Items.AddRange(new object[] {
            "Administrator",
            "Owner",
            "Worker",
            "Guest"});
            this.cbxAccountLevel.Location = new System.Drawing.Point(230, 190);
            this.cbxAccountLevel.Name = "cbxAccountLevel";
            this.cbxAccountLevel.Size = new System.Drawing.Size(150, 39);
            this.cbxAccountLevel.TabIndex = 10;
            // 
            // labAuthorization
            // 
            this.labAuthorization.AutoSize = true;
            this.labAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthorization.Location = new System.Drawing.Point(10, 190);
            this.labAuthorization.Name = "labAuthorization";
            this.labAuthorization.Size = new System.Drawing.Size(183, 32);
            this.labAuthorization.TabIndex = 9;
            this.labAuthorization.Text = "Authorization";
            // 
            // tbxPasswordRep
            // 
            this.tbxPasswordRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordRep.Location = new System.Drawing.Point(230, 140);
            this.tbxPasswordRep.Name = "tbxPasswordRep";
            this.tbxPasswordRep.Size = new System.Drawing.Size(150, 38);
            this.tbxPasswordRep.TabIndex = 8;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(230, 90);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(150, 38);
            this.tbxPassword.TabIndex = 6;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(10, 90);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(139, 32);
            this.labPassword.TabIndex = 5;
            this.labPassword.Text = "Password";
            // 
            // tbxAccount
            // 
            this.tbxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccount.Location = new System.Drawing.Point(230, 40);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(150, 38);
            this.tbxAccount.TabIndex = 4;
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAccount.Location = new System.Drawing.Point(10, 40);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(118, 32);
            this.labAccount.TabIndex = 2;
            this.labAccount.Text = "Account";
            // 
            // panDataGridView
            // 
            this.panDataGridView.Controls.Add(this.dgvAccount);
            this.panDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panDataGridView.Location = new System.Drawing.Point(420, 20);
            this.panDataGridView.Name = "panDataGridView";
            this.panDataGridView.Size = new System.Drawing.Size(550, 380);
            this.panDataGridView.TabIndex = 16;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(550, 380);
            this.dgvAccount.TabIndex = 0;
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IS_SUKIYA.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.panDataGridView);
            this.Controls.Add(this.gpbNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmAccountManagement";
            this.Text = "Account Management";
            this.gpbNew.ResumeLayout(false);
            this.gpbNew.PerformLayout();
            this.panDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNew;
        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxPasswordRep;
        private System.Windows.Forms.ComboBox cbxAccountLevel;
        private System.Windows.Forms.Label labAuthorization;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panDataGridView;
        private System.Windows.Forms.DataGridView dgvAccount;
    }
}