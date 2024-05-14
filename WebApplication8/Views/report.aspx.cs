using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8.Views
{
	public partial class report : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void search_Click(object sender, EventArgs e)
        {
			string searchKeyword = name.Value;

			// Construct your SQL query based on the search keyword
			string queryString = "SELECT * FROM customer WHERE cust_name LIKE @SearchKeyword";

			// Create a SqlConnection using your connection string
			using (SqlConnection connection = new SqlConnection(@"server=localhost;user id=preeti;database=invoiceMS;password=preeti"))
			{
				// Create a SqlCommand with the SQL query and connection
				using (SqlCommand command = new SqlCommand(queryString, connection))
				{
					// Add a parameter for the search keyword
					command.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

					// Open the connection
					connection.Open();

					// Execute the SQL query and get the results
					using (SqlDataReader reader = command.ExecuteReader())
					{
						// Bind the results to the GridView control
						searchlist.DataSource = reader;
						searchlist.DataBind();
					}
				}
			}

		}
		int key = 0;
		protected void searchlist_SelectedIndexChanged(object sender, EventArgs e)
		{
			name.Value = searchlist.SelectedRow.Cells[2].Text;
			if (name.Value == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(searchlist.SelectedRow.Cells[1].Text);
			}
		}
	}
	
}