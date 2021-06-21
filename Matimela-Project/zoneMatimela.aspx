<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zoneMatimela.aspx.cs" Inherits="Matimela_Project.zoneMatimela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MATIMELA IN ZONES</title>
     <link rel="stylesheet" type="text/css" href="css/zone.css">
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

            <asp:Button runat="server" Text="CHECK" OnClick="check_Click" />

            <asp:Panel ID="Panel1" runat="server"></asp:Panel>

        </div>
    </form>
</body>
</html>
