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
    public partial class register : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into Registers (Name,Email_Id,Password) values(@Name,@Email_Id,@Password)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Name", nametxt.Text);
            sqlcomm.Parameters.AddWithValue("@Email_Id", emailtxt.Text);
            sqlcomm.Parameters.AddWithValue("@Password", passtxt.Text);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            Response.Redirect("~/Admin/Admin-Panel.aspx");


        }
    }
}