<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="BloggingSystem.Blog.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>This is Blog No: <%= id %></h3>
    <asp:Repeater ID="RepBlogDetails" runat="server" >
        <ItemTemplate>
            <h4><b style="color: darkorange"><%#Eval("Btitle") %></b></h4>
            <p class="card-text">
                <%#Eval("BDesc") %>
            </p>
            <a href="/Blog/Blog.aspx?id=<%#Eval("Bid") %>">Read the Complete Article....</a>
            <div class="card-footer text-muted">
                Posted On : <%#Eval("Bposteddate","{0: MMMM dd , yyyy}") %>
                <a href="/blog/blog.aspx"><%#Eval("Bcategory") %></a>
            </div>
            <hr />
        </ItemTemplate>
    </asp:Repeater>
    <% if (token_check1 == "")
        { }
        else
        { %>
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap">Update Blog</button>
&nbsp;<asp:Button CssClass="btn btn-primary" ID="Button2" runat="server" Text="Delete" OnClick="btnDelete_Click"/> 
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Update Blog</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <form>
          <div class="form-group">
            <label for="blogTitle" class="col-form-label">Blog Name:</label>
            <input runat="server" type="text" class="form-control" ID="blogTitle" />
          </div>
          <div class="form-group">
            <label for="blogDesc" class="col-form-label">Description:</label>
            <textarea runat="server" class="form-control" ID="blogDesc"></textarea>
          </div>
            <div class="form-group">
            <label for="blogurl" class="col-form-label">Url:</label>
            <textarea runat="server" class="form-control" ID="blogurl"></textarea>
          </div>
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        
      <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Update" OnClick="btnUpdate_Click" />
      </div>
    </div>
  </div>
</div>
    <%} %>
</asp:Content>
