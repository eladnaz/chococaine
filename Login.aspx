<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="database.Login" MasterPageFile ="~/MasterPage.master" %>
<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="./CSS/Login Page.css">

</asp:Content>


<asp:Content ID="Body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="login">
        <span class = "UserText">Username :</span> <asp:TextBox ID="Username" CssClass="UserBox rounded rc5" runat="server"></asp:TextBox>
        <br />
        <br />
        <span class = "PassText">Password :</span> <asp:TextBox ID="Password" CssClass="PassBox rounded rc5" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Submit" CssClass="Submit rounded rc5" runat="server" Text="Login" OnClick="Submit_Click" />
        <br />
        <br />
        <asp:Label ID="LabelOutput" CssClass="Label" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
