//
// Project: IS_SUKIYA(Form) - Main Entrance
// Date: 2021/05/30
// Author: A109222026 Kao,A109222048 Lin,A109222038 Lin
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
using IS_Library;
using JLL_IS_Library;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA
{
    public partial class frmMainEntrance : Form
    {
        //---------- Global data ----------//
        private string dataDir = @"\..\..\Data";
        private string saveOrderDir, saveAccountDir;
        Account nowAccount;
        List<Account> accountList;
        List<Account> accounts = new List<Account>();
        List<Category> product = null;

        string accountFile = "../../Data/Sukiya_account.csv";
        string productFile = "../../Data/Sukiya_product.csv";
        public frmMainEntrance()
        {
            InitializeComponent();
            initialSetting();
            logoutSetting();
        }

        void initialSetting()
        {
            // read account information
            //accountFile = @"\Sukiya_account.csv";
            accountList = null;

            //get product information
            //productFile = @"\Sukiya_product.csv";
            product = null;
            if (!ClassFolder.RWproduct.readProduct(productFile, out product))
            { MessageBox.Show("No Product, can't view / order product!!"); }
            else { foreach (Category cc in product) { MessageBox.Show("Category....\n" + cc); } }

            // get account information
            //Account aa = new Account("test1", "test1", AccountLevel.Administrator, "test1");
            //accounts.Add(aa);
            //aa = new Account("test2", "test2", AccountLevel.Owner, "test2");
            //accounts.Add(aa);
            //aa = new Account("test3", "test3", AccountLevel.Worker, "test3");
            //accounts.Add(aa);

            // button setting
            btnAccountMaintrance.Enabled = false;
            btnAccountManagement.Enabled = false;
            btnOrdering.Enabled = false;
            btnSaleRecord.Enabled = false;
            btnStoreManagement.Enabled = false;
        }// End of Method initial setting

        //----- Login setting
        void loginSetting()
        {
            if (nowAccount.level == JLL_IS_Library.AccountLevel.Administrator)
            {
                btnAccountMaintrance.Enabled = true;
                btnAccountManagement.Enabled = true;
                btnOrdering.Enabled = true;
                btnSaleRecord.Enabled = true;
                btnStoreManagement.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (nowAccount.level == JLL_IS_Library.AccountLevel.Owner)
            {
                btnAccountMaintrance.Enabled = true;
                btnOrdering.Enabled = true;
                btnSaleRecord.Enabled = true;
                btnStoreManagement.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (nowAccount.level == JLL_IS_Library.AccountLevel.Worker)
            {
                btnAccountMaintrance.Enabled = true;
                btnOrdering.Enabled = true;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
            }
            else
            {
                Form ff = new FormFolder.frmViewProduct(product);
                ff.Show();
            } // AccountLevel.Guest

            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            tbxAccount.Enabled = false;
            tbxPassword.Enabled = false;
        }// End of Method Login setting

        //----- Logout setting
        void logoutSetting()
        {
            // button setting
            btnExit.Enabled = true;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnAccountMaintrance.Enabled = false;
            btnAccountManagement.Enabled = false;
            btnOrdering.Enabled = false;
            btnSaleRecord.Enabled = false;
            btnStoreManagement.Enabled = false;
            tbxAccount.Enabled = true;
            tbxPassword.Enabled = true;

            // account setting
            nowAccount = null;
            accountList = null;
            tbxAccount.Text = "";
            tbxPassword.Text = "";

            //pictureBox Setting
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }// End of Method logout setting

        //----- Events -----//
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (accountList == null)
            {
                accountList = new List<Account>();
                ClassFolder.RWaccount.readAccount(accountFile, out accountList);
            }
            if ((tbxAccount.Text.Length > 0) || (tbxPassword.Text.Length > 0))
            {
                if (CheckData.checkAccount(accountList, tbxAccount.Text, tbxPassword.Text, out nowAccount))
                { loginSetting(); }
                else {
                    MessageBox.Show("Account or password does not exist!!,Type your account and password!!\nView Product Only");
                    Form ff = new FormFolder.frmViewProduct(product);
                    ff.Show();
                }
            }
            else
            {
                MessageBox.Show("Type your account and password!!\nView Product Only");
                Form ff = new FormFolder.frmViewProduct(product);
                ff.Show();
            }
        }// End of Login Button

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logoutSetting();
        }// End of Logout Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }// End of Exit Button

        private void btnAccountMaintrance_Click(object sender, EventArgs e)
        {
            Form ff = new FormFolder.frmAccountMaintenance(accountFile, nowAccount);
            ff.ShowDialog(); //.Show --> the parent form still can activate
            ClassFolder.RWaccount.readAccount(accountFile, out accountList);
        }// End of AccountMaintrance Button

        private void btnAccountManagement_Click(object sender, EventArgs e)
        {
            Form ff = new FormFolder.frmAccountManagement(accountFile, accountList);
            ff.ShowDialog();
            ClassFolder.RWaccount.readAccount(accountFile, out accountList);
        }// End of AccountManagement Button

        private void btnSaleRecord_Click(object sender, EventArgs e)
        {
            Form ff = new FormFolder.frmSaleRecord();
            ff.ShowDialog();
        }// End of SaleRecord Button

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            Form ff = new FormFolder.frmStoreManagement(productFile, product);
            ff.ShowDialog();
            if (ClassFolder.RWproduct.readProduct(productFile, out product)) { btnOrdering.Enabled = true; }
            else
            {
                MessageBox.Show("No Product, cannot view/order product!!", "Read Product");
                product = null;
                btnOrdering.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            Form ff = new FormFolder.frmOrdering(product);
            ff.ShowDialog();
        }// End of Ordering Button
    }
}// End of namespace
