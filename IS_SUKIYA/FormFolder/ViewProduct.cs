//
// Project: IS_SUKIYA(Form) - View Product
// Date: 2021/05/18
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
    public partial class frmViewProduct : Form
    {
        #region//---------- Global data ----------//
        List<Category> product = new List<Category>(); // drop down menu to choose a category
        DataTable dtItem = new DataTable(); // data table to store items under the
        DataTable dtAddon = new DataTable();
        DataTable dtOption = new DataTable();
        // End of Global data
        #endregion

        #region//---------- Actions ----------//
        //----- Constructor -----//
        public frmViewProduct(List<Category> pp)
        {
            InitializeComponent();
            product = pp;
            initialSetting();
        }// End of frmViewProduct() Constructor

        //----- Methods -----//
        //----- Initial setting: binding product information to DataTable for DataGridView.DataSource
        void initialSetting()
        {
            //-- Set view table format
            // data table as the data source of data grid view
            dtItem.Columns.Add("Item", typeof(string));
            dtItem.Columns.Add("Price", typeof(uint));
            dtAddon.Columns.Add("Addon", typeof(string));
            dtAddon.Columns.Add("Price", typeof(uint));

            // columns of options depends on the category, so need to be set whenever the category change
            dgvItem.DataSource = dtItem; // binding datatable to data grid view
            dgvAddon.DataSource = dtAddon;
            dgvOption.DataSource = dtOption; // if using datagridview to add information, need to mark out this list
            GUIsetting.setCategoryInfo(product, cbxCategory); // will call setProductInfo automatically
        }// End of Method initialSetting

        //----- Set product information
        void setProductInfo(Category cc)
        {
            // Find the maximum option items for all possible option set
            int numCol = 0, maxOptionItem = 0;
            string[] ooArr;

            //-- Set on data table
            // Setting data on binded data table of datagridview
            dtItem.Clear();
            dtAddon.Clear();
            dtOption.Clear();
            dtOption.Columns.Clear(); // one column denotes one kind of option
            foreach (Item ii in cc.item) { dtItem.Rows.Add(new object[] { ii.name, ii.price }); }

            // Setting addon datga on binded data table of datagridview
            if (cc.addOnItem != null)
            {
                foreach (AddOnItem aa in cc.addOnItem)
                { dtAddon.Rows.Add(new object[] { aa.name, aa.price }); }
            }

            // Setting option data on binded data table of datagridview
            if (cc.option != null)
            {
                if (cc.option.Count > 0)
                {
                    maxOptionItem = cc.option.ElementAt<Option>(0).option.Count;
                    for (int i = 1; i < cc.option.Count; i++)
                    {
                        if (cc.option.ElementAt<Option>(i).option.Count > maxOptionItem)
                        { maxOptionItem = cc.option.ElementAt<Option>(i).option.Count; }
                    }
                }// End of cc.option != null for finding maximum option details for all possible
                numCol = cc.option.Count; // one column denotes one kind of option, row is the optionDetail of each option

                if (cc.option.Count > 0)
                {
                    for (int i = 0; i < numCol; i++) { dtOption.Columns.Add("Option"/* + (i + 1), typeof(string)*/); }
                    for (int i = 0; i < maxOptionItem; i++) // set row for one column denotes one kind of option
                    {
                        ooArr = new string[numCol];
                        for (int j = 0; j < cc.option.Count; j++)
                        {
                            if (i < cc.option.ElementAt<Option>(j).option.Count)
                            { ooArr[j] = cc.option.ElementAt<Option>(j).option.ElementAt<OptionDetail>(i).name + '$' +
                                         cc.option.ElementAt<Option>(j).option.ElementAt<OptionDetail>(i).price; }
                        }
                        dtOption.Rows.Add(ooArr);
                    }
                }// End of set option data table
            }// End of setting option data table
        }// End of Method setProductInfo
        #endregion

        //----- Events -----//
        //----- Change the product content when category be chosen
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProductInfo(product.ElementAt(cbxCategory.SelectedIndex));
        }// End of cbxCategory
    }// End of Class frmViewProduct
}// End of namespace
