using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MidTerm
{
    public partial class process_transaction : System.Web.UI.Page
    {
        DatabaseConnection dbc = new DatabaseConnection();
        DatabaseOperation dbo = new DatabaseOperation();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (DatabaseConnection.strStudentID == "")
            {
                Response.Redirect("~/Student-Login.aspx");
            }

            dbc.strSql = "SELECT * FROM REQUESTED_TRIP ";
            dbc.strTableName = "REQUESTED_TRIP";
            dbc.tblMyTable = dbo.PopulateDataset(dbc.strSql, dbc.strTableName).Tables[0];
            grdMyTranscations.DataSource = dbc.tblMyTable;
            grdMyTranscations.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void grdMyTranscations_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReference.Text = grdMyTranscations.SelectedRow.Cells[1].Text;
            txtStudentID.Text = grdMyTranscations.SelectedRow.Cells[2].Text;
            txtFrom.Text = grdMyTranscations.SelectedRow.Cells[3].Text;
            txtDestination.Text = grdMyTranscations.SelectedRow.Cells[4].Text;
            txtDepartureTime.Text = grdMyTranscations.SelectedRow.Cells[5].Text;
            txtReturnTime.Text = grdMyTranscations.SelectedRow.Cells[6].Text;
            txtDate.Text = grdMyTranscations.SelectedRow.Cells[7].Text;
            txtTime.Text = grdMyTranscations.SelectedRow.Cells[8].Text;
            txtApproved.Text = grdMyTranscations.SelectedRow.Cells[9].Text;
            passValues();
        }

        private void passValues()
        {
            DatabaseConnection.strReferenceNo = txtReference.Text;
            DatabaseConnection.strStudentID = txtStudentID.Text;
            DatabaseConnection.strMoveFrom = txtFrom.Text;
            DatabaseConnection.strMoveTo = txtDestination.Text;
            DatabaseConnection.strDepTime = txtDepartureTime.Text;
            DatabaseConnection.strReturnTime = txtReturnTime.Text;
        }
    }
}