using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class assign_driver : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperation dbo = new DatabaseOperation();

        static int intRecordCounter;
        static int intRowIndex;
        static DataTable tblDRIVER = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student-Login.aspx");
            }

            if (Page.IsPostBack == false)
            {
                dbc.strSql = "SELECT * FROM DRIVER";
                dbc.strTableName = "DRIVER";
                tblDRIVER = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
                intRecordCounter = tblDRIVER.Rows.Count;
                displayRecords(intRowIndex);
            }
        }
        private void displayRecords(int intRowIndex)
        {
            txtDriverID.Text = tblDRIVER.Rows[intRowIndex][0].ToString(); // tblDriver
            txtDriverName.Text = tblDRIVER.Rows[intRowIndex][1].ToString(); // tblDriver
            txtStatus.Text = tblDRIVER.Rows[intRowIndex][2].ToString(); // tblDriver
            imgDriver.ImageUrl = "~/IMAGES/" + txtDriverID.Text + ".jpg"; // If Images does not work, check the SQL (Driver_ID) NCAHR(4) 
            DatabaseConnection.strDriverID = txtDriverID.Text;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            if (intRowIndex > 0)
            {
                intRowIndex -= 1;
                displayRecords(intRowIndex);
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "This is the first record";
                lblMessage.Visible = true;
            }
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            intRowIndex = 0;
            displayRecords(intRowIndex);
            lblMessage.Text = "This is the first record";
            lblMessage.Visible = true;
        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            intRowIndex = intRecordCounter - 1;
            displayRecords(intRowIndex);
            lblMessage.Text = "This is the last record";
            lblMessage.Visible = true;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (intRowIndex < intRecordCounter - 1)
            {
                intRowIndex += 1;
                displayRecords(intRowIndex);
                lblMessage.Visible = false;
            }
            else
            {
                lblMessage.Text = "This is the last record";
                lblMessage.Visible = true;
            }
        }
    }
}