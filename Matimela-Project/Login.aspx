<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Matimela_Project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOG IN</title>

    <link rel="stylesheet" type="text/css" href="css/login.css">
</head>
<body>
    <form id="form1" runat="server">


        <div class="mainForm">

              
            <asp:Image CssClass="pic" ID="Image1" runat="server" ImageUrl="~/images/matimela1.jpg" />

       

        <div class="form">
            <asp:Label CssClass="topic" ID="Label1" runat="server" Text="ACCOUNT LOGIN"></asp:Label><br/><br/>
            <asp:TextBox CssClass="input"  ID="namesLog" runat="server" placeholder="Full Names"></asp:TextBox>
            <br/>
            <asp:TextBox CssClass="input" ID="passwordLog" runat="server" placeholder="Password"></asp:TextBox>
            <br/>
            <br/>

            <asp:Button CssClass="btn" runat="server" ID="login1" Text="SIGN-IN" onClick="login_Click"/>

            <br/>
            <br/>
            <br/>
            <br/>
            <asp:HyperLink CssClass="link" runat="server" Text="REGISTER ACCOUNT" NavigateUrl="~/Register.aspx"></asp:HyperLink>


        </div>

        </div>

      
    </form>
</body>
</html>
