//
// Project: IS_SUKIYA(Form) - Account Management
// Date: 2021/05/30
// Author: A109222026 Kao,A109222048 Lin
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
namespace IS_SUKIYA.FormFolder
{
    public partial class frmAccountManagement : Form
    {
        //----- Global data -----//
        string accountFile;
        List<Account> accountList;

        //----- Constructor -----//
        public frmAccountManagement(string fName, List<Account> aList)
        {
            InitializeComponent();  // system define default for form
            initialSetting(fName, aList);
        }

        //----- Method -----//
        //----- Initial working environment setting

        void showDataTable(List<Account> accountList)
        {
            dgvAccount.Rows.Clear();
            foreach (var vv in accountList)
            {
                object[] row = new object[] { vv.account, vv.password, Enum.GetName(typeof(JLL_IS_Library.AccountLevel), vv.level), vv.name };
                dgvAccount.Rows.Add(row);
            }
        }// End of Method showDataTable

        void initialDataTable()
        {
            // ComboBox
            DataGridViewComboBoxColumn cbxCol = new DataGridViewComboBoxColumn();
            cbxCol.HeaderText = "Authorization";
            cbxCol.Name = "cbxAuthorization";
            cbxCol.MaxDropDownItems = 4;
            GUIsetting.setCbxContent(source: Enum.GetNames(typeof(JLL_IS_Library.AccountLevel)), target: cbxCol);

            dgvAccount.Columns.Add("strAccount", "Account");
            dgvAccount.Columns.Add("strPassword", "Password");
            dgvAccount.Columns.Add(cbxCol);
            dgvAccount.Columns.Add("strName", "Name");
            dgvAccount.Columns[0].ReadOnly = true;
            dgvAccount.Columns[1].ReadOnly = true;
            dgvAccount.Columns[3].ReadOnly = true;
            showDataTable(accountList);
        }// End of Method initialDataTable

        void initialSetting(string fName, List<Account> aList)
        {
            // assing global variables
            accountFile = fName;
            accountList = aList;
            if (aList.Count > 0)    // set GUI
            {
                GUIsetting.setCbxContent(source: Enum.GetNames(typeof(JLL_IS_Library.AccountLevel)), target: cbxAccountLevel);
                initialDataTable();
            }
            else MessageBox.Show("Empty account data, processing abort", "System Management");
        }// End of Method initialSetting

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxPasswordRep.Text)
            {
                if (CheckData.checkData(tbxPassword.Text) && CheckData.checkData(tbxAccount.Text))
                {
                    if (CheckData.checkAccount(accountList, tbxAccount.Text))
                    {
                        MessageBox.Show("Account has already existed, process abort!!");
                    }
                    else
                    {
                        Account accObj;
                        accObj = new Account(tbxAccount.Text, tbxPassword.Text, (JLL_IS_Library.AccountLevel)Enum.Parse(typeof(JLL_IS_Library.AccountLevel), cbxAccountLevel.Text), tbxName.Text);
                        accountList.Add(accObj);
                        showDataTable(accountList);
                    }
                }
                else { MessageBox.Show("Account/Password length 4~12, letter or digit or _ or - only"); }
            }
            else MessageBox.Show("Passwords must be the same!!", "Password");
        }// End of New Button

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account accObj;
            int dataCount = dgvAccount.RowCount - 1;
            accountList.Clear();
            for (int i = 0; i < dataCount; i++)
            {
                accObj = new Account(dgvAccount.Rows[i].Cells[0].Value.ToString(),
                                         dgvAccount.Rows[i].Cells[1].Value.ToString(),
                                         (JLL_IS_Library.AccountLevel)Enum.Parse(typeof(JLL_IS_Library.AccountLevel), dgvAccount.Rows[i].Cells[2].Value.ToString()),
                                         dgvAccount.Rows[i].Cells[3].Value.ToString());
                accountList.Add(accObj);
                MessageBox.Show(accObj.ToString());
            }
            ClassFolder.RWaccount.writeAccount(accountFile, accountList);
        }// End of Update Button

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }// End of Exit Button
    }
}// End of namespace
