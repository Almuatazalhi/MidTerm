using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class my_transaction : System.Web.UI.Page
    {


        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperation dbo = new DatabaseOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student-Login.aspx");
            }

            dbc.strSql = "SELECT [Request_NO] As [Reference No], [Student_ID] As [ID] , [Move_From] AS [From], ";
            dbc.strSql += " [Move_To] As [Destination], [Departure_Time] As [Departure Time], [Return_Time] As [Return Time], ";
            dbc.strSql += " [Date_Issued] As [Date], [Time_Issued] As [Time], [Request_Statues] AS [Approved] ";
            dbc.strSql += " FROM REQUESTED_TRIP";
            dbc.strSql += " WHERE Student_ID = '" + DatabaseConnection.strStudentID + "'";
            dbc.strTableName = "REQUESTED_TRIP";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            grdMyTranscations.DataSource = dbc.tblMyTable;
            grdMyTranscations.DataBind();
        }

        protected void grdMyTranscations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}