<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="LearnEF._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Entity Framework - Let's Begin
    </h2>
    SEARCH:<br />
    First Name : <asp:TextBox ID="txtSrchFirstName" runat="server"></asp:TextBox>
    &emsp;
    City : <asp:TextBox ID="txtSrchCity" runat="server"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    <br /><br />
    Select Employee : <asp:DropDownList ID="ddlEmployee" runat="server" 
        AutoPostBack="True" onselectedindexchanged="ddlEmployee_SelectedIndexChanged"></asp:DropDownList> <br />
    <hr />
    <div style="display:inline;width:100px;float:left;"> HR Emp ID :</div>
    <asp:TextBox ID="txtHREmpId" runat="server"></asp:TextBox>
    <br />
    <div style="display:inline;width:100px;float:left;"> First Name :</div>
    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    <br />
    <div style="display:inline;width:100px;float:left;"> Last Name :</div>
    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <br />
    <div style="display:inline;width:100px;float:left;"> Address :</div>
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <br />
    <div style="display:inline;width:100px;float:left;"> City :</div>
    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSave" runat="server" Text="SAVE" OnClick="btnSave_Click" />
    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
    <br /><br />

    <hr />

    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
