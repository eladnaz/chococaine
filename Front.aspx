<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Front.aspx.cs" Inherits="Front" MasterPageFile ="~/MasterPage.master" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="./CSS/Front.css">
</asp:Content>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="gallery">
        <div id="slidebox">
            <img class="slides goleft" src="./Images/JDD.png" />
            <img class="slides goleft" src="./Images/JWWW.png" />
            <img class="slides goleft" src="./Images/Dove.png" />
            <img class="slides goleft" src="./Images/Hersheys.png" />
            <img class="slides goleft" src="./Images/Ghira.png" />
            <img class="slides goleft" src="./Images/Lindt.png" />
            <img class="slides goleft" src="./Images/toble.png" />
            <img class="slides goleft" src="./Images/Val.png" />
            <img class="slides goleft" src="./Images/Guin.png" />
        </div>
    </div>
    <div id="Intro">
        <div id="image1">
            <img src="./Images/choco1.png" height="700" width="700" />
        </div>
        <div id="intro1">
            <p id="text1">
                DID YOU KNOW?
                <br>
                Dark chocolate helps restore flexibility to arteries while also preventing white blood cells from sticking to the walls of blood vessels - both common causes of artery clogging.
            </p>
        </div>
        <div id="image2">
            <img src="./Images/choco2.png" height ="700" width ="700" />
        </div>
        <div id="intro2">
            <p id="text1">
                IT ALSO REDUCES THE RISK OF STROKE
                <br />
                A research done in Finland have found that chocolate consumption has reduced the risk of suffering a stroke by a staggering 17 percent.
            </p>
        </div>
        <div id="image3">
            <img src="./Images/choco3.png" height ="700" width="700" />
        </div>
        <div id="intro3">
            <p id="text1">
                IT'S MINERAL RICH
                <br />
                Most chocolate is packed with beneficial minerals such as potassium, zinc and also provides 67 per cent of the RDA of iron.
            </p>
        </div>
    </div>
    <div id="videobox">
        <div id="newspaper">
            <img src="./Images/newspaper.png" />
        </div>
        <div id="video">
            <video src="./Images/choco.mp4" controls width = "600" height ="400"></video>
        </div>
    </div>
    <div class ="buffer2" ></div>
    <script type="text/javascript" src="./Javascript/Front.js"></script>
</asp:content>