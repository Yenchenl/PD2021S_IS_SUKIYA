//
// Project: IS_SUKIYA(Class) - Data Processing
// Date: 2021/05/30
// Author: A109222026 Kao,A109222038 Lin
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IS_Library;
using JLL_IS_Library;

//========== Namespace_IS_SUKIYA ==========//
namespace IS_SUKIYA.ClassFolder
{
    //===== File IO =====//
    #region//---------- Class RWaccount ----------//
    //===== Class RWaccount =====//
    class RWaccount
    {
        //----- Method -----//
        //----- updateAccount info.
        public static bool updateAccount(string fName, Account nowAccount)
        {
            bool flag = false;
            List<Account> accountList = new List<Account>();
            if (readAccount(fName, out accountList))
            {
                for (int i = 0; i < accountList.Count; i++) // find nowAccount in file
                {
                    if (nowAccount.account == accountList[i].account)   //check update
                    {
                        accountList[i].password = nowAccount.password;
                        accountList[i].name = nowAccount.name;
                        accountList[i].level = nowAccount.level;
                        if (writeAccount(fName, accountList))
                        {
                            MessageBox.Show("Account: " + accountList[i].account + '\n' +
                                            "Password: " + accountList[i].password + '\n' +
                                            "Authorization: " + accountList[i].level + '\n' +
                                            "Name: " + accountList[i].name);
                            flag = true;
                        }    //update success
                        break;
                    }
                }
            }
            return flag;
        }// End of Method updateAccount

        //----- readAccount info.
        public static bool readAccount(string fName, out List<Account> aList)
        {
            StreamReader sr;
            bool flag = true;
            string[] numAccount;
            string[] contentAccount;
            aList = new List<Account>();
            Account aa;
            try
            {
                sr = File.OpenText(fName);
                numAccount = sr.ReadToEnd().Split(IS_Library.FileInfo.LINE_SPLITTER);
                for (int i = 0; i < numAccount.Length; i++)
                {
                    contentAccount = numAccount[i].Split(IS_Library.FileInfo.TEXT_SPLITTER);
                    if (contentAccount.Length >= IS_Library.FileInfo.ACCOUNT_ITEM)
                    {
                        aa = new Account(contentAccount[0].Trim(), contentAccount[1].Trim(),
                            (JLL_IS_Library.AccountLevel)Enum.Parse(typeof(JLL_IS_Library.AccountLevel), contentAccount[2].Trim(), false), contentAccount[3].Trim());
                        aList.Add(aa);
                    }
                }
                sr.Close();
                return flag;
            }
            catch { MessageBox.Show("Load file fail!!"); return flag = false; }
        }// End of Method readAccount

        //----- writeAccount info.
        public static bool writeAccount(string fName, List<Account> aList)
        {
            StreamWriter sw;
            bool flag = true;
            try
            {
                sw = File.CreateText(fName);
                foreach (Account aa in aList)
                { sw.WriteLine(aa.account + ',' + aa.password + ',' + aa.level + ',' + aa.name); }
                sw.Close();
                return flag;
            }
            catch { MessageBox.Show("Save file fail!!"); return flag = false; }
        }// End of Method writeAccount
    }// End of Class RWaccount
    #endregion
}// End of namespace
