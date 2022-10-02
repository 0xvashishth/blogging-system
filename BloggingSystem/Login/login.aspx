<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="BloggingSystem.Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <b style="color:orangered"<h1><title>Login page</title></h1></b>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</head>
<body>
     <center>
   <form id="form1" runat="server">
    <div style="max-width: 400px;">
        <h2 class="form-login-heading">Login</h2>
        <asp:Label Text="Username" runat="server" AssociatedControlID="txtUsername"/>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username" required="required"/>
        <br/>
        <asp:Label Text="Password" runat="server" AssociatedControlID="txtPassword"/>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Password must contain: Minimum 8 characters at-least 1 Alphabet and 1 Number"
            CssClass="form-control" placeholder="Enter Password" required="required" />
        <br/>
        
        
        <asp:Button ID="btnSignup" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnSignup_Click"/>
        <br />
        <br />
        <b style="color: red"><asp:Label ID="Label4" runat="server"></asp:Label></b>
    </div>
</form>
        </center>
</html>
