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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string fullnames = names.Text;
            string id = idNo.Text;
            string location = locations.Text;
            string zone = zones.Text;
            string letswao = brands.Text;
            string password = passwords.Text;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);


            string query = "INSERT INTO login(username,password) VALUES('" + fullnames + "','" + password + "');";
            string query2 = "INSERT INTO farmer(names,id,location,zone,brand) VALUES('" + fullnames + "','" +id+ "','" + location + "','" + zone + "','" + letswao + "');";

            SqlCommand sqlcom = new SqlCommand(query, sc);
            SqlCommand sqlcom1 = new SqlCommand(query2, sc);

            sc.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
            sda.SelectCommand.ExecuteNonQuery();
            sda1.SelectCommand.ExecuteNonQuery();
            sc.Close();

        }
    }
}