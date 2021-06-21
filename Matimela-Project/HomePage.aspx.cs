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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = "";
            if (Request.Cookies["user"] != null)
            {
                username = Request.Cookies["user"].Value.ToString();
                defaultText.Text=username;
            }



        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            var num = "thabang";
           

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);


            string query = "SELECT COUNT(*) FROM letimela";
           

                SqlCommand sqlcom = new SqlCommand(query, sc);
                //SqlCommand sqlcom1 = new SqlCommand(query2, sc);

                sc.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                //SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
                 num = sqlcom.ExecuteScalar().ToString();
                // sda1.SelectCommand.ExecuteNonQuery();
                sc.Close();

                 numText.Text = num;

        }
    }
}