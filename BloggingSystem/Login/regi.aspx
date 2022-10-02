<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regi.aspx.cs" Inherits="BloggingSystem.regi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
<script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
<link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css'
    media="screen"/>
</head>
<body>
    <center>
   <form id="form1" runat="server">
    <div style="max-width: 400px;">
        <h2 class="form-signin-heading">Registration</h2>
        <asp:Label Text="Username" runat="server" AssociatedControlID="txtUsername"/>
        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username" required="required"/>
        <br/>
        <asp:Label Text="Password" runat="server" AssociatedControlID="txtPassword"/>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Password must contain: Minimum 8 characters at-least 1 Alphabet and 1 Number"
            CssClass="form-control" placeholder="Enter Password" required="required" pattern="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"/>
        <br/>
        <asp:Label Text="Confirm Password" runat="server" AssociatedControlID="txtConfirmPassword"/>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Confirm Password" required="required"/>
        <br/>
        <asp:Label Text="Email" runat="server" AssociatedControlID="txtEmail"/>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" placeholder="Enter Email" required="required"/>
        <hr/>
        <asp:Button ID="btnSignup" runat="server" Text="Sign up" CssClass="btn btn-primary" OnClick="btnSignup_Click"/>
    </div>
</form>
        </center>
<script type="text/javascript">
    window.onload = function () {
        var txtPassword = document.getElementById("<%=txtPassword.ClientID%>");
        var txtConfirmPassword = document.getElementById("<%=txtConfirmPassword.ClientID%>");
        txtPassword.onchange = ConfirmPassword;
        txtConfirmPassword.onkeyup = ConfirmPassword;
        function ConfirmPassword() {
            txtConfirmPassword.setCustomValidity("");
            if (txtPassword.value != txtConfirmPassword.value) {
                txtConfirmPassword.setCustomValidity("Passwords do not match.");
            }
        }
    }
</script>
</body>
</html>
