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

namespace Matimela_Project
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected void Register_Click(object sender, EventArgs e)
        {
         
            string name = Page.Request.Form["names"];
            string id = Page.Request.Form["id-number"];
            string location = Page.Request.Form["location"];
            string zone = Page.Request.Form["zone"];
            string brand = Page.Request.Form["brand"];
            string password = Page.Request.Form["password"];



            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);


            string query = "INSERT INTO farmers(list,names,zone,brand,location) VALUES('1 " + "','" + name + "','" + zone + "','"+brand+ "','"+location+ "');";
            
            SqlCommand sqlcom = new SqlCommand(query, sc);
            sc.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            sda.SelectCommand.ExecuteNonQuery();
            sc.Close();


            // SqlConnection sc = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Myconn"].ToString());

            // //string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            //// SqlConnection sc = new SqlConnection(mainconn);

            // try
            // {
            //     string query = "INSERT INTO login(username,password) VALUES('"+name+"','"+password+"');";
            //     // SqlCommand sqlcom = new SqlCommand(query, sc);
            //     SqlDataAdapter da = new SqlDataAdapter(query, sc);
            //     sc.Open();
            //     da.SelectCommand.ExecuteNonQuery();

            //     //SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            //    // sda.SelectCommand.ExecuteNonQuery();
            //     sc.Close();
            // }
            // catch (Exception)
            // {
            //     sc.Close();
            // }

            // SqlCommand cmd = new SqlCommand("INSERT INTO farmers (names,zone, brand,location) VALUES (@name, @zone, @brand, @location)");
            // SqlCommand cmd1 = new SqlCommand("INSERT INTO login(username,password) VALUES(@username, @password)");

            // cmd.Connection = sc;
            // cmd1.Connection = sc;
            // sc.Open();
            // cmd.Parameters.AddWithValue("@name", name);
            // cmd.Parameters.AddWithValue("@zone", zone);
            //cmd.Parameters.AddWithValue("@brand", brand);
            // cmd.Parameters.AddWithValue("@location", location);          
            // cmd.ExecuteNonQuery();

            // cmd1.Parameters.AddWithValue("@username", name);
            // cmd1.Parameters.AddWithValue("@password", password);
            // cmd1.ExecuteNonQuery();
            // sc.Close();

        }
    }
}