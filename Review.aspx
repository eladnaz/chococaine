<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Review.aspx.cs" Inherits="database.Review"  MasterPageFile ="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="./CSS/Review.css">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
<span class="text">Title          :    </span><asp:TextBox id="Title1" CssClass="box rc5 rounded" Runat="server" Font-Size="15pt" /><br/>
<span class="text">Email Address          :    </span><asp:TextBox id="Email" CssClass="box rc5 rounded" Runat="server" Font-Size="15pt" /><br/>
<span class="text">Feedback:<br/></span>
<asp:TextBox id="Feedback" Rows="4" Width="500" CssClass="box rc5 rounded" TextMode="MultiLine" Runat="server" Font-Size="15pt" /><br />
<asp:Button id="Submit" Text="Submit" CssClass="box rc5 rounded" runat="server" OnClick="Submit_Click1" Font-Size="15pt" />
<asp:Label ID="Output" CssClass ="text box" runat="server" Text=""></asp:Label>
</div>
</asp:content>




