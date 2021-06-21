using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Windows;

namespace Matimela_Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // string redirect = "<script>window.open('HomePage.aspx');</script>";
            //Response.Write(redirect);

        }

        protected void login_Click(object sendder, EventArgs e)
        {
            string names = namesLog.Text;
            string password = passwordLog.Text;


            if (names.Equals("") && password.Equals(""))
            {

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "PLEASE INPUT DATA IN ALL REQUIRED FIELDS" + "...');", true);
            }
            else {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                SqlConnection sc = new SqlConnection(mainconn);


                string query = "SELECT username FROM login WHERE username='" + names + "';";
                string query1 = "SELECT password FROM login WHERE username='" + names + "';";
                try
                {

                    SqlCommand sqlcom = new SqlCommand(query1, sc);
                    //SqlCommand sqlcom1 = new SqlCommand(query2, sc);

                    sc.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                    //SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
                    string check = sqlcom.ExecuteScalar().ToString();
                    // sda1.SelectCommand.ExecuteNonQuery();
                    sc.Close();

                    if (password.Equals(check))
                    {

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(' WELCOME  " + names + "...');", true);
                        //ClientScript.RegisterClientScriptBlock(Page.GetType(), "script", "window.close();", true);
                        string pageurl = "HomePage.aspx";
                        Response.Redirect(pageurl);

                        HttpCookie Cookie = new HttpCookie("user");
                        Cookie.Value = names;
                        Cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(Cookie);
                    }
                }
                catch (Exception)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(' User does not exist  " + "...');", true);

                }


            }




        }
    }
}