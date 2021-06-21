<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="seekResults.aspx.cs" Inherits="Matimela_Project.seekResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RESULTS</title>

     <link rel="stylesheet" type="text/css" href="css/seekResults.css">
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label runat="server" Text="RESULTS"></asp:Label><br/>
            <p>
                All animals that matches your specified brand...
            </p>

            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>
