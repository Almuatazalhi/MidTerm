using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class confirmation : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperation dbo = new DatabaseOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student-Login.aspx");
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string strDate;
            string strTime;
            strDate = DateTime.Now.ToShortDateString();
            strTime = DateTime.Now.ToShortTimeString();
            dbc.strSql = "INSERT INTO ConfirmedTrip (Trip_No, Student_ID, Car_Plate_NO, Driver_ID, ConfirmationDate, ConfirmationTime, AdminID) ";
            dbc.strSql = dbc.strSql + " VALUES ('" + txtTripReference.Text + "', ";
            dbc.strSql = dbc.strSql + "'" + txtStudentID.Text + "', ";
            dbc.strSql = dbc.strSql + "'" + txtCarRegistration.Text + "', "; 
            dbc.strSql = dbc.strSql + "'" + txtDriverID.Text + "', ";
            dbc.strSql = dbc.strSql + "'" + strDate + "', ";
            dbc.strSql = dbc.strSql + "'" + strTime + "', ";
            dbc.strSql = dbc.strSql + "'" + DatabaseConnection.strAdimID + "')";
            dbo.dbOperations(dbc.strSql, "");
            dbc.strSql = "UPDATE REQUESTED_TRIP ";
            dbc.strSql = dbc.strSql + " SET Request_Statues = 'Yes' ";
            dbc.strSql = dbc.strSql + " WHERE Student_ID = '" + txtStudentID.Text + "'";
            dbo.dbOperations(dbc.strSql, "");
        }
    }
}