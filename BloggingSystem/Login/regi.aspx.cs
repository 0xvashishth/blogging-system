using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Text;

namespace BloggingSystem
{
    public partial class regi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into Regi (Name,Email_Id,Password,Confirm_Password) values(@Name,@Email_Id,@Password,@Confirm_Password)";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@Name", txtUsername.Text);
            sqlcomm.Parameters.AddWithValue("@Email_Id", txtEmail.Text);
            sqlcomm.Parameters.AddWithValue("@Password", txtPassword.Text);
            sqlcomm.Parameters.AddWithValue("@Confirm_Password", txtConfirmPassword.Text);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();

            string to = txtEmail.Text; //To address    
            string from = ""; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Your reegistration in sample blog is confirmed!";
            message.Subject = "Registration is confirmed";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("", "");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            Response.Redirect("~/Admin/Admin-Panel.aspx");
        }
    }
}