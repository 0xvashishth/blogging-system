<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="BloggingSystem.Login.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Register Page"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email-Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="passtxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click" />
    </form>
        </center>
</body>
</html>
