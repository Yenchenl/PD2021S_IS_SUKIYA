//
// Project: IS_SUKIYA(Class) - File IO
// Date: 2021/05/30
// Author: A109222026 Kao,A109222048 Lin
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Stream
using System.Runtime.Serialization.Formatters.Binary; // Binary File
using System.Windows.Forms;
using IS_Library;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.ClassFolder
{
    #region//----- Read categories and their corresponding info. from .txt file
    //===== Class RWproduct =====//
    public class RWproduct
    {
        //---------- Action ----------//
        //----- RW product from binary file -----//
        //----- RW product from text file -----//
        public static bool readProduct(string fileName, out List<Category> cList)
        {
            // data declaration
            bool flag = false;
            cList = new List<Category>();
            Category cc;
            string[] cArray;
            string[] ciArray; // one column of each line
            uint uTemp;

            // perform read text
            try
            {
                // File with storeNampe contains categories
                StreamReader sr = File.OpenText(fileName);
                // Get categories information. first line is field description so skip it
                cArray = sr.ReadToEnd().Split(IS_Library.FileInfo.LINE_SPLITTER); //default is \n
                sr.Close();
                for (int i = 1; ((i < cArray.Length) && (cArray[i].Trim().Length > 0)); i++) // process one category, i = 1 because column 1 is category
                {
                    flag = false;
                    // Processing one category
                    cc = new Category();
                    ciArray = cArray[i].Split(IS_Library.FileInfo.TEXT_SPLITTER); // one category data, default is,
                    //if (ciArray.Length > 2) // > 2 mean CategoryID, CategoryName, Item
                    if (ciArray.Length > 2)
                    {
                        // Category id and name
                        if (uint.TryParse(ciArray[0].Trim(), out uTemp)) { cc.cID = uTemp; }
                        else { cc.cID = (uint)i; }
                        cc.name = ciArray[1].Trim();
                        if (cc.name.Length == 0) { cc.name = "Category"; }
                        if (ciArray[2].Trim().Length > 0)
                        {
                            if (readItem(cc.cID, ciArray[2].Trim(), cc.item)) { flag = true; }
                        }
                    } // End of cID, name, item

                    //Category addOnItems (depends on your IS, this is not necessary)
                    if ((ciArray.Length > 3) && (ciArray[4].Trim().Length > 0)) { readAddon(cc.cID, ciArray[3].Trim(), cc.addOnItem); }
                    else { cc.addOnItem = null; }
                    //Category option details (depends on your IS, this is not necessary and could have multiple choice)
                    if ((ciArray.Length > 4) && (ciArray[4].Trim().Length > 0)) { readOption(cc.cID, ciArray[4].Trim(), cc.option); }
                    else { cc.option = null; }
                    //Add one category into list
                    if (flag) { cList.Add(cc); }
                }// End of for each category
            }
            catch (ArgumentException ee) { MessageBox.Show("Illegal product data. " + ee.Message); }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
            return flag;
        }// End of Method readProduct

        //----- Read item
        public static bool readItem(uint cID, string ss, List<Item> iList)
        {
            bool flag = false;
            string[] iArray;
            string[] oneArray;
            Item ii;
            uint uTemp;

            iArray = ss.Split(IS_Library.FileInfo.LEVEL1_SPLITTER); // default is ;
            for (int iarr = 0; iarr < iArray.Length; iarr++)
            {
                ii = new Item();
                ii.cID = cID;
                oneArray = iArray[iarr].Split(IS_Library.FileInfo.LEVEL2_SPLITTER); //default is :
                if (oneArray.Length >= 2) // must have item and price
                {
                    ii.name = oneArray[0].Trim();
                    if (ii.name.Length > 0) // name can't null
                    {
                        if (uint.TryParse(oneArray[1].Trim(), out uTemp)) { ii.price = uTemp; }
                        else { ii.price = 0; }
                        iList.Add(ii);
                    }
                }// End of noe item
            }// End of for
            if (iList.Count > 0) { flag = true; } // item can't null
            else { flag = false; }
            return flag;
        }// End of Method readItem

        //----- Read addon
        public static void readAddon(uint cID, string ss, List<AddOnItem> aList)
        {
            string[] aArray;
            string[] oneArray;
            uint uTemp;
            AddOnItem aa;

            aArray = ss.Split(IS_Library.FileInfo.LEVEL1_SPLITTER); // ;
            if (aList == null) { aList = new List<AddOnItem>(); } //if no value than no give value
            for (int aarr = 0; aarr < aArray.Length; aarr++)
            {
                aa = new AddOnItem();
                aa.cID = cID;
                oneArray = aArray[aarr].Split(IS_Library.FileInfo.LEVEL2_SPLITTER);
                if (oneArray.Length >= 2)
                {
                    if (aa.name.Length > 0)
                    {
                        aa.name = oneArray[0].Trim();
                        if (uint.TryParse(oneArray[1].Trim(), out uTemp)) { aa.price = uTemp; }
                        else { aa.price = 0; }
                        aList.Add(aa);
                    }
                }// End of one addon
            }// End of addon list
        }// End of Method readAddon

        //----- Read option
        public static void readOption(uint cID, string ss, List<Option> oList)
        {
            string[] oArray;
            string[] oneArray;
            Option oo;
            OptionDetail oodd;
            uint uTemp;

            oArray = ss.Split(IS_Library.FileInfo.LEVEL1_SPLITTER); // default is ;
            if (oList == null) { oList = new List<Option>(); }
            for (int oarr = 0; oarr < oArray.Length; oarr++) // foreach (var vv in oArray)
            {
                oo = new Option();
                oo.cID = cID;
                oneArray = oArray[oarr].Split(IS_Library.FileInfo.LEVEL2_SPLITTER); // default is :
                if (oneArray.Length >= 2)
                {
                    for (int od = 0; od < oneArray.Length; od += 2)
                    {
                        oodd = new OptionDetail();
                        if (oodd.name.Length > 0)
                        {
                            oodd.name = oneArray[od].Trim();
                            if (uint.TryParse(oneArray[od + 1].Trim(), out uTemp)) { oodd.price = uTemp; }
                            else { oodd.price = 0; }
                            oo.option.Add(oodd);
                        }
                    }
                    if (oo.option.Count > 0) { oList.Add(oo); }
                }
            }
        }// End of Method readOption

        public static bool saveProduct(string fileName, List<Category> product)
        {
            bool flag = true;
            string ss = "";
            int i = 0, j = 0;
            StreamWriter sw = File.CreateText(fileName);
            try
            {
                ss = "CategoryID, CategoryName, Item, AddItemAndPrice, OptionTypeAndPriceAndOptionItem"; // first line for column name
                sw.WriteLine(ss);
                if ((product != null) && (product.Count > 0))
                {
                    foreach (Category cc in product) // save each category
                    {
                        // Category + Item //MessageBox.Show("Category is \n " + cc");
                        ss = cc.cID + "," + cc.name + ',';
                        if ((cc.item != null) && (cc.item.Count > 0))
                        {
                            for (i = 0; i < (cc.item.Count - 1); i++)
                            { ss += cc.item[i].name + ':' + cc.item[i].price + ';'; }
                            ss += cc.item[i].name + ':' + cc.item[i].price;
                        }
                        // Addon part //MessageBox.Show("After item " + ss");
                        ss += ',';
                        if ((cc.addOnItem != null) && (cc.addOnItem.Count > 0))
                        {
                            for (i = 0; i < (cc.addOnItem.Count - 1); i++)
                            { ss += cc.addOnItem[i].name + ':' + cc.addOnItem[i].price + ';'; }
                            ss += cc.addOnItem[i].name + ':' + cc.addOnItem[i].price;
                        }
                        // Option part //MessageBox.Show("After item " + ss");
                        ss += ',';
                        if ((cc.option != null) && (cc.option.Count > 0))
                        {
                            for (i = 0; i < (cc.option.Count - 1); i++) // for each option set except the last one
                            {
                                for (j = 0; j < (cc.option[i].option.Count - 1); j++) // for each option except the last one in an option set
                                { ss += cc.option[i].option[j].name + ':' + cc.option[i].option[j].price + ':'; }
                                ss += cc.option[i].option[j].name + ':' + cc.option[i].option[j].price + ';'; // last one option in an option set
                            }
                            for (j = 0; j < cc.option[i].option.Count; j++) // for last option set
                            { ss += cc.option[i].option[j].name + ':' + cc.option[i].option[j].price + ':'; }
                            ss = ss.Substring(0, ss.Length - 1);
                        }
                        //MessageBox.Show("After item " + ss);
                        sw.WriteLine(ss);
                    }// End of foreach category
                }// End of not empty product
            }
            catch (Exception ee) { flag = false; MessageBox.Show("Save file fail!! \n" + ee.Message, "Save Product"); }
            finally { sw.Close(); }
            return flag;
        }// End of Method saveProduct
    }// End of RWproduct
    #endregion

    #region//----- Save transaction report
    public class RWtransaction
    {
        public static bool saveReport(string fileName, List<TransactionInfo> tInfoList)
        {
            bool flag = true;
            string ss = "";
            StreamWriter sw;
            foreach (var tt in tInfoList) { ss += "\n" + tt + '\n'; }
            try
            {
                sw = File.CreateText(fileName);
                sw.Write(ss);
                sw.Close();
            }
            catch (Exception ee) { flag = false; }
            return flag;
        }// End of saving transaction report
    }// End of Class RWtransaction
    #endregion
}// End of namespace
