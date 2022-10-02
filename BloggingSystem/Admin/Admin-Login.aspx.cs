using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloggingSystem.Admin
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void ButLogin_Click(object sender, EventArgs e)
        {
            if(TxtAdminLogin.Text=="Admin" && TxtPassword.Text=="abcd")
            {
                Response.Redirect("~/Admin/Admin-Panel.aspx");
            }
            else
            {
                Response.Redirect("~/Admin/Admin-Login.aspx");

            }   
        }
    }
}