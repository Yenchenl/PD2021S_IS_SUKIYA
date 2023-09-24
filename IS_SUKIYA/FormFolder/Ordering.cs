//
// Project: IS_SUKIYA(Form) - Ordering
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
using System.IO;
using JLL_IS_Library;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.FormFolder
{
    public partial class frmOrdering : Form
    {
        #region//---------- Global data ----------//
        //----- Environment
        const int MAX_OPTION = 3; // maximum number of option set
        private string dataDir = Directory.GetCurrentDirectory() + @"\..\..\data";
        private string saveOrderDir;

        //----- Data
        List<Category> product = null;
        List<TransactionInfo> tranInfoList = new List<TransactionInfo>();
        TransactionInfo tranInfo = null;

        //----- GUI
        int numReportSaving = 0, numDataSaving = 0; // for file name of saving
        bool needSaveFlag = false; // false denotes does not need to save
        ComboBox[] cbxOption = new ComboBox[MAX_OPTION];
        #endregion

        #region//---------- Action ----------//
        //----- Constructor -----//
        public frmOrdering(List<Category> pp) { initialSetting(null, null, pp); }
        public frmOrdering(string dataDir, Account nowAccount, List<Category> pp)
        { initialSetting(dataDir, nowAccount, pp); }

        //----- Methods -----//
        //----- Initial setting
        void initialSetting(string dataDir = null, Account nowAcc = null, List<Category> inProduct = null)
        {
            // Win. form designer
            InitializeComponent();
            // GUI
            cbxOption[0] = cbxOrderCbxOption1;
            cbxOption[1] = cbxOrderCbxOption2;
            cbxOption[2] = cbxOrderCbxOption3;
            //cbxOption[3] = cbxOption4;
            // Working environment: file location
            if (dataDir != null) { this.dataDir = dataDir; }
            saveOrderDir = this.dataDir + "\\Sukiya_transaction";
            //saveOrderDir = "Sukiya_transaction";
            // Working environment: load file
            sfdStore.InitialDirectory = saveOrderDir; //dataDir\transaction;
            // Product
            product = inProduct;
            if (product == null)
            {
                panSaveFileType.Visible = false;
                tclOrdering.Visible = false;
            }
            else { initialOrderSetting(); }
        }// End of Method initialSetting

        void initialOrderSetting(int tpg = 0)
        {
            panSaveFileType.Visible = true;
            tclOrdering.Visible = true;
            tclOrdering.SelectedIndex = tpg; // 0: Order using ComboBox, 1: Order using DGV
            GUIsetting.setCategoryInfo(product, cbxOrderCbxCategory); // order using Combo
            GUIsetting.setCategoryInfo(product, cbxOrderDGVCategory); // order using DGV
            needSaveFlag = false;
            tranInfoList = new List<TransactionInfo>();
            initialTransactionSetting();
        }// End of Method initialOrderSetting

        //-- Initial transaction record setting
        void initialTransactionSetting()
        {
            panSaveFileType.Visible = false;
            // Order using ComboxBox
            clbOrderList.Items.Clear();
            nudOrderCbxQuantity.Value = 1;
            tranInfo = null;
            tbxOrderCbxTotal.Text = "0";
            // Order using DGV
        }// End of initialTransactionSetting
        #endregion

        #region//----- Tab page change, switch to different order mode: 0 ComboBox, 1 DGV
        private void tclOrdering_SelectedIndexChanged(object sender, EventArgs e) { initialOrderSetting(tclOrdering.SelectedIndex); }
        private void tpgOrderDGV_Enter(object sender, EventArgs e) { initialOrderSetting(1); }
        private void tpgOrderCbx_Enter(object sender, EventArgs e) { initialOrderSetting(0); }
        #endregion

        #region//----- Order using ComboBox as GUI
        //-- Category selection change
        private void cbxOrderCbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear previous addon and option
            clbAddOn.Items.Clear();
            for (int i = 0; i < MAX_OPTION; i++) { cbxOption[i].Items.Clear(); }
            // set item content: don't set this, before the content of addon, option has been settle
            GUIsetting.setItemInfo(product[cbxOrderCbxCategory.SelectedIndex].item, cbxOrderCbxItem);
            // set addon content
            GUIsetting.setAddOnInfo(product[cbxOrderCbxCategory.SelectedIndex].addOnItem, clbAddOn);
            // set option
            GUIsetting.setOptionInfo(product[cbxOrderCbxCategory.SelectedIndex].option, cbxOption);
            cbxOrderCbxItem.SelectedIndex = 0;
        }// End of cbxCategory_selectedIndexChange

        //-- Category selection change
        private void cbxOrderCbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxOrderCbxUnitPrice.Text = product[cbxOrderCbxCategory.SelectedIndex].item[cbxOrderCbxItem.SelectedIndex].price.ToString(); // get item price
            nudOrderCbxQuantity.Value = 1;
        }// End of cbxItem_selectedIndexChange

        //-- Compute subtotal: when item or addon or option or quantity change
        private void computeSubTotal(object sender, EventArgs e)
        {
            // Item
            uint oneSubTotal = uint.Parse(tbxOrderCbxUnitPrice.Text);

            // Addon
            List<AddOnItem> aa = product[cbxOrderCbxCategory.SelectedIndex].addOnItem;
            if (aa != null) { foreach (int vv in clbAddOn.CheckedIndices) { oneSubTotal += aa[vv].price; } }

            // Option: make sure all option content have been set before compute it
            List<Option> oo = product[cbxOrderCbxCategory.SelectedIndex].option;
            if ((oo != null) && (cbxOption[oo.Count - 1].Items.Count > 0))
            {
                for (int i = 0; i < oo.Count; i++)
                { oneSubTotal += oo[i].option[cbxOption[i].SelectedIndex].price; }
            }// End of Option
            tbxOrderCbxSubTotal.Text = (oneSubTotal * nudOrderCbxQuantity.Value).ToString();
        }// End of Method computeSubTotal
        #endregion

        #region//----- Events -----//
        //-- Order button
        private void btnOrderCbxOrder_Click(object sender, EventArgs e)
        {
            // First transaction
            if (tranInfo == null)
            {
                tranInfo = new TransactionInfo();
                clbOrderList.Items.Clear();
            }

            // Add one transaction
            TransactionDetail td;
            List<AddOnItem> aaList = null;
            List<OptionDetail> ooList = null;
            AddOnItem aa;
            OptionDetail oo;

            int cInd = cbxOrderCbxCategory.SelectedIndex;
            if ((product[cInd].addOnItem != null) && (clbAddOn.CheckedIndices.Count > 0))
            {
                aaList = new List<AddOnItem>();
                foreach (int vv in clbAddOn.CheckedIndices)
                {
                    aa = new AddOnItem(product[cInd].addOnItem[vv].cID,
                                       product[cInd].addOnItem[vv].name,
                                       product[cInd].addOnItem[vv].price);
                    aaList.Add(aa);
                }
            }// End of addon
            if (product[cInd].option != null)
            {
                ooList = new List<OptionDetail>();
                for (int i = 0; i < product[cInd].option.Count; i++)
                {
                    oo = new OptionDetail(product[cInd].option[i].option[cbxOption[i].SelectedIndex].name,
                                          product[cInd].option[i].option[cbxOption[i].SelectedIndex].price);
                    ooList.Add(oo);
                }
            }// End of option
            td = new TransactionDetail(product[cInd].cID, product[cInd].name,
                                       product[cInd].item[cbxOrderCbxItem.SelectedIndex].name,
                                       product[cInd].item[cbxOrderCbxItem.SelectedIndex].price,
                                       (uint)nudOrderCbxQuantity.Value, aaList, ooList);
            tranInfo.item.Add(td);
            tranInfo.total += (uint)(int.Parse(tbxOrderCbxSubTotal.Text));
            tbxOrderCbxTotal.Text = tranInfo.total.ToString();

            //clbOrderList.Items.Add(td);
            string ss = td.cName + '.' + td.name;
            if (aaList != null)
            {
                ss += '(';
                foreach (var vv in aaList) { ss += vv.name + ','; }
                ss += ')';
            }
            if (ooList != null)
            {
                ss += '(';
                foreach (var vv in ooList) { ss += vv.name + ','; }
                ss += ')';
            }
            ss += " --->" + td.subTotal;
            clbOrderList.Items.Add(ss);
            //showTransactionDetail(td, aaList, ooList);
        }//End of order button

        string showTransactionDetail(TransactionDetail td, List<AddOnItem> aaList = null, List<OptionDetail> ooList = null)
        {
            string ss = td.cName + '.' + td.name;
            if (aaList != null)
            {
                ss += '(';
                foreach (var vv in aaList) { ss += vv.name + ','; }
                ss += ')';
            }
            if (ooList != null)
            {
                ss += '(';
                foreach (var vv in ooList) { ss += vv.name + ','; }
                ss += ')';
            }
            ss += " --->" + td.subTotal;
            return ss;
        }

        //-- Delete button
        private void btnOrderCbxDelete_Click(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = clbOrderList.CheckedIndices.Count - 1; i >= 0; i--)
            {
                ind = clbOrderList.CheckedIndices[i];
                tranInfo.total -= (tranInfo.item[ind].subTotal);
                //tranInfo.total -= (tranInfo.item[ind].price) * (tranInfo.item[ind].quantity);
                tranInfo.item.RemoveAt(ind);
            }
            if (tranInfo.item.Count < 1) { initialTransactionSetting(); }
            else
            {
                clbOrderList.Items.Clear();
                foreach (var vv in tranInfo.item) { clbOrderList.Items.Add(showTransactionDetail(vv, vv.addOn, vv.option)); }
                //showTransactionDetail(tranInfo, aaList, ooList);
                tbxOrderCbxTotal.Text = tranInfo.total.ToString();
            }
        }// End of delete button

        //-- Clear all button
        private void btnOrderCbxClearAll_Click(object sender, EventArgs e)
        {
            initialTransactionSetting();
            //if (tranInfo != null)
            //{
            //    tranInfo.id = DateTimeProcessing.dateTimeToNumberString(DateTime.Now);
            //    tranInfoList.Add(tranInfo);
            //    MessageBox.Show("" + tranInfo);
            //    tranInfo = null;
            //    initialTransactionSetting();
            //}
            //if (tranInfoList.Count > 0)
            //{
            //    panSaveFileType.Visible = true;
            //    needSaveFlag = true;
            //}
            //else { panSaveFileType.Visible = false; }
        }// End of check out button

        //-- Check out button
        private void btnOrderCbxCheckOut_Click(object sender, EventArgs e)
        {
            if (tranInfo != null)
            {
                tranInfo.id = DateTimeProcessing.dateTimeToNumberString(DateTime.Now);
                tranInfoList.Add(tranInfo);
                MessageBox.Show("Info" + tranInfo);
                tranInfo = null;
                initialTransactionSetting();
            }
            if (tranInfoList.Count > 0)
            {
                panSaveFileType.Visible = true;
                needSaveFlag = true;
            }
            else { panSaveFileType.Visible = false; }
        }// End of check out button

        //-- Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tranInfoList != null) && (tranInfoList.Count > 0))
            {
                string fileName = "Transaction" + DateTimeProcessing.dateToNumberString(DateTime.Now).Replace("/", "_");
                string ss = "";
                foreach (TransactionInfo tt in tranInfoList) { ss += ("\n" + tt + "\n"); }
                //MessageBox.Show(ss);
                if (cbnReport.Checked)
                {
                    fileName += JLL_IS_Library.FileInfo.REPORT_FILE_EXTENSION + (++numReportSaving);
                    sfdStore.FileName = fileName;
                    fileName = "Transaction" + DateTimeProcessing.dateToNumberString(DateTime.Now).Replace("/", "_");
                    //sfdStore.FileName = ss;
                    if (sfdStore.ShowDialog() == DialogResult.OK)
                    { ClassFolder.RWtransaction.saveReport(sfdStore.FileName, tranInfoList); }
                }
                if (cbnData.Checked)
                {
                    fileName += (/*"_" + (++numDataSaving) + */JLL_IS_Library.FileInfo.OBJECT_FILE_EXTENSION);
                    sfdStore.FileName = fileName;
                    //sfdStore.FileName = ss;
                    if (sfdStore.ShowDialog() == DialogResult.OK)
                    { needSaveFlag = !RWdata<TransactionInfo>.writeBinaryObject(sfdStore.FileName, tranInfoList); }
                }
            }
        }// End of save button

        //-- Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((tranInfoList != null) && (tranInfoList.Count > 0) && (needSaveFlag))
            {
                string fileName = /*sInfo.name + */ "Transaction" + DateTimeProcessing.dateToNumberString(DateTime.Now).Replace("/", "_");
                fileName += ("_" + (++numDataSaving) + JLL_IS_Library.FileInfo.OBJECT_FILE_EXTENSION);
                sfdStore.FileName = fileName;
                if (sfdStore.ShowDialog() == DialogResult.OK)
                { RWdata<TransactionInfo>.writeBinaryObject(sfdStore.FileName, tranInfoList); }
            }
            this.Close();
        }// End of exit button
        #endregion
    }
}// End of namespace
