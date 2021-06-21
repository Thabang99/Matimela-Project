<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Matimela_Project.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>

	<link rel="stylesheet" type="text/css" href="css/home.css">

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://kit.fontawesome.com/a076d05399.js"></script>

    <style type="text/css">
        .fifthContainer {
            width: 443px;
            height: 201px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
                 <a class="noteq">Matimela</a>
                 <asp:TextBox ID="searchBar" runat="server" placeholder="Search..." CssClass="search" ></asp:TextBox>    
                <asp:Button ID="home" runat="server" Text="HOME" CssClass="nav" />
                <i class="fas fa-user"></i>
                <asp:Label ID="defaultText" runat="server" Text="user"></asp:Label>

             <div class="thirdContainer">

                 <asp:Label runat="server" Text="REPORTED ANIMALS IN ZONE" CssClass="topic1"></asp:Label>

                        <p class="zoneMessage">
                            Check out Matimela in a Zone
                        </p>
                 <asp:Button CssClass="zoneBtn" id="zoneCheck" runat="server" Text="check out" PostBackUrl="~/zoneMatimela.aspx"/>
                  

                    <div class="fourthContainer">
                        <asp:Label runat="server" Text="REPORTED ANIMALS IN LOCATION" CssClass="topic1"></asp:Label>
                            <p class="zoneMessage">
                            Check out Matimela in a specific Location in a Zone
                            </p>
                            <asp:Button CssClass="locationBtn" id="Button4" runat="server" Text="check out" PostBackUrl="~/locationMatimela.aspx"/>
                    </div>


        <div class="fifthContainer">
            <asp:Label runat="server" Text="NUMBER OF REPORTED ANIMALS" CssClass="topic1"></asp:Label>
                <p class="zoneMessage">
                            Check out total number of matimela in Botswana
                </p>
                  <asp:TextBox CssClass="numcheck" runat="server" placeholder="number" ID="numText"></asp:TextBox><br/>
                <asp:Button CssClass="btncheck" ID ="Button5" runat="server" Text="check out" onClick="Button5_Click"/>

        </div>


             </div>


        </div>

        <div class="secondContainer">
            <asp:Button ID="sub" runat="server" Text="PROFILE" CssClass="btn" />
            <asp:Button ID="Button1" runat="server" Text="FOUND" CssClass="btn1" PostBackUrl="~/found.aspx"/>
            <asp:Button ID="Button2" runat="server" Text="SEEK" CssClass="btn2" PostBackUrl="~/seek.aspx" />
            <asp:Button ID="Button3" runat="server" Text="ABOUT US" CssClass="btn3" PostBackUrl="~/aboutUs.aspx" />
        </div>

        </form>
</body>

</html>
