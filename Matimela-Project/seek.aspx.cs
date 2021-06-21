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
    public partial class seek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void seek_Click(object sender, EventArgs e)
        {

            string types = type.SelectedItem.Text;
            string brand = brands.Text;
            string color = colors.Text;
            string location = locations.Text;
            string additional = adds.Text;
            string zone = chose.SelectedItem.Text;

            HttpCookie Cookie = new HttpCookie("brand");
            Cookie.Value = brands.Text;
            Cookie.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(Cookie);


            //string message = types + "\t" + brand+ "\t" + color+ "\t" + location + "\t" + additional;

            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + message + "...');", true);

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);



           string query = "INSERT INTO letimela(type,brand,color,location,zone,additional) VALUES('" + types + "','" + brand + "','" +color + "','" +location + "','"+zone + "','" +additional+ "');";
            string query1 = "INSERT INTO zone(type,brand,zone) VALUES('" + types + "','" + brand + "','"+zone+ "');";
            string query2 = "INSERT INTO location(type,brand,zone,location) VALUES('" + types + "','" + brand + "','" + zone + "','" +location+ "');";
            SqlCommand sqlcom = new SqlCommand(query, sc);
            SqlCommand sqlcom1 = new SqlCommand(query1, sc);
            SqlCommand sqlcom2 = new SqlCommand(query2, sc);
            sc.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom2);
            sda.SelectCommand.ExecuteNonQuery();
            sda1.SelectCommand.ExecuteNonQuery();
            sda2.SelectCommand.ExecuteNonQuery();
            sc.Close();


            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "PROCESS OF REPORTING THE LOST ANIMAL IS SUCCESSFUL" + "...');", true);
            string pageurl = "seekResults.aspx";
           // Response.Write("<script> window.open('" + pageurl + "','_blank'); </script>");
            Response.Redirect(pageurl);
        }
    }
}