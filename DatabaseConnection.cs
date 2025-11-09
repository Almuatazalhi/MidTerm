using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MidTerm
{
    public class DatabaseConnection
    {
        public string strConnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\TransationNew.mdf;Integrated Security=True";
        public string strSql;
        public string strTableName;
        public string strMsg;
        public DataSet dstDataSet;
        public DataTable tblMyTable;
        public string strSelectedID;
        public static string strStudentID = "";
        public static string strReferenceNo = "";
        public static string strCarPlateNo = "";
        public static string strDriverID = "";
        public static string strMoveFrom = "";
        public static string strMoveTo = "";
        public static string strDepTime = "";
        public static string strReturnTime = "";
        public static string strstrBrand = "";
        public static string strAdimID = "";
    }
}