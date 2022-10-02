using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace BloggingSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = " select * from [dbo].[blog] order by Bposteddate DESC";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);  
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RepBlogDetails.DataSource = dt;
            RepBlogDetails.DataBind();
            sqlconn.Close();
            

        }
    }
}

///** style="background-image:linear-gradient(#000000,white);"
//style = "background-image:linear-gradient(#000000,white);*/