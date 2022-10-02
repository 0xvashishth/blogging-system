using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BloggingSystem.Admin
{
    public partial class Admin_Panel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/Login/login.aspx");
            }

            if (!Page.IsPostBack)
            {
                LabBPosteddate.Text = DateTime.Now.ToString();
                DDLBCat.Items.Insert(0, "-- Select Category --");
            }
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
           
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[blog] (Btitle,Bcategory,BDesc,BUrl,Bposteddate) values(@Btitle,@Bcategory,@BDesc,@BUrl,@Bposteddate)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@Btitle", TxtBlogTitle.Text);
                sqlcomm.Parameters.AddWithValue("@Bcategory", DDLBCat.SelectedItem.Text.ToString());
                sqlcomm.Parameters.AddWithValue("@BDesc", TxtBDesc.Text);
                sqlcomm.Parameters.AddWithValue("@BUrl", TxtBurl.Text);
                sqlcomm.Parameters.AddWithValue("@Bposteddate", LabBPosteddate.Text);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                Response.Redirect("~/Admin/Admin-Panel.aspx");
            
            
        }
    }
}