//
// Project: IS_SUKIYA(Class) - Data Definition
// Date: 2021/05/30
// Author: A109222026 Kao,A109222038 Lin,A109222048 Lin
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS_Library;
using JLL_IS_Library;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA
{
    #region//===== Class Account =====//
    [Serializable]
    public class Account
    {
        //---------- Data ----------//
        //----- Global Data -----//
        private string pAccount;//帳號
        private string pPassword;//密碼
        private JLL_IS_Library.AccountLevel pLevel;//權限
        private string pName = "";//名字

        //----- Property -----//
        public string account
        {
            get { return pAccount; }
            set { if (CheckData.checkData(value)) pAccount = value; }
        }
        public string password
        {
            get { return pPassword; }
            set { if (CheckData.checkData(value)) pPassword = value; }
        }
        public JLL_IS_Library.AccountLevel level { get { return pLevel; } set { } }
        public string name
        {
            get { return pName; }
            set { if (value != null) { pName = value; } }
        }
        public Account(Account acc) : this(acc.account, acc.password, acc.level, acc.name) { }
        public Account(string aa, string pp, JLL_IS_Library.AccountLevel ll, string name = "test")
        {
            if ((aa != null) && (aa.Trim().Length > 0)) { pAccount = aa; }
            else { pAccount = "test"; }
            if ((pp != null) && (pp.Trim().Length > 0)) { pPassword = pp; }
            else { pPassword = "test"; }
            pLevel = ll;
            pName = name;
        }
        // Override toString
        public override string ToString()
        {
            return "(account, pw, authorization, name)--> "
                + pAccount + ", " + password + level + pName;
        }// End of override ToString
    }// End of Class Account
    #endregion

    #region//===== Class Category =====//
    [Serializable]
    public class Category
    {
        //---------- Global data ----------//
        //----- Private data -----//
        private uint pCID; // 產品編號
        private string pName;// 產品名稱
        private List<Item> pItem = new List<Item>();//類別品項
        private List<AddOnItem> pAddOnItem = new List<AddOnItem>(); // 類別加點
        private List<Option> pOption = new List<Option>(); //Hot, Warm, Cool or L, M, S

        //----- Properties for global private data -----//
        public uint cID { get { return pCID; } set { pCID = value; } }
        public string name
        {
            get { return pName; }
            set { if  ((value != null) && (value.Trim().Length > 0)) { pName = value; } }

        }
        public List<Item> item { get { return pItem; } set { pItem = value; } }
        public List<AddOnItem> addOnItem { get { return pAddOnItem; } set { pAddOnItem = value; } }
        public List<Option> option { get { return pOption; } set { pOption = value; } }

        //---------- Actions ----------//
        //----- Constrctor -----//
        public Category()
        { setInitialInfo(1, "Category", new List<Item>(), new List<AddOnItem>(), new List<Option>()); }
        public Category(uint cc, string nn)
        { setInitialInfo(cc, nn, new List<Item>(), new List<AddOnItem>(), new List<Option>()); }
        public Category(uint cc, string nn, List<Item> ii)
        { setInitialInfo(cc, nn, ii, new List<AddOnItem>(), new List<Option>()); }
        public Category(uint cc, string nn, List<Item> ii, List<AddOnItem> aa, List<Option> oo)
        { setInitialInfo(cc, nn, ii, aa, oo); }
        void setInitialInfo(uint cc, string nn, List<Item> ii, List<AddOnItem> aa, List<Option> oo)
        {
            cID = cc;
            name = nn;
            item = ii;
            addOnItem = aa;
            option = oo;
        }

        //----- Methods -----//
        //----- ToString to display the content of Category
        override public string ToString()
        {
            string ss = "Category " + cID + ": " + name + ", contains " + item.Count + " item. \n";
            if (item != null) foreach (Item ii in item) { ss += "\t" + ii; }
            if (addOnItem != null) foreach (AddOnItem aa in addOnItem) { ss += "\t" + aa; }
            if (option != null) foreach (Option oo in option) { ss += "\t" + oo; }
            return ss;
        }// End of override ToString
    }// End of Class Category
    #endregion

    #region//===== Class Item =====//
    [Serializable]
    public class Item
    {
        //---------- Data ----------//
        //----- Global private data -----//
        private uint pCID; //品項編號
        private uint pIID; // can be deleted in this version
        private string pName;//品項名稱
        private uint pPrice;//品項價錢

        //----- Properties for global data -----//
        public uint cID { get { return pCID; } set { pCID = value; } }
        public string name
        {
            get { return pName; }
            set { if ((value != null) && (value.Trim().Length > 0)) { pName = value; } }
        }
        public uint price { get { return pPrice; } set { pPrice = value; } }

        //----- Constructor -----//
        public Item() { setInitialInfo(1, "Item", 0); }
        public Item(uint cc, string nn, uint pp) { setInitialInfo(cc, nn, pp); }
        public Item(string nn, uint pp) { setInitialInfo(1, nn, pp); }
        void setInitialInfo(uint cc, string nn, uint pp)
        {
            cID = cc;
            name = nn;
            price = pp;
        }

        //----- Common methods -----//
        //----- toString to display the content of Item
        override public string ToString()
        {
            string ss = "Category " + cID + " Item: " + string.Format("{0, -20}", name) + "\t$" + price + '\n';
            return ss;
        }// End of override ToString
    }// End of Class Item
    #endregion

    #region//===== Class AddOnItem =====//
    [Serializable]
    public class AddOnItem
    {
        //---------- Data ----------//
        //----- Private data -----//
        private uint pCID; //加點編號 
        private uint pAID; 
        private string pName;//加點名字
        private uint pPrice;//加點價錢

        //----- Properties for global data -----//
        public uint cID { get; set; }
        public string name
        {
            get { return pName; }
            set { if ((value != null) && (value.Trim().Length > 0)) { pName = value; } }
        }
        //public uint price { get; set; }
        public uint price { get { return pPrice; } set { pPrice = value; } }

        //----- Constructor -----//
        public AddOnItem() { setInitialInfo(1, "AddOn", 0); }
        public AddOnItem(uint cc, string nn, uint pp) { setInitialInfo(cc, nn, pp); }
        public AddOnItem(string nn, uint pp) { setInitialInfo(1, nn, pp); }
        void setInitialInfo(uint cc, string nn, uint pp)
        {
            cID = cc;
            name = nn;
            price = pp;
        }

        //----- Common methods -----//
        //----- ToString to display the content of AddOnItem
        public override string ToString()
        {
            string ss = "Category " + cID + " Add on item: " + string.Format("{0, -20}", name) + "\t$" + price + "\n";
            return ss;
        }// End of override ToString
    }// End of Class AddOnItem
    #endregion

    #region//===== Class Option =====//
    [Serializable]
    public class Option
    {
        //---------- Data ----------//
        //----- Private data -----//
        private uint pCID; // should check unique選項編號
        private uint pOID; // can be deleted in this version
        private List<OptionDetail> pOption;//

        //----- Properties for global data -----//
        public uint cID { get; set; }
        public List<OptionDetail> option { get; set; }

        //---------- Actions -----------//
        //----- Constructor -----//
        public Option() { setInitialInfo(1, new List<OptionDetail>()); }
        public Option(uint cc, List<OptionDetail> od) { setInitialInfo(cc, od); }
        void setInitialInfo(uint cc, List<OptionDetail> od)
        {
            cID = cc; // check exist
            option = od;
        }

        //----- Common methods -----//
        //----- ToString to display the content of Option
        public override string ToString()
        {
            string ss = "Category " + cID + " Option: ";
            foreach (OptionDetail oo in option) { ss += "" + oo; }
            ss += '\n';
            return ss;
        }// End of override ToString
    }// End of Class Option
    #endregion

    #region//===== Class OptionDetail =====//
    [Serializable]
    public class OptionDetail
    {
        //----- Global data -----//
        //----- Private data
        private string pName;//選項名稱
        private uint pPrice;//選項價錢

        //----- Properties for global private data
        public string name
        {
            get { return pName; }
            set { if ((value != null) && (value.Trim().Length > 0)) { pName = value; } }
        }
        public uint price { get { return pPrice; } set { pPrice = value; } }
        //----- Constructor -----//
        public OptionDetail() { setInitialInfo("OptionDetail", 0); }
        public OptionDetail(string nn, uint pp) { setInitialInfo(nn, pp); }
        void setInitialInfo(string nn, uint pp) { name = nn; price = pp; }

        //----- Common methods -----//
        //----- ToString to display the detail of an Option
        public override string ToString() { return (" " + pName + " $" + pPrice + "\t"); }
    }// End of Class OptionDetail
    #endregion

    #region//===== Class Transaction =====//
    [Serializable]
    public class TransactionInfo
    {
        //---------- Global data ----------//
        private string p_id = "";
        private string p_cashier = ""; // for account
        private DateTime p_dt;
        private List<TransactionDetail> p_item = new List<TransactionDetail>();
        private uint p_total = 0;

        //----- Properties for global private data
        public string id { get { return p_id; } set { setInitialInfo(value, p_cashier, p_dt, p_item, p_total); } }
        public string cashier { get { return p_cashier; } set { setInitialInfo(p_id, value, p_dt, p_item, p_total); } }
        public DateTime dateTime { get { return p_dt; } set { setInitialInfo(p_id, p_cashier, value, p_item, p_total); } }
        public List<TransactionDetail> item { get { return p_item; } set { setInitialInfo(p_id, p_cashier, p_dt, value, p_total); } }
        public uint total { get { return p_total; } set { setInitialInfo(p_id, p_cashier, p_dt, p_item, value); } }

        //---------- Actions ----------//
        //----- Constructor -----//
        public TransactionInfo() { setInitialInfo(p_id, p_cashier, DateTime.Now, new List<TransactionDetail>(), 0); }
        public TransactionInfo(string accountName) { setInitialInfo(p_id, p_cashier, DateTime.Now, new List<TransactionDetail>(), 0); }
        public TransactionInfo(string id, DateTime ddtt, List<TransactionDetail> ii, uint tt) { setInitialInfo(id, p_cashier, ddtt, ii, tt); }
        void setInitialInfo(string id, string cc, DateTime ddtt, List<TransactionDetail> ii, uint tt)
        {
            p_id = id;
            p_cashier = cc;
            p_dt = ddtt;
            p_item = ii;
            p_total = tt;
        }

        //----- Methods -----//
        //----- ToString to display the content of TransactionInfo
        public override string ToString()
        {
            string ss = p_id + '\n';
            ss += DateTimeProcessing.dateTimeToString(p_dt) + '\n';
            foreach (TransactionDetail ii in item) { ss += "" + ii; }
            ss += "Total: " + p_total;
            return ss;
        }// End of override ToString
    }//End of Class TransactionInfo
    #endregion

    #region//===== Class TransactionDetail =====//
    [Serializable]
    public class TransactionDetail
    {
        //---------- Global data ----------//
        private uint p_cID = 1;//交易紀錄編號
        private string p_cName = "";//交易記錄名稱
        private string p_name = "";//交易名稱
        private uint p_price = 0;//交易之價錢
        private uint p_quantity = 0;//交易數量
        private List<AddOnItem> p_addOn = new List<AddOnItem>();//交易紀錄之新增的部分
        private List<OptionDetail> p_option = new List<OptionDetail>();//交易紀錄之選項部分
        private uint p_subTotal = 0;//交易紀錄之單項的部分

        //----- Properties for private data
        public uint cID { get { return p_cID; } set { setInitialInfo(value, p_cName, p_name, p_price, p_quantity, p_addOn, p_option); } }
        public string cName { get { return p_cName; } set { setInitialInfo(p_cID, value, p_name, p_price, p_quantity, p_addOn, p_option); } }
        public string name { get { return p_name; } set { setInitialInfo(p_cID, p_cName, value, p_price, p_quantity, p_addOn, p_option); } }
        public uint price { get { return p_price; } set { setInitialInfo(p_cID, p_cName, p_name, value, p_quantity, p_addOn, p_option); } }
        public uint quantity { get { return p_quantity; } set { setInitialInfo(p_cID, p_cName, p_name, p_price, value, p_addOn, p_option); } }
        public List<AddOnItem> addOn { get { return p_addOn; } set { setInitialInfo(p_cID, p_cName, p_name, p_price, p_quantity, value, p_option); } }
        public List<OptionDetail> option { get { return p_option; } set { setInitialInfo(p_cID, p_cName, p_name, p_price, p_quantity, p_addOn, value); } }
        public uint subTotal { get { return p_subTotal; } set { } }

        //---------- Actions ----------//
        //----- Constructor -----//
        public TransactionDetail() { setInitialInfo(p_cID, p_cName, p_name, p_price, p_quantity, p_addOn, p_option); }
        public TransactionDetail(uint cc, string ccnn, string nn, uint pp, uint qq) { setInitialInfo(cc, ccnn, nn, pp, qq, p_addOn, p_option); }
        public TransactionDetail(uint cc, string ccnn, string nn, uint pp, uint qq, List<AddOnItem> aa, List<OptionDetail> oo) { setInitialInfo(cc, ccnn, nn, pp, qq, aa, oo); }
        void setInitialInfo(uint cc, string ccnn, string nn, uint pp, uint qq, List<AddOnItem> aa, List<OptionDetail> oo)
        {
            uint aTemp = 0, oTemp = 0;
            p_cID = cc;
            p_cName = ccnn;
            p_name = nn;
            p_price = pp;
            p_quantity = qq;
            p_addOn = aa;
            p_option = oo;
            if (aa != null) { foreach (AddOnItem ao in p_addOn) { aTemp += ao.price; } }
            if (oo != null) { foreach (OptionDetail od in p_option) { oTemp += od.price; } }
            p_subTotal = (p_price + aTemp + oTemp) * p_quantity;
        }

        //----- Methods -----//
        //----- ToString to display the content of TransactionDetail
        public override string ToString()
        {
            string ss = "Item " + p_cID + " " + string.Format("{0, -20}", p_cName) + ": " + string.Format("{0, -20}", p_name) + "\t$" + p_price + '\n';
            if ((p_addOn != null) && (p_addOn.Count > 0))
            {
                ss += "\tAdd on item --->";
                foreach (AddOnItem aa in p_addOn) { ss += '(' + aa.name + ", " + aa.price + ')'; }
            }
            if ((p_option != null) && (p_option.Count > 0))
            {
                ss += "\n\tOption --->";
                foreach (OptionDetail oo in p_option) { ss += '(' + oo.name + ", " + oo.price + ')'; }
            }
            ss += "\t\n" + " * " + p_quantity + " ---> SubTotal = " + p_subTotal + "\n\n";
            return ss;
        }// End of override ToString
    }//End of Class TransactionDetail
    #endregion

    #region//===== CheckData =====//
    public class CheckData
    {
        //----- Method -----//
        //----- Check account exist or not
        public static bool checkAccount(List<Account> accounts, string account, string pw, out Account nowAccount)
        {
            var vv = from aa in accounts
                     where aa.account == account && aa.password == pw
                     select aa;
            if (vv.Count() > 0)
            {
                nowAccount = new Account((Account)vv.ElementAt(0));
                return true;
            }
            else { nowAccount = null; return false; }
        }// End of Method checkAccount

        public static bool checkAccount(List<Account> accounts, string account)
        {
            var vv = from aa in accounts
                     where aa.account == account
                     select aa;
            if (vv.Count() > 0) { return true; }
            else { return false; }
        }// End of Method checkAccount

        //----- Check account/password legal or not
        public static bool checkData(string ss, int len1 = 4, int len2 = 12, string allowChars = "_-")
        {
            char[] allowChar =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            char[] cc = ss.ToCharArray();
            bool flag = false;
            int len = ss.Length;
            if ((len1 <= len) && (len <= len2))
            {
                foreach (char c in cc)
                {
                    if ((char.IsLetterOrDigit(c)) || c.ToString().Contains(allowChars))
                    { flag = true; }
                    else
                    { break; }
                }
            }
            return flag;
        }// End of Method checkData

        public static bool CheckExist(List<Category> dataList, string searchData)
        {
            bool flag = false;
            searchData = searchData.Trim().ToLower();
            if ((dataList != null) && (dataList.Count > 0))
            {
                //foreach (Category cc in dataList) { MessageBox.Show("Category : " + cc.name); }
                var vv = from dd in dataList
                         where dd.name.Trim().ToLower() == searchData
                         select dd;
                if (vv.Count() > 0) { flag = true; }
            }
            return flag;
        }// End of Method CheckExist

        public static bool CheckExist(List<Item> dataList, string searchData)
        {
            bool flag = false;
            searchData = searchData.Trim().ToLower();
            if ((dataList != null) && (dataList.Count > 0))
            {
                var vv = from dd in dataList
                         where dd.name.Trim().ToLower() == searchData
                         select dd;
                if (vv.Count() > 0) { flag = true; }
            }
            return flag;
        }// End of Method CheckExist

        public static bool CheckExist(List<AddOnItem> dataList, string searchData)
        {
            bool flag = false;
            searchData = searchData.Trim().ToLower();
            if ((dataList != null) && (dataList.Count > 0))
            {
                var vv = from dd in dataList
                         where dd.name.Trim().ToLower() == searchData
                         select dd;
                if (vv.Count() > 0) { flag = true; }
            }
            return flag;
        }// End of Method CheckExist
    }// End of Class CheckData
    #endregion

    #region //===Class TrasactionAnalysis===//
    public class TransactionAnalysis
    {

        public static void formChartData()
        {

        }

        public static void createChart()
        {

        }
    }//End of class TransactionAnalysis
    #endregion
}// End of namespace
