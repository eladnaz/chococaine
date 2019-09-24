<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminEdit.aspx.cs" Inherits="database.AdminEdit" MasterPageFile="~/AdminMaster.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="./CSS/AdminEdit.css">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Filter" CssClass="Filter rc5 rounded" runat="server" Text="Filter" OnClick="Filter_Click" Font-Size="15pt" />
    <div id="container">
   <span id ="ID">ID :  </span><asp:TextBox ID="Selection" runat="server" Width="55px" Font-Size="15pt"></asp:TextBox>
   <span id ="Brandtxt">&nbsp;&nbsp; <asp:Button ID="Pull" CssClass="rounded rc5" runat="server" Text="Pull" OnClick="Pull_Click" Font-Size="15pt" />
   &nbsp;&nbsp;Brand :    </span><asp:TextBox ID="Brand"  runat="server" Width="160px" Font-Size="15pt" OnTextChanged="Brand_TextChanged"></asp:TextBox>
   <span id ="Nametxt">&nbsp;&nbsp;&nbsp;&nbsp; 
        <br />
        Name :<asp:TextBox ID="Name" CssClass="test" runat="server" Font-Size="15pt"></asp:TextBox>
    <asp:DropDownList ID="ChocFilter" CssClass="ChocFilter rc5 rounded" runat="server" OnSelectedIndexChanged="ChocFilter_SelectedIndexChanged" Font-Size="15pt">
        <asp:ListItem>Milk Chocolate</asp:ListItem>
        <asp:ListItem>Dark Chocolate</asp:ListItem>
        <asp:ListItem>Liquor Chocolate</asp:ListItem>
        <asp:ListItem>White Chocolate</asp:ListItem>
        <asp:ListItem>All Chocolate</asp:ListItem>
    </asp:DropDownList>
        </span><span id ="Typetxt">
        Type :<asp:DropDownList ID="Type" CssClass="test" runat="server" Font-Size="15pt">
                <asp:ListItem>Milk</asp:ListItem>
                <asp:ListItem>Dark</asp:ListItem>
                <asp:ListItem>Liquor</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
           </asp:DropDownList>
        </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span id ="Pricetxt">
        Price :</span><asp:TextBox ID="Price" CssClass="test" runat="server" Font-Size="15pt"></asp:TextBox><br />
    <span id ="Desctxt">Description :</span><asp:TextBox ID="Desc" TextMode="MultiLine" CssClass="test desc" runat="server" Height="57px" Width="204px" Font-Size="15pt"></asp:TextBox>
    
    <span id = "Imagetxt">Image : </span><asp:Label ID="ImageText" CssClass="test" runat="server" Text="Label" Font-Size="15pt"></asp:Label> <asp:FileUpload ID="Image" CssClass="rounded rc5" runat="server" Font-Size="15pt" />

    <asp:Button ID="Save" CssClass="test Save rounded rc5" runat="server" Text="Save" OnClick="Save_Click" Font-Size="15pt" />
       <asp:Label ID="update" CssClass="test" runat="server" Font-Size="15pt"></asp:Label>
   </div>
    <asp:Label ID="LabelOutput" CssClass="Catalogue" runat="server" Text="Label"></asp:Label>
    <div class="buffer3"></div>
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>

</asp:Content>
