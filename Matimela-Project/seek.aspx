<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seek.aspx.cs" Inherits="Matimela_Project.seek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seek Letimela</title>
     <link rel="stylesheet" type="text/css" href="css/seek.css">
</head>
<body>
    <form id="form1" runat="server">
               <div class="container">
            <asp:Label runat="server" Text="LOOK LETIMELA ANIMAL LOST" CssClass="topic"></asp:Label>

            <div class="inputs">
                <asp:DropDownList ID="type" runat="server" AutoPostBack="true" AppendDataBoundItems="true" CssClass="input1">
                    <asp:ListItem Text="--SELECT--" Value="0"></asp:ListItem>
                    <asp:ListItem Text="COW" Value="1"></asp:ListItem>
                    <asp:ListItem Text="DONKEY" Value="2"></asp:ListItem>
                    <asp:ListItem Text="GOAT" Value="3"></asp:ListItem>
                    <asp:ListItem Text="SHEEP" Value="4"></asp:ListItem>
                    <asp:ListItem Text="HORSE" Value="5"></asp:ListItem>
                </asp:DropDownList>
                   
                   <asp:TextBox ID="brands" runat="server" placeholder="BRAND" CssClass="input2"></asp:TextBox>
                   <asp:TextBox ID="colors" runat="server" placeholder="COLOUR" CssClass="input3"></asp:TextBox>
                   <asp:TextBox id="locations" runat="server" placeholder="LOCATION" CssClass="input4"></asp:TextBox>
                   <asp:TextBox ID="adds" runat="server" placeholder="ADDITIONAL INFO" CssClass="input5"></asp:TextBox>

                  <asp:DropDownList id="chose" runat="server" AutoPostBack="true" AppendDataBoundItems="true" CssClass="input1">
                    <asp:ListItem Text="SELECT ZONE" Value="0"></asp:ListItem>
                    <asp:ListItem Text="C1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="C2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="C3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="C4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="C5" Value="5"></asp:ListItem>
                </asp:DropDownList>
            </div>
            
             <asp:Button runat="server" Text="SUBMIT" CssClass="submit" onClick="seek_Click"/>
              
        </div>
    </form>
</body>
</html>
