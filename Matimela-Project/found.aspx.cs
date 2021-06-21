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
    public partial class found : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string types = type.SelectedItem.Text;
            string brands = brand.Text;
            string colors = color.Text;
            string locations = location.Text;
            string additional = add.Text;
            string zone = chose.SelectedItem.Text;


            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);

            string query = "INSERT INTO foundAnimal(type,brand,color,location,zone,additional) VALUES('" + types + "','" + brands + "','" + colors + "','" + locations + "','" + zone + "','" + additional + "');";
            SqlCommand sqlcom = new SqlCommand(query, sc);
            sc.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
          
            sda.SelectCommand.ExecuteNonQuery();
       
            sc.Close();

        }
    }
}