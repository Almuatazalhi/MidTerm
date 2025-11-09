using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class student_login : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperation dbo = new DatabaseOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)   // Be carefull in button 
        {
            dbc.strSql = "SELECT * FROM App_LOGIN WHERE User_Name = '" + txtUserID.Text + "'";
            dbc.strSql += " AND User_Password = '" + txtPassword.Text + "'";
            dbc.strTableName = "App_LOGIN";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];

            int intRecordCounter;
            intRecordCounter = dbc.tblMyTable.Rows.Count;

            if (intRecordCounter > 0)
            {
                lblErrorMsg.Visible = false;
                DatabaseConnection.strStudentID = txtUserID.Text;
                Response.Redirect("~/student-information.aspx");
            }
            else
            {
                lblErrorMsg.Visible = true;
            }
        }
    }
}