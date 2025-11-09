using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class student_information : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();  
        DatabaseOperation dbo = new DatabaseOperation();    
        protected void Page_Load(object sender, EventArgs e)
        {

            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student-Login.aspx");
            }


            dbc.strSql = "SELECT * FROM Students WHERE StudentID = '" + DatabaseConnection.strStudentID + "'";
            dbc.strTableName = "Students";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0]; // Dont Forget .Tables[0]
            int intRowIndex;
            intRowIndex = 0; // No rows in position 2
            displayRecords(intRowIndex);

            ddlDepartureTime.Items.Add("08:00");
            ddlDepartureTime.Items.Add("09:00");
            ddlDepartureTime.Items.Add("10:00");
            ddlDepartureTime.Items.Add("11:00");
            ddlDepartureTime.Items.Add("12:00");
            ddlDepartureTime.Items.Add("13:00");
            ddlDepartureTime.Items.Add("14:00");
            ddlDepartureTime.Items.Add("15:00");
            ddlDepartureTime.Items.Add("16:00");
            ddlDepartureTime.Items.Add("17:00");
            ddlDepartureTime.Items.Add("18:00");
            ddlReturnTime.Items.Add("08:00");
            ddlReturnTime.Items.Add("09:00");
            ddlReturnTime.Items.Add("10:00");
            ddlReturnTime.Items.Add("11:00");
            ddlReturnTime.Items.Add("12:00");
            ddlReturnTime.Items.Add("13:00");
            ddlReturnTime.Items.Add("14:00");
            ddlReturnTime.Items.Add("15:00");
            ddlReturnTime.Items.Add("16:00");
            ddlReturnTime.Items.Add("17:00");
            ddlReturnTime.Items.Add("18:00");
        }

        private void displayRecords(int intRowIndex)
        {
            txtStudentID.Text = dbc.tblMyTable.Rows[intRowIndex][0].ToString(); // Change [intRowIndex]
            txtStudentName.Text = dbc.tblMyTable.Rows[intRowIndex][1].ToString(); // Change [intRowIndex]
            txtCollege.Text = dbc.tblMyTable.Rows[intRowIndex][2].ToString(); // Change [intRowIndex]
            txtPhoneNumber.Text = dbc.tblMyTable.Rows[intRowIndex][3].ToString(); // Change [intRowIndex]
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "" ||
                ddlDepartureTime.Text.Trim() == "" || ddlReturnTime.Text.Trim() == "")
            {
                lblErrorMsg1.Visible = true;
            }
            else
            {
                lblErrorMsg1.Visible = false;
                lblCorrectMsg.Visible = true;
            }

            int intRecoredCounter;
            dbc.strSql = "SELECT * FROM REQUESTED_TRIP";
            dbc.strTableName = "REQUESTED_TRIP";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            intRecoredCounter = dbc.tblMyTable.Rows.Count;
            intRecoredCounter = intRecoredCounter + 1;
            string strRequestNo = "Re" + intRecoredCounter;

            string strDate;
            string strTime;
            strDate = DateTime.Now.ToShortDateString();
            strTime = DateTime.Now.ToShortTimeString();
            dbc.strSql = "INSERT INTO REQUESTED_TRIP (Request_No, Student_ID, Move_From, Move_To, ";
            dbc.strSql += " Departure_Time, Return_Time, Date_Issued, Time_Issued, Request_Statues) ";

            dbc.strSql += " VALUES('" + strRequestNo + "', ";
            dbc.strSql += "'" + txtStudentID.Text + "', ";
            dbc.strSql += "'" + txtFrom.Text + "', ";
            dbc.strSql += "'" + txtTo.Text + "', ";
            dbc.strSql += "'" + ddlDepartureTime.Text + "', ";
            dbc.strSql += "'" + ddlReturnTime.Text + "', ";
            dbc.strSql += "'" + strDate + "', ";
            dbc.strSql += "'" + strTime + "', ";
            dbc.strSql += "'No')";
            dbo.dbOperations(dbc.strSql, "");
        }
    }
}

