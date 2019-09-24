<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminAdd.aspx.cs" Inherits="database.AdminAdd" MasterPageFile="~/AdminMaster.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="./CSS/AdminAdd.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="test1">
        <p style="margin-left: 416px">
    Brand : <asp:TextBox ID="Brand" runat="server" Font-Size="15pt"></asp:TextBox>
    Name : <asp:TextBox ID="Name" runat="server" Font-Size="15pt"></asp:TextBox>
    <asp:DropDownList ID="Type" runat="server" Font-Size="15pt">
        <asp:ListItem>Milk</asp:ListItem>
        <asp:ListItem>Dark</asp:ListItem>
        <asp:ListItem>Liquor</asp:ListItem>
        <asp:ListItem>White</asp:ListItem>
    </asp:DropDownList>
        </p>
        <p style="margin-left: 416px">
    Price : <asp:TextBox ID="Price" runat="server" Font-Size="15pt"></asp:TextBox>
    <asp:FileUpload ID="Upload" runat="server" Font-Size="15pt" />
        </p>
        <p style="margin-left: 416px">
    Description : <asp:TextBox ID="Desc" runat="server" CssClass="desc" TextMode="MultiLine" Height="71px" Width="187px" Font-Size="15pt"></asp:TextBox>
    <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" Font-Size="15pt" />
    <asp:Label ID="Result" runat="server" Font-Size="15pt"></asp:Label>
        </p>
    </div>
    <asp:DropDownList ID="ChocFilter" CssClass="ChocFilter rc5 rounded" runat="server" Font-Size="15pt">
        <asp:ListItem>Milk Chocolate</asp:ListItem>
        <asp:ListItem>Dark Chocolate</asp:ListItem>
        <asp:ListItem>Liquor Chocolate</asp:ListItem>
        <asp:ListItem>White Chocolate</asp:ListItem>
        <asp:ListItem>All Chocolate</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="Filter" CssClass="Filter rc5 rounded" runat="server" Text="Filter" OnClick="Filter_Click" Font-Size="15pt" />
    <asp:Label ID="LabelOutput" CssClass="Catalogue" runat="server" Text="Label"></asp:Label>
    <div class="buffer3"></div>
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
</asp:Content>

