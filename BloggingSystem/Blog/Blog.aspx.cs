using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace BloggingSystem.Blog
{
    public partial class Blog : System.Web.UI.Page
    {
        public string token_check = "";
        public string title, desc, url, id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {

            }
            else
            {
                var Label1 = Session["id"].ToString();
                token_check = Label1;
            }

            id = Request.QueryString["id"];
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = " select * from blog where Bid="+id;
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            using (SqlDataReader reader = sqlcomm.ExecuteReader())
            {
                while (reader.Read())
                {
                    title = (string)reader[1];
                    desc = (string)reader[3];
                    url = (string)reader[4];
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RepBlogDetails.DataSource = dt;
            RepBlogDetails.DataBind();
            sqlconn.Close();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string titleup = blogTitle.Value;
                string descup = blogDesc.Value;
                string urlup = blogurl.Value;
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                /*SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "update blog set Btitle=" + titleup + ", BDesc=" + descup + ", BUrl=" + urlup + " where Bid="+id;
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Close();*/
                string url = "/Blog/Blog.aspx?id=" + id;

                SqlConnection conn;
                SqlCommand comm;
                conn = new SqlConnection(mainconn);
                conn.Open();
                comm = new SqlCommand("update blog set Btitle= '"+blogTitle.Value+"', BDesc= '"+blogDesc.Value+"' , BUrl=' "+blogurl.Value+"' where Bid ='"+id+"' ", conn);  
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        Response.Write("Not Updated");
                    }
                    finally
                    {
                        conn.Close();
                        Response.Redirect(url);
                    }

            }
            catch (Exception ex)
            {
                Response.Write("Error : " + ex.Message);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string titleup = blogTitle.Value;
                string descup = blogDesc.Value;
                string urlup = blogurl.Value;
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                /*SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "update blog set Btitle=" + titleup + ", BDesc=" + descup + ", BUrl=" + urlup + " where Bid="+id;
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlconn.Close();*/

                SqlConnection conn;
                SqlCommand comm;
                conn = new SqlConnection(mainconn);
                conn.Open();
                comm = new SqlCommand("delete from blog where Bid ='"+id+"' ", conn);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    Response.Write("Not Deleted");
                }
                finally
                {
                    conn.Close();
                    Response.Redirect("/");
                }

            }
            catch (Exception ex)
            {
                Response.Write("Error : " + ex.Message);
            }
        }
    }
}