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
    public partial class locationMatimela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void check_Click(object sender, EventArgs e)
        {
            string zone = chose.SelectedItem.Text;
            string location = locations.Text;

            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sc = new SqlConnection(mainconn);


            //SELECT* FROM location WHERE zone = 'C4' AND location = 'Serowe'
            string query = "SELECT * FROM location WHERE zone='" + zone + "' AND location = '"+location + "';";
            SqlCommand sqlcom = new SqlCommand(query, sc);
            sc.Open();

            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<table border=1>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append("<th>");
                sb.Append(dc.ColumnName.ToUpper());
                sb.Append("</th>");
            }

            sb.Append("</tr>");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");

                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<td>");
                    sb.Append(dr[dc.ColumnName].ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");

            }

            sb.Append("</table>");
            sb.Append("</center>");

            Panel1.Controls.Add(new Label { Text = sb.ToString() });
        }
    }
}