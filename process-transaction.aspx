<%@ Page Title="" Language="C#" MasterPageFile="~/SiteDriver.Master" AutoEventWireup="true" CodeBehind="process-transaction.aspx.cs" Inherits="MidTerm.process_transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="grdMyTranscations" runat="server" AllowPaging="True" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="351px" OnSelectedIndexChanged="grdMyTranscations_SelectedIndexChanged" Width="393px">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br />
<br />
<table class="w-100">
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 180px">Reference No</td>
        <td>
            <asp:TextBox ID="txtReference" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">StudentID</td>
        <td>
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">From</td>
        <td>
            <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Destination</td>
        <td>
            <asp:TextBox ID="txtDestination" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Departure Time</td>
        <td>
            <asp:TextBox ID="txtDepartureTime" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Return Time</td>
        <td>
            <asp:TextBox ID="txtReturnTime" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Date</td>
        <td>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Time</td>
        <td>
            <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 180px">Approved</td>
        <td>
            <asp:TextBox ID="txtApproved" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
</asp:Content>
