<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Matimela_Project.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>REGISTRATION</title>

     <link rel="stylesheet" type="text/css" href="css/register.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">
            <asp:Label CssClass="topic" ID="Label1" runat="server" Text="ACCOUNT REGISTRATION"></asp:Label><br/>
            <asp:TextBox CssClass="input1" ID="names" runat="server" placeholder="Full Names"></asp:TextBox>
            <asp:TextBox CssClass="input2" ID="idNo" runat="server" placeholder="Identity Number"></asp:TextBox>
            <br/>
            <br/>
            <asp:TextBox CssClass="input3" ID="locations" runat="server" placeholder="Farm Location"></asp:TextBox>
            <asp:TextBox CssClass="input4" ID="zones" runat="server" placeholder="Farm Zone"></asp:TextBox>
            <br />
            <br/>
            <asp:TextBox CssClass="input5" ID="brands" runat="server" placeholder="Brand (Letswao)"></asp:TextBox>
             <asp:TextBox CssClass="input6" ID="passwords" runat="server" placeholder="Password"></asp:TextBox>
            <br/>
            <br/>
            <asp:Button CssClass="btn" ID="register" runat="server" Text="REGISTER"  OnClick="register_Click"/>
             <br/>
            <br/>
             <br/>
            <br/>

            <asp:HyperLink CssClass="link" ID="link" runat="server" Text="PROCEED TO LOGIN" NavigateUrl="~/Login.aspx"></asp:HyperLink>
            </div>

          
        </div>
    </form>
</body>
</html>
