//
// Project: IS_SUKIYA(Form) - Store Management
// Date: 2021/06/01
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

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.FormFolder
{
    public partial class frmStoreManagement : Form
    {
        #region//---------- Global data ----------//
        //----- Environment
        const int MAX_OPTION = 3; // maximum number of option set
        //----- Data
        string productFile = Directory.GetCurrentDirectory() + @"\..\..\Data\product.csv";
        List<Category> productList = null;
        //----- GUI
        int oIndex = -1; // default is no option set
        ListBox[] lbxOption = new ListBox[MAX_OPTION];
        #endregion

        #region//---------- Actions ----------//
        #region//----- Constructors -----//
        public frmStoreManagement(string fName)
        {
            InitializeComponent();
            initialSetting(fName);
        }
        public frmStoreManagement(string fName, List<Category> pp)
        {
            InitializeComponent();
            initialSetting(fName, pp);
        }
        #endregion

        #region//----- Methods -----//
        //----- Initial working environment setting
        void initialSetting(string fName = null, List<Category> pList = null)
        {
            // GUI
            lbxOption[0] = lbxCbxOption1;
            lbxOption[1] = lbxCbxOption2;
            lbxOption[2] = lbxCbxOption3;
            //lbxOption[3] = lbxCbxOption4;

            // assing global variables
            if (fName != null) { productFile = fName; }
            if (pList != null) { productList = pList; }

            // get product info.
            if ((pList != null) && (pList.Count > 0)) { initialProductSetting(); }
            else
            {
                if (ClassFolder.RWproduct.readProduct(productFile, out productList)) { initialProductSetting(); }
                else
                {
                    MessageBox.Show("Empty product data, create a new one!!", "Product Management");
                    productList = new List<Category>();
                }
            }
        }// End of initialSetting

        //----- Initial product management environment setting after reading product sucessfully
        void initialProductSetting(int tpg = 0)
        {
            //foreach (var vv in product) { MessageBox.Show("Category...\n" + vv); }
            tclStoreManagement.Visible = true;
            tclStoreManagement.SelectedIndex = 0; // 0: Order using ComboBox, 1: Order using DGV
            cbxCbxCategory.Visible = true;
            btnCbxCategoryDelete.Visible = true;
            btnCbxCategoryUpdate.Visible = true;
            btnSave.Visible = true;
            GUIsetting.setCategoryInfo(productList, cbxCbxCategory);
        }// End of initialProductSetting

        //----- Empty product
        void emptyProductSetting()
        {
            tclStoreManagement.Visible = false;
            //tclStoreManagement.SelectedIndex = 0; // 0: Order using ComboBox, 1: Order using DGV
            cbxCbxCategory.Visible = false;
            btnCbxCategoryDelete.Visible = false;
            btnCbxCategoryUpdate.Visible = false;
        }// End of emptyProductSetting

        //----- Encode/Decode List<OptionDetail> string
        string encodeOptionSet(List<OptionDetail> oo)
        {
            string ss = "";
            foreach (var vv in oo) { ss += vv.name + ':' + vv.price + ':'; }
            ss = ss.Substring(0, ss.Length - 1);
            return ss;
        }// End of encodeOptionSet

        List<OptionDetail> decodeOptionSet(string ss)
        {
            List<OptionDetail> odList = new List<OptionDetail>(); // insert
            OptionDetail od;
            string[] cells = ss.Trim().Split(':');
            uint temp;
            for (int i = 0; (i + 1) < cells.Length; i += 2) // one option is the pair of (name, price)
            {
                od = new OptionDetail();
                if ((cells[i].Trim().Length > 0) & (uint.TryParse(cells[i + 1].Trim(), out temp)))
                {
                    od.price = temp;
                    od.name = cells[i].Trim();
                    odList.Add(od);
                }
            }
            if (odList.Count > 0) { return odList; }
            else { return null; }

        }// End of decodeOptionSet
        #endregion

        #region//----- Events -----//
        #region//----- Common
        private void btnSave_Click(object sender, EventArgs e) { ClassFolder.RWproduct.saveProduct(productFile, productList); }
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        #endregion

        #region//----- Category: select, insert, update, delete
        private void cbxCbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear previous addon and option
            lbxCbxAddOn.Items.Clear();
            for (int i = 0; i < MAX_OPTION; i++) { lbxOption[i].Items.Clear(); }
            // set category name
            tbxCbxCategory.Text = productList[cbxCbxCategory.SelectedIndex].name;
            // set item content: don't set this, before the content of addon, option has been settle
            //foreach (var vv in product[cbxCbxCategory.SelectedIndex].item) { cbxItem.Item.Add('$' + vv.price + ' ' + vv.name); }
            if (GUIsetting.setItemInfo(productList[cbxCbxCategory.SelectedIndex].item, lbxCbxItem))
            { btnCbxItemUpdate.Enabled = btnCbxItemDelete.Enabled = true; }
            else { btnCbxItemUpdate.Enabled = btnCbxItemDelete.Enabled = false; tbxCbxItem.Text = ""; nudCbxItem.Value = 0; }
            // set addon content
            if (GUIsetting.setAddOnInfo(productList[cbxCbxCategory.SelectedIndex].addOnItem, lbxCbxAddOn))
            { btnCbxAddOnUpdate.Enabled = btnCbxAddOnDelete.Enabled = true; }
            else { btnCbxAddOnUpdate.Enabled = btnCbxAddOnDelete.Enabled = false; tbxCbxAddOn.Text = ""; nudCbxAddOn.Value = 0; }
            // set option
            if (GUIsetting.setOptionInfo(productList[cbxCbxCategory.SelectedIndex].option, lbxOption))
            {
                btnCbxOptionUpdate.Enabled = btnCbxOptionDelete.Enabled = true;
                if (productList[cbxCbxCategory.SelectedIndex].option.Count >= MAX_OPTION) { btnCbxOptionInsert.Enabled = false; }
            }
            else { btnCbxOptionUpdate.Enabled = btnCbxOptionDelete.Enabled = false; btnCbxOptionInsert.Enabled = true; tbxCbxOption.Text = ""; }
        }// End of cbxCbxCategory_SelectedIndexChanged
        private void btnCbxCategoryInsert_Click(object sender, EventArgs e)
        {
            if (productList == null) { productList = new List<Category>(); }
            if (tbxCbxCategory.Text.Trim().Length > 0) // check empty string for name
            {
                if (!CheckData.CheckExist(productList, tbxCbxCategory.Text.Trim()))
                {
                    Category cc = new Category((uint)(productList.Count + 1), tbxCbxCategory.Text.Trim());
                    productList.Add(cc);
                    if (productList.Count == 1) { initialProductSetting(); }
                    else { GUIsetting.setCategoryInfo(productList, cbxCbxCategory); }
                    cbxCbxCategory.SelectedIndex = cbxCbxCategory.Items.Count - 1;
                }
                else { MessageBox.Show("Category: " + tbxCbxCategory.Text + " has already exist!!"); }
            }// End of no null category name
            else { MessageBox.Show("Category name can not be null or empty!!", "Insert Category"); }
        }// End of btnCbxCategoryInsert
        private void btnCbxCategoryUpdate_Click(object sender, EventArgs e)
        {
            //if (productList == null) { productList = new List<Category>(); }
            if (tbxCbxCategory.Text.Trim().Length > 0) // check empty string for name
            {
                if (!CheckData.CheckExist(productList, tbxCbxCategory.Text.Trim()))
                {
                    int nowC = cbxCbxCategory.SelectedIndex;
                    productList[nowC].name = tbxCbxCategory.Text.Trim();
                    GUIsetting.setCategoryInfo(productList, cbxCbxCategory);
                    cbxCbxCategory.SelectedIndex = nowC;
                }
                else { MessageBox.Show("Category: " + tbxCbxCategory.Text + " has already exist!!", "Category Exist"); }
            }// End of no null category name
            else { MessageBox.Show("Category name can not be null or empty!!", "Update Category"); }
        }// End of btnCbxCategoryUpdate
        private void btnCbxCategoryDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete category \"" + tbxCbxCategory.Text.Trim() + "\"", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productList.RemoveAt(cbxCbxCategory.SelectedIndex);
                if (productList.Count > 0) { GUIsetting.setCategoryInfo(productList, cbxCbxCategory); }
                else { emptyProductSetting(); }
            }
        }// End of btnCbxCategoryDelete
        #endregion

        #region//----- Item: select, insert, update, delete
        private void lbxCbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCbxItem.Text = productList[cbxCbxCategory.SelectedIndex].item[lbxCbxItem.SelectedIndex].name;
            nudCbxItem.Value = productList[cbxCbxCategory.SelectedIndex].item[lbxCbxItem.SelectedIndex].price;
        }// End of lbxCbxItem_SelectedIndexChanged
        private void btnCbxItemInsert_Click(object sender, EventArgs e)
        {
            string name = tbxCbxItem.Text.Trim();
            int cInd = cbxCbxCategory.SelectedIndex;
            if (name.Length > 0)
            {
                if (!CheckData.CheckExist(productList[cInd].item, name)) // check item name exist
                {
                    // the new one is the first one even don't allow empty Item, it still have chance this is null because delete
                    if (productList[cInd].item == null) { productList[cInd].item = new List<Item>(); }
                    // insert a new item
                    Item ii = new Item(productList[cInd].cID, name, (uint)nudCbxItem.Value);
                    productList[cInd].item.Add(ii);
                    // redisplay
                    GUIsetting.setItemInfo(productList[cInd].item, lbxCbxItem);
                    lbxCbxItem.SelectedIndex = lbxCbxItem.Items.Count - 1;
                    // enable button
                    btnCbxItemUpdate.Enabled = btnCbxItemDelete.Enabled = true;
                }
                else { MessageBox.Show("Item: " + tbxCbxItem.Text + " has already exist!!", "Item Exist"); }
            }// End of no null item name
            else { MessageBox.Show("Item name can not be null or empty!!", "Item Insert"); }
        }// End of btnCbxItemInsert
        private void btnCbxItemUpdate_Click(object sender, EventArgs e)
        {
            productList[cbxCbxCategory.SelectedIndex].item[lbxCbxItem.SelectedIndex].name = tbxCbxItem.Text;
            productList[cbxCbxCategory.SelectedIndex].item[lbxCbxItem.SelectedIndex].price = (uint)nudCbxItem.Value;
            GUIsetting.setItemInfo(productList[cbxCbxCategory.SelectedIndex].item, lbxCbxItem);
        }// End of btnCbxItemUpdate
        private void btnCbxItemDelete_Click(object sender, EventArgs e)
        {
            productList[cbxCbxCategory.SelectedIndex].item.RemoveAt(lbxCbxItem.SelectedIndex);
            if (!GUIsetting.setItemInfo(productList[cbxCbxCategory.SelectedIndex].item, lbxCbxItem)) // no item
            { btnCbxItemUpdate.Enabled = btnCbxItemDelete.Enabled = false; tbxCbxItem.Text = ""; nudCbxItem.Value = 0; }
        }// End of btnCbxItemDelete
        #endregion

        #region//----- Addon: select, insert, update, delete
        private void lbxCbxAddOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCbxAddOn.Text = productList[cbxCbxCategory.SelectedIndex].addOnItem[lbxCbxAddOn.SelectedIndex].name;
            nudCbxAddOn.Value = productList[cbxCbxCategory.SelectedIndex].addOnItem[lbxCbxAddOn.SelectedIndex].price;
        }// End of lbxCbxAddOn_SelectedIndexChanged
        private void btnCbxAddOnInsert_Click(object sender, EventArgs e)
        {
            string name = tbxCbxAddOn.Text.Trim();
            int cInd = cbxCbxCategory.SelectedIndex;
            if (name.Length > 0)
            {
                if (!CheckData.CheckExist(productList[cInd].addOnItem, name))
                {
                    // add on may be is null in the beginning
                    if (productList[cInd].addOnItem == null) { productList[cInd].addOnItem = new List<AddOnItem>(); }
                    // insert a new addon item
                    AddOnItem aa = new AddOnItem(productList[cInd].cID, name, (uint)nudCbxAddOn.Value);
                    productList[cbxCbxCategory.SelectedIndex].addOnItem.Add(aa);
                    // redisplay
                    GUIsetting.setAddOnInfo(productList[cbxCbxCategory.SelectedIndex].addOnItem, lbxCbxAddOn);
                    lbxCbxAddOn.SelectedIndex = lbxCbxAddOn.Items.Count - 1;
                    // enable button
                    btnCbxAddOnUpdate.Enabled = btnCbxCategoryDelete.Enabled = true;
                }
                else { MessageBox.Show("Addon item: " + tbxCbxAddOn.Text + " has already exist!!", "Addon Item Exist"); }
            }// End of no null item name
            else { MessageBox.Show("Addon item name can not be null or empty!!", "Addon Item Insert"); }
        }// End of btnCbxAddOnInsert
        private void btnCbxAddOnUpdate_Click(object sender, EventArgs e)
        {
            productList[cbxCbxCategory.SelectedIndex].addOnItem[lbxCbxAddOn.SelectedIndex].name = tbxCbxAddOn.Text;
            productList[cbxCbxCategory.SelectedIndex].addOnItem[lbxCbxAddOn.SelectedIndex].price = (uint)nudCbxAddOn.Value;
            GUIsetting.setAddOnInfo(productList[cbxCbxCategory.SelectedIndex].addOnItem, lbxCbxAddOn);
        }// End of btnCbxAddOnUpdate
        private void btnCbxAddOnDelete_Click(object sender, EventArgs e)
        {
            productList[cbxCbxCategory.SelectedIndex].addOnItem.RemoveAt(lbxCbxAddOn.SelectedIndex);
            if (!GUIsetting.setAddOnInfo(productList[cbxCbxCategory.SelectedIndex].addOnItem,lbxCbxAddOn))
            { btnCbxAddOnUpdate.Enabled = btnCbxAddOnDelete.Enabled = false; tbxCbxAddOn.Text = ""; nudCbxAddOn.Value = 0; }
        }// End of btnCbxAddOnDelete
        #endregion

        #region//----- Option: select, insert, update, delete
        private void lbxOption_MouseClick(object sender, MouseEventArgs e)
        {
            // assume MAX_OPTION is 4
            //int oIndex = 0; // global variable
            if (((ListBox)sender).Name == lbxCbxOption1.Name) { tbxCbxOption.Text = "Option1"; oIndex = 0; }
            else if (((ListBox)sender).Name == lbxCbxOption2.Name) { tbxCbxOption.Text = "Option2"; oIndex = 1; }
            else if (((ListBox)sender).Name == lbxCbxOption3.Name) { tbxCbxOption.Text = "Option3"; oIndex = 2; }
            //else if (((ListBox)sender).Name == lbxCbxOption4.Name) { tbxCbxOption.Text = "Option4"; oIndex = 3; }
            else { oIndex = -1; }
            if (oIndex >= 0)
            { tbxCbxOption.Text = encodeOptionSet(productList[cbxCbxCategory.SelectedIndex].option[oIndex].option); }
            else { tbxCbxOption.Text = ""; }
        }// End of lbxOption_MouseClick
        private void btnCbxOptionInsert_Click(object sender, EventArgs e)
        {
            List<OptionDetail> odList = decodeOptionSet(tbxCbxOption.Text.Trim());
            Option oo;
            if (odList != null)
            {
                oo = new Option(productList[cbxCbxCategory.SelectedIndex].cID, odList);
                if (productList[cbxCbxCategory.SelectedIndex].option == null)
                { productList[cbxCbxCategory.SelectedIndex].option = new List<Option>(); }
                productList[cbxCbxCategory.SelectedIndex].option.Add(oo);
                if (GUIsetting.setOptionInfo(productList[cbxCbxCategory.SelectedIndex].option, lbxOption))
                {
                    btnCbxOptionUpdate.Enabled = btnCbxOptionDelete.Enabled = true;
                    oIndex = productList[cbxCbxCategory.SelectedIndex].option.Count - 1;
                    if (productList[cbxCbxCategory.SelectedIndex].option.Count >= MAX_OPTION)
                    { btnCbxOptionInsert.Enabled = false; }
                }
                else { btnCbxOptionUpdate.Enabled = btnCbxOptionDelete.Enabled = false; }
            }
            
        }// End of btnCbxOptionInsert
        private void btnCbxOptionUpdate_Click(object sender, EventArgs e)
        {
            List<OptionDetail> odList = decodeOptionSet(tbxCbxOption.Text.Trim());
            if (odList != null)
            {
                MessageBox.Show("Option list\n" + odList + "\n oIndex= --> " + oIndex);
                productList[cbxCbxCategory.SelectedIndex].option[oIndex].option = odList;
                GUIsetting.setOptionInfo(productList[cbxCbxCategory.SelectedIndex].option, lbxOption);
            }
        }// End of btnCbxOptionUpdate
        private void btnCbxOptionDelete_Click(object sender, EventArgs e)
        {
            if (oIndex == -1)
            { oIndex = 0; }
            productList[cbxCbxCategory.SelectedIndex].option.RemoveAt(oIndex);
            btnCbxOptionInsert.Enabled = true;
            if (GUIsetting.setOptionInfo(productList[cbxCbxCategory.SelectedIndex].option, lbxOption))
            {
                oIndex = 0;
                encodeOptionSet(productList[cbxCbxCategory.SelectedIndex].option[oIndex].option);
            }
            else
            { btnCbxOptionUpdate.Enabled = btnCbxOptionDelete.Enabled = false; tbxCbxOption.Text = ""; oIndex = -1; }
        }// End of btnCbxOptionDelete
        #endregion
        #endregion
        #endregion
    }
}// End of namespace
