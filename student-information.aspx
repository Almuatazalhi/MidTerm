<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student-information.aspx.cs" Inherits="MidTerm.student_information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td style="height: 30px" colspan="2">
                <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="STUDENT INFORMATION"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px; height: 30px">Student ID</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">Student Name</td>
            <td>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">College</td>
            <td>
                <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">PhoneNumber</td>
            <td>
                <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblDis" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="DESTINATION"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblErrorMsg1" runat="server" ForeColor="#CC3300" Text="Your Transaction was not successfull please try again !" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">From :</td>
            <td>
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">To :</td>
            <td>
                <asp:TextBox ID="txtTo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">Departure Time:</td>
            <td>
                <asp:DropDownList ID="ddlDepartureTime" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">Return Time:</td>
            <td>
                <asp:DropDownList ID="ddlReturnTime" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 141px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblDis0" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Black" Text="CONFIRM TRANSACTION"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 24px;" colspan="2">
                <asp:Label ID="lblCorrectMsg" runat="server" ForeColor="#009933" Text="Your Transaction was successful" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 141px">
                <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
