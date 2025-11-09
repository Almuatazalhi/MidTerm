<%@ Page Title="" Language="C#" MasterPageFile="~/SiteDriver.Master" AutoEventWireup="true" CodeBehind="assign-driver.aspx.cs" Inherits="MidTerm.assign_driver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td style="width: 136px">Driver ID</td>
            <td style="width: 182px">
                <asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox>
            </td>
            <td rowspan="3">
                <asp:Image ID="imgDriver" runat="server" Height="171px" ImageAlign="Middle" style="margin-left: 65px" Width="177px" />
            </td>
        </tr>
        <tr>
            <td style="width: 136px">Driver Name</td>
            <td style="width: 182px">
                <asp:TextBox ID="txtDriverName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 136px">Status</td>
            <td style="width: 182px">
                <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 136px">&nbsp;</td>
            <td style="width: 182px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="&lt;" Width="72px" />
            </td>
            <td style="width: 182px">
                <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="&gt;" Width="75px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 136px">
                <asp:Button ID="btnFirst" runat="server" OnClick="btnFirst_Click" Text="&lt;&lt;" Width="74px" />
            </td>
            <td style="width: 182px">
                <asp:Button ID="btnLast" runat="server" OnClick="btnLast_Click" Text="&gt;&gt;" Width="74px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" Font-Size="Larger" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
