<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" MasterPageFile="~/AdminMaster.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="./CSS/Admin.css">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="Welcome">Welcome Admin ! <br /> What would you like to do ?</div>
    <div class="chocAdd"><a href="AdminAdd.aspx">Add</a></div>
    <div class="chocEdit"><a href="AdminEdit.aspx">Edit</a></div>
    <div class="chocDelete"><a href="AdminDelete.aspx">Delete</a></div>
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
</asp:Content>

