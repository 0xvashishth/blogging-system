using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace BloggingSystem.Login
{
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            try
            {

                string uid = txtUsername.Text;
                string pass = txtPassword.Text;
                sqlconn.Open();
                string query = "select * from Regi where Name='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Response.Redirect("~/Admin/Admin-Panel.aspx");
                }
                else
                {
                    Label4.Text = "UserId & Password Is not correct Try again..!!";

                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
