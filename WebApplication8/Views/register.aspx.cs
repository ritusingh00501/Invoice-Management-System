using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8.Views
{
	
	public partial class register : System.Web.UI.Page
	{
		Models.functions con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
		}
		public static string Uname = "";
		public static int user;
		protected void registerbutton_Click(object sender, EventArgs e)
		{
			if (userid.Value == "" || psw.Value == "")
			{
				ErrMsg.Text = "Name or password can't be blank!!";
			}
			else if (psw.MaxLength < 6)
			{
				ErrMsg.Text = "Password must be at least 6 characters long!!";
			}
			else
			{
				string Query = "insert into admin values('{0}','{1}')";
				Query = string.Format(Query, userid.Value, psw.Value);
				DataTable dt = con.GetData(Query);
				if (dt.Rows.Count == 0)
				{
					Response.Redirect("login.aspx");
				}
				else
				{
					Uname = userid.Value;
					user = Convert.ToInt32(dt.Rows[0][0].ToString());

				}
			}
		}
	}
}