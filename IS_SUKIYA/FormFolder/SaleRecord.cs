//
// Project: IS_SUKIYA(Form) - Sale Record Query/Analysis
// Date: 2021/05/30
// Author: A109222026 Kao,A109222038 Lin,A109222048 Lin
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
using System.IO;
using JLL_IS_Library;
using ZedGraph;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.FormFolder
{
    //----Enum Data Type----//


    //---Choose  transaction file
   
    public partial class frmSaleRecord : Form
    {
        #region//---------- Global data ----------//
        private string transactionDir = Directory.GetCurrentDirectory() + @"\..\..\data\Transaction";
        private List<TransactionInfo> tranInfoList = new List<TransactionInfo>();
        private TransactionInfo tranInfo = null;
        #endregion

        #region//---------- Actions ----------//
        #region//----- Constructors -----//
        public frmSaleRecord()
        {
            InitializeComponent();
            initialSetting();
        }
        public frmSaleRecord(string dirName)
        {
            InitializeComponent();
            initialSetting(dirName);
        }// End of frmSaleRecord constructor
        #endregion

        #region//----- Methods -----//
        void initialSetting(string fileDir = null)
        { // under sub-directory Transaction in Data irectory
            if (fileDir != null) { transactionDir = fileDir; } // get directory of transaction files
            string[] files = Directory.GetFiles(transactionDir, "Transaction*.bin"); // get transaction file path under Dir
            for (int i = 0; i < files.Length; i++) { files[i] = Path.GetFileName(files[i]); } // get files
            JLL_IS_Library.GUIprocessing.setCbxContent(files, cbxFileList); // file to ComboBox
            if (cbxFileList.Items.Count > 0) { cbxFileList.SelectedIndex = 0; }
        }// End of Method initialSetting
        #endregion

        #region//----- Events -----//
        //----- Transaction query
        private void tpgQuery_Enter(object sender, EventArgs e) { initialSetting(transactionDir); }
        //-- Choose transaction file
        private void cbxFileList_SelectedIndexChanged(object sender, EventArgs e) // transaction files change
        {
            if (RWdata<TransactionInfo>.readBinaryObject(
                transactionDir + "\\" + (string)cbxFileList.Items[cbxFileList.SelectedIndex], out tranInfoList))
            { GUIsetting.setTransactionInfo(tranInfoList, dgvTransaction); }
            else { MessageBox.Show(transactionDir + "\\" + (string)cbxFileList.Items[cbxFileList.SelectedIndex], "Read TransactionInf Bin Fail"); }
        }// End of cbxFile_SelectedIndexChanged
        //-- Choose transaction in a transaction file (transactions in one login iteration saved in one file)
        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e) // DGV change
        {
            if ((dgvTransaction.DataSource != null) && (dgvTransaction.RowCount > 0))
            { GUIsetting.setTransactionInfo(tranInfoList.ElementAt<TransactionInfo>(dgvTransaction.CurrentCell.RowIndex), dgvTransactionDetail); }
        }// End of dgvTransaction_CellContentClick
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #endregion

        private void displaychart(object sender, EventArgs e)
        {
           
        }

        //---
    }// End of Class
}// End of namespace
