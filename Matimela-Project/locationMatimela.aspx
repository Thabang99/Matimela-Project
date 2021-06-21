<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="locationMatimela.aspx.cs" Inherits="Matimela_Project.locationMatimela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MATIMELA IN AREA</title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">

            <p>
                SELECT ZONE
            </p>

                <asp:DropDownList id="chose" runat="server" AutoPostBack="true" AppendDataBoundItems="true" CssClass="input1">
                    <asp:ListItem Text="SELECT ZONE" Value="0"></asp:ListItem>
                    <asp:ListItem Text="C1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="C2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="C3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="C4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="C5" Value="5"></asp:ListItem>
                </asp:DropDownList>


                <asp:TextBox runat="server" placeholder="enter location" ID="locations"></asp:TextBox><br/>
           <br/>

            <asp:Button runat="server" Text="CHECK" OnClick="check_Click" />

            <asp:Panel ID="Panel1" runat="server"></asp:Panel>

        </div>
    </form>
</body>
</html>
