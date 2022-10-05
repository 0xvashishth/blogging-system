<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Admin-Panel.aspx.cs" Inherits="BloggingSystem.Admin.Admin_Panel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>User Dashboard</h1>
    <hr />
    <center>
    <table border="1" class="table border border-primary">
        <h4>Add Blog</h4>
        <tr class="border border-primary">
            <td class="border border-primary">
                Blog Category
            </td>
            <td class="border border-primary">
                <asp:DropDownList CssClass="form-control" ID="DDLBCat" runat="server">
                    <asp:ListItem>Food</asp:ListItem>
                    <asp:ListItem>Sports</asp:ListItem>
                    <asp:ListItem>Movies</asp:ListItem>

                </asp:DropDownList> </td>
        </tr>

        <tr>
            <td class="border border-primary">Blog Title</td>
            <td class="border border-primary">
                <asp:TextBox CssClass="form-control" ID="TxtBlogTitle" runat="server"></asp:TextBox></td>
        </tr>

         <tr>
            <td class="border border-primary">Blog Desc</td>
            <td class="border border-primary">
                <asp:TextBox CssClass="form-control" ID="TxtBDesc" runat="server" TextMode="Multiline"></asp:TextBox></td>
        </tr>

        <tr>
            <td class="border border-primary">Blog URL(webpage name)</td>
            <td class="border border-primary">
                <asp:TextBox CssClass="form-control" ID="TxtBurl" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td class="border border-primary">Posted Date</td>
            <td class="border border-primary">
                <asp:TextBox CssClass="form-control" ID="LabBPosteddate" runat="server" Text=""></asp:TextBox></td>
        </tr>
    </table>
    <hr/>
        <asp:Button CssClass="form-control btn btn-outline-primary" ID="ButSubmit" runat="server" Text="Save" OnClick="ButSubmit_Click"> </asp:Button>

        </center>
</asp:Content>
