using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MidTerm
{
    public class DatabaseOperation
    {
        public DataSet PopulateDataset(string str_sql, string tblName)
        {
            //try
            //{

            // SqlConnection con; // Represents an open connection to a data source
            // The SqlDataAdapter provides this bridge by using Fill 
            // to load data from the data source into the DataSet
            SqlConnection con;
            SqlDataAdapter dad;
            DatabaseConnection dbc = new DatabaseConnection();
            con = new SqlConnection(dbc.strConnString);
            dad = new SqlDataAdapter(str_sql, con);
            dbc.dstDataSet = new DataSet();
            dad.Fill(dbc.dstDataSet, tblName);
            return dbc.dstDataSet;
            //}



            //catch (Exception ex)
            //{
            //    string script = "<script>alert('" + ex.Message + "');</script>";
            //}
        }
        // This method handles database operation such as add, delete, or update
        public void dbOperations(string src_sql, string msg)
        {

            DatabaseConnection dbc = new DatabaseConnection();
            SqlConnection con = new SqlConnection(dbc.strConnString);
            string str_Sql;
            // SqlCommand - Represents an SQL statement 
            // or stored procedure to execute against a data source.
            SqlCommand cmd = new SqlCommand(src_sql, con);
            con.Open();
            str_Sql = src_sql;
            // ExecuteNonQuery
            // Executes a SQL statement against the Connection 
            // and returns the number of rows affected.
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}