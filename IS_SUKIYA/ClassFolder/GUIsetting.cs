//
// Project: IS_SUKIYA(Class) - GUI Setting
// Date: 2021/05/30
// Author: A109222026 Kao,A109222048 Lin,A109222038 Lin
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA
{
    //===== Class GUIprocessing =====//
    class GUIsetting
    {
        //----- Methods -----//
        #region// CbxContent
        public static void setCbxContent(string[] source, DataGridViewComboBoxColumn target)
        {
            target.Items.Clear();
            if (source.Length > 0)
            { foreach (string ss in source) { target.Items.Add(ss); } }
        }// End of Method setCbxContent

        public static void setCbxContent(string[] source, ComboBox target)
        {
            target.Items.Clear();
            if (source.Length > 0)
            {
                foreach (string ss in source) { target.Items.Add(ss); }
                target.SelectedIndex = 0;
            }
        }// End of Method setCbxContent
        #endregion

        #region//----- Set categories' name to ComboBox
        public static void setCategoryInfo(List<Category> source, ComboBox target)
        {
            target.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (Category cc in source) { target.Items.Add(cc.name); }
                target.SelectedIndex = 0;
            }
        }// End of Method setCategoryInfo
        #endregion

        #region//----- Set Items info. of a specified Category to ComboBox, CheckedListBox, ListBox, DataGridView
        public static bool setItemInfo(List<Item> source, ComboBox target)
        {
            bool flag = false;
            target.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { target.Items.Add(data.name + " $" + data.price); }
                target.SelectedIndex = 0; // don't set this, before the content of addon, option has been settle
                flag = true;
            }
            return flag;
        }// End of Method setItemInfo

        public static bool setItemInfo(List<Item> source, ListBox target)
        {
            bool flag = false;
            target.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { target.Items.Add(data.name + " $" + data.price); }
                target.SelectedIndex = 0;
                flag = true;
            }
            return flag;
        }// End of Method setItemInfo

        public static bool setItemInfo(List<Item> source, CheckedListBox clb)
        {
            bool flag = false;
            clb.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { clb.Items.Add(data.name + " $" + data.price); }
                for (int i = 0; i < clb.Items.Count; i++) { clb.SetItemChecked(i, false); }
                flag = true;
            }
            return flag;
        }// End of Method setItemInfo
        #endregion

        #region//----- Set Addon info. of a specified Category to CheckedListBox, ListBox, DataGridView
        public static bool setAddOnInfo(List<AddOnItem> source, CheckedListBox clb)
        {
            bool flag = false;
            clb.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { clb.Items.Add(data.name + " $" + data.price); }
                for (int i = 0; i < clb.Items.Count; i++) { clb.SetItemChecked(i, false); }
                flag = true;
            }
            return flag;
        }// End of Method setAddOnInfo

        public static bool setAddOnInfo(List<AddOnItem> source, ListBox target)
        {
            bool flag = false;
            target.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { target.Items.Add(data.name + " $" + data.price); }
                target.SelectedIndex = 0;
                flag = true;
            }
            return flag;
        }// End of Method setAddOnInfo

        public static bool setAddOnInfo(List<AddOnItem> source, ComboBox target)
        {
            bool flag = false;
            target.Items.Clear();
            if ((source != null) && (source.Count > 0))
            {
                foreach (var data in source) { target.Items.Add(data.name + " $" + data.price); }
                target.SelectedIndex = 0;
                flag = true;
            }
            return flag;
        }// End of Method setAddOnInfo
        #endregion

        #region//----- Set Option info. of a specified Category to ComboBox, DataGridView, CheckedListBox
        public static bool setOptionInfo(List<Option> source, ComboBox[] cbx)
        {
            bool flag = false;
            foreach (var vv in cbx) { vv.Visible = false; }
            if ((source != null) && (source.Count > 0))
            {
                for (int i = 0; i < source.Count && i < cbx.Length; i++)
                {
                    cbx[i].Items.Clear();
                    foreach (var data in source[i].option) { cbx[i].Items.Add(data.name + " $" + data.price); }
                    cbx[i].Visible = true;
                    cbx[i].SelectedIndex = 0; // when have two option, trigger computeSubtotal will cause error
                }
                flag = true;
            }
            return flag;
        }// End of Method setOptionInfo

        public static bool setOptionInfo(List<Option> source, ListBox[] cbx)
        {
            bool flag = false;
            foreach (var vv in cbx) { vv.Visible = false; }
            if ((source != null) && (source.Count > 0))
            {
                for (int i = 0; i < source.Count && i < cbx.Length; i++)
                {
                    cbx[i].Items.Clear();
                    foreach (var data in source[i].option) { cbx[i].Items.Add(data.name + " $" + data.price); }
                    cbx[i].Visible = true;
                    cbx[i].SelectedIndex = 0; // when have two option, trigger computeSubtotal will cause error
                }
                flag = true;
            }
            return flag;
        }// End of Method setOptionInfo
        #endregion

        #region//----- Set Transaction info. to DataGridView
        public static void setTransactionInfo(List<TransactionInfo> source, DataGridView dgv)
        {
            if ((source != null) && (source.Count > 0))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("TransactionID", typeof(string));
                dt.Columns.Add("Date", typeof(DateTime));
                dt.Columns.Add("Total", typeof(uint));
                foreach (TransactionInfo ii in source) { dt.Rows.Add(ii.id, ii.dateTime, ii.total); }
                dgv.DataSource = dt;
            }
            else { dgv.DataSource = null; }
        }// End of Method setTransactionInfo

        public static void setTransactionInfo(TransactionInfo tt, DataGridView dgv)
        {
            string ssa = "", sso = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Price", typeof(uint));
            dt.Columns.Add("Addon", typeof(string));
            dt.Columns.Add("Option", typeof(string));
            dt.Columns.Add("Quantity", typeof(uint));
            dt.Columns.Add("SubTotal", typeof(uint));

            foreach (TransactionDetail dd in tt.item)
            {
                ssa = "";
                sso = "";
                if ((dd.addOn != null) && (dd.addOn.Count > 0))
                {
                    foreach (AddOnItem aa in dd.addOn) { ssa += aa.name + " $" + aa.price + ";"; }
                    ssa = ssa.Substring(0, ssa.Length - 1);
                }
                if ((dd.option != null) && (dd.option.Count > 0))
                {
                    foreach (OptionDetail oo in dd.option) { sso += oo.name + " $" + oo.price + ";"; }
                    sso = sso.Substring(0, sso.Length - 1);
                }
                dt.Rows.Add(dd.name, dd.price, ssa, sso, dd.quantity, dd.subTotal);
            }
            dgv.DataSource = dt;
        }// End of Method setTransactionInfo
        #endregion
    }// End of Class GUIsetting
}// End of namespace
