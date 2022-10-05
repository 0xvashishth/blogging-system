using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloggingSystem.Sports
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = " select * from [dbo].[blog] where Bcategory='Sports'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                Console.WriteLine(dt);
                sda.Fill(dt);
                RepBlogDetails.DataSource = dt;
                RepBlogDetails.DataBind();
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error : " + ex.Message);
            }
        }
    }
}