//
// Project: IS_SUKIYA(Form) - Account Maintenance
// Date: 2021/05/30
// Author: A109222026 Kao,A109222038 Lin
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.FormFolder
{
    public partial class frmAccountMaintenance : Form
    {
        //---------- Data ----------//
        //----- Global Data -----//
        string accountFile = "Sukiya_account.csv";
        Account nowAccount;

        //---------- Action ----------//
        //----- Constructor -----//
        public frmAccountMaintenance(string fileName, Account nowAccount)
        {
            InitializeComponent();
            assignNowAccount(fileName, nowAccount);
        }

        void assignNowAccount(string fileName, Account account)
        {
            tbxAccount.Text = account.account;
            tbxName.Text = account.name;
            tbxPassword.Text = tbxPasswordRep.Text = account.password;
            tbxAuthorization.Text = account.level.ToString();
            accountFile = fileName;
            nowAccount = account;
        }// End of Method assignNowAccount

        //----- Events -----//
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxPasswordRep.Text)    // password should be the same
            {
                if (CheckData.checkData(tbxPassword.Text))  // legal password
                {
                    nowAccount.password = tbxPassword.Text;
                    nowAccount.name = tbxName.Text;
                    if (!ClassFolder.RWaccount.updateAccount(accountFile, nowAccount))
                    { MessageBox.Show("Account Update fail!!", "Account Update"); }
                }
                else { MessageBox.Show("Password length 4~12, letter or digit or _ or - only"); }
            }
            else { MessageBox.Show("Password must be the same!!", "Password"); }
        }// End of Update Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// End of Exit Button
    }
}// End of namespace
