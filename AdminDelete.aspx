<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminDelete.aspx.cs" Inherits="database.AdminDelete" MasterPageFile="~/AdminMaster.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="./CSS/AdminDelete.css">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ChocFilter" CssClass="ChocFilter rc5 rounded" runat="server" Font-Size="15pt">
        <asp:ListItem>Milk Chocolate</asp:ListItem>
        <asp:ListItem>Dark Chocolate</asp:ListItem>
        <asp:ListItem>Liquor Chocolate</asp:ListItem>
        <asp:ListItem>White Chocolate</asp:ListItem>
        <asp:ListItem>All Chocolate</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Filter" CssClass="Filter rc5 rounded" runat="server" Text="Filter" OnClick="Filter_Click" Font-Size="15pt" />
    <span Class="Ide">ID</span><asp:TextBox ID="Selection" CssClass="Selection" runat="server" Font-Size="15pt"></asp:TextBox><asp:Button ID="Delete" CssClass="Delete rounded rc5" runat="server" Text="Delete" OnClick="Delete_Click" Font-Size="15pt" />
    <asp:Label ID="DeleteOutput" CssClass="DeleteOutput" runat="server" Font-Size="15pt"></asp:Label>
    <asp:Label ID="LabelOutput" runat="server" Text="Label"></asp:Label>
    <div class="buffer3"></div>
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
</asp:Content>