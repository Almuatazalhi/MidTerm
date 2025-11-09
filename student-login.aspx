<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student-login.aspx.cs" Inherits="MidTerm.student_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 165px">&nbsp;</td>
            <td id="lblMessage">
                <asp:Label ID="lblErrorMsg" runat="server" ForeColor="#CC3300" Text="Your attempt was not successful Please try again" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 165px; height: 24px">Student ID</td>
            <td style="height: 24px">
                <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 165px">Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 165px">&nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
