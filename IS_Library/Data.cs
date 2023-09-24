//
// Project: Information Syste Common Library - Data
// Date: 2021/04/20
// Author: A109222026 Kao,A109222038 Lin,A109222048 Lin
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//========== Namespace_IS_Library ==========//
namespace IS_Library
{
    //===== Enum Data Type =====//
    public enum SalaryType { Monthly, Hourly, CommissionBase, Commission }
    public enum WeekDay { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    public enum AccountLevel { Administrator, Owner, Worker, Guest }
    public enum FileType { Text, MySQL, Excel, Access, Object }

    //===== Class FileInfo =====//
    public class FileInfo
    {
        //---------- Global constant (default is static also) ----------//
        public const int ACCOUNT_ITEM = 3;
        public const int TRANSACTION_ITEM = 9;
        public const char DIR_SPLITTER = '\\';
        public const char LINE_SPLITTER = '\n';
        public const char TEXT_SPLITTER = ',';
        public const char LEVEL1_SPLITTER = ';';
        public const char LEVEL2_SPLITTER = ':';
        public const string ACCESS_FILE_EXTENSION = ".adb";
        public const string EXCEL_FILE_EXTENSION = ".csv";
        public const string MYSQL_FILE_EXTENSION = ".sql";
        public const string TEXT_FILE_EXTENSION = ".txt";
        public const string ACCESS_FILE_FILTER = "MS Access|*.accdb|All File|*.*";
        public const string EXCEL_FILE_FILTER = "MS Excel|*.csv|All File|*.*";
        public const string MYSQL_FILE_FILTER = "My SQL|*.sql|All File|*.*";
        public const string TEXT_FILE_FILTER = "Text|*.txt|All File|*.*";
        public const string OBJECT_FILE_FILTER = "Object|*.bin|All File|*.*";
        public const string REPORT_FILE_EXTENSION = ".rpt";
        public const string DATA_FILE_EXTENSION = ".dat";
        public const string OBJECT_FILE_EXTENSION = ".bin";
    }// End of Class FileInfo

    //===== Struct Data LogInOut =====//
    [Serializable]
    public struct LogInOut
    {
        public DateTime login;
        public DateTime logout;

        public LogInOut(DateTime ii, DateTime oo)
        {
            login = ii;
            logout = oo;
        }
    }// End of Struct LogInOut

    //===== Class Account =====//
    [Serializable]
    public class Account
    {
        public string id;
        public string pw;
        public AccountLevel level;
        public List<LogInOut> logInOut = new List<LogInOut>();

        public Account() { id = "guest"; pw = "12345"; level = AccountLevel.Guest; }
        public Account(string id, string pw, AccountLevel al) { this.id = id; this.pw = pw; this.level = al; }
        public Account(string id, string pw, AccountLevel al, LogInOut io)
        {
            this.id = id;
            this.pw = pw;
            this.level = al;
            logInOut.Add(io);
        }
    }//End of Class Account
}// End of namespace
