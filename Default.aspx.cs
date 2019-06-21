using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;

namespace WebAruTest1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "srv-arutest-cl.database.windows.net";
                builder.UserID = "arojas";
                builder.Password = "aruazure.77";
                builder.InitialCatalog = "ARUTEST1";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    //Console.WriteLine("\nQuery data example:");
                    //Console.WriteLine("=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT *  ");
                    sb.Append("FROM [TEST1] T ");
                    //sb.Append("JOIN [SalesLT].[Product] p ");
                    //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                Text1.Value = reader.GetValue(0).ToString();
                                Text2.Value = reader.GetValue(1).ToString();
                                Text3.Value = reader.GetValue(3).ToString();

                            }
                        }
                    }
                }
            }
            finally {

            }
            /*catch (SqlException e)
            {
                //Console.WriteLine(e.ToString());
            }*/

        }
    }
}