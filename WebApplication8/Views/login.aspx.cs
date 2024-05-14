using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8.Views
{
	public partial class login : System.Web.UI.Page
	{
		Models.functions con;
		Models.functions cmd;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
		}

		protected void submitbutton_Click(object sender, EventArgs e)
		{
			string connectionString = @"server=localhost;user id=preeti;database=invoiceMS;password=preeti";
			string username = user_id.Text;
			string pass = password.Text;
			/*if (username == "" || pass == "")
			{
				// Display error message if username or password is empty
				Response.Write("<script>alert('Username and password are required.');</script>");
				return;
			}
			else if(pass.Length<6)
			{
				Response.Write("<script>alert('Password must be at least 6 characters long.');</script>");
				return;
			}
			*/
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT COUNT(*) FROM admin WHERE user_id = @user_id AND password = @password";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					
					command.Parameters.AddWithValue("@user_id", username);
					command.Parameters.AddWithValue("@password", pass);
					int count = (int)command.ExecuteScalar();
					if (count > 0)
					{
						// Redirect to the home page or any other authenticated page
						Response.Redirect("WebForm1.aspx");
					}
					else
					{
						// Invalid credentials, show error message
						//Response.Write("<script>alert(Invalid username or password!);</script>");
						string script = "alert('Invalid username or password!');";
						ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
					}

				}
			}
		}
	}
}
    
