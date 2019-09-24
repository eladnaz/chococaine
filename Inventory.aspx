<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="database.Inventory" MasterPageFile="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="./CSS/Inventory.css">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ChocFilter" CssClass="ChocFilter rc5 rounded" runat="server">
        <asp:ListItem>Milk Chocolate</asp:ListItem>
        <asp:ListItem>Dark Chocolate</asp:ListItem>
        <asp:ListItem>Liquor Chocolate</asp:ListItem>
        <asp:ListItem>White Chocolate</asp:ListItem>
        <asp:ListItem>All Chocolate</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Filter" CssClass="Filter rc5 rounded" runat="server" Text="Filter" OnClick="Filter_Click" />
    <asp:Label ID="LabelOutput" runat="server" Text="Label"></asp:Label>
    <div class="buffer3"></div>
</asp:Content>
            

