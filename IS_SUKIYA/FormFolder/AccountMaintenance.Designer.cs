
namespace IS_SUKIYA.FormFolder
{
    partial class frmAccountMaintenance
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
            this.labAccount = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.labAuthorization = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.tbxPasswordRep = new System.Windows.Forms.TextBox();
            this.tbxAuthorization = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAccount.Location = new System.Drawing.Point(88, 110);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(118, 32);
            this.labAccount.TabIndex = 1;
            this.labAccount.Text = "Account";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(78, 165);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(139, 32);
            this.labPassword.TabIndex = 2;
            this.labPassword.Text = "Password";
            // 
            // tbxAccount
            // 
            this.tbxAccount.BackColor = System.Drawing.Color.Cornsilk;
            this.tbxAccount.Enabled = false;
            this.tbxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccount.Location = new System.Drawing.Point(310, 107);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.ReadOnly = true;
            this.tbxAccount.Size = new System.Drawing.Size(150, 38);
            this.tbxAccount.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(310, 165);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(150, 38);
            this.tbxPassword.TabIndex = 4;
            // 
            // labAuthorization
            // 
            this.labAuthorization.AutoSize = true;
            this.labAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthorization.Location = new System.Drawing.Point(62, 224);
            this.labAuthorization.Name = "labAuthorization";
            this.labAuthorization.Size = new System.Drawing.Size(183, 32);
            this.labAuthorization.TabIndex = 5;
            this.labAuthorization.Text = "Authorization";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(98, 281);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(90, 32);
            this.labName.TabIndex = 6;
            this.labName.Text = "Name";
            // 
            // tbxPasswordRep
            // 
            this.tbxPasswordRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordRep.Location = new System.Drawing.Point(492, 165);
            this.tbxPasswordRep.Name = "tbxPasswordRep";
            this.tbxPasswordRep.Size = new System.Drawing.Size(150, 38);
            this.tbxPasswordRep.TabIndex = 7;
            // 
            // tbxAuthorization
            // 
            this.tbxAuthorization.BackColor = System.Drawing.Color.Cornsilk;
            this.tbxAuthorization.Enabled = false;
            this.tbxAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAuthorization.Location = new System.Drawing.Point(310, 224);
            this.tbxAuthorization.Name = "tbxAuthorization";
            this.tbxAuthorization.ReadOnly = true;
            this.tbxAuthorization.Size = new System.Drawing.Size(150, 38);
            this.tbxAuthorization.TabIndex = 8;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(310, 281);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(150, 38);
            this.tbxName.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(520, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(520, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAccountMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxAuthorization);
            this.Controls.Add(this.tbxPasswordRep);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labAuthorization);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxAccount);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmAccountMaintenance";
            this.Text = "Account Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label labAuthorization;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox tbxPasswordRep;
        private System.Windows.Forms.TextBox tbxAuthorization;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}