<!DOCTYPE html>

<html>

    <head runat="server">
        <title>MATIMELA LOG IN </title>
    </head>

    <body>
        <div">
            <form id="form1" runat="server">
            
            <asp:Label ID="head" runat="server" Text="ACCOUNT LOGIN"></asp:Label>
            <br/>

            <h1>
            <asp:TextBox ID="USERNAME" runat="server" placeholder="username" BorderColor="#99ff99"></asp:TextBox>
            <asp:TextBox ID="PASSWORD" runat="server" placeholder="password" BorderColor="#99ff99" type="password"></asp:TextBox>
            <br />
            </h1>

            <asp:Button ID="login" runat="server" Text="LOG IN" Height="50" Width="200"/>

            <br />
            <asp:HyperLink ID="signLink" runat="server" Text="don't have an account?, SIGN UP" BackColor="#0099ff"></asp:HyperLink>

        </form>
        </div>
     
    </body>

  

</html>