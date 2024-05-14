using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
	public class functions
	{
		internal object Columns;
		private SqlConnection con;
		private SqlCommand cmd;
		private DataTable dt;
		private SqlDataAdapter sda;
		private string constr;
		public functions()
		{
			constr = @"server=localhost;user id=preeti;database=invoiceMS;password=preeti";
			con = new SqlConnection(constr);
			cmd = new SqlCommand();
			cmd.Connection = con;
	
		}
		public DataTable GetData(string Query)
		{
			dt = new DataTable();
			sda = new SqlDataAdapter(Query, constr);
			sda.Fill(dt);
			return dt;
		}
		public int SetData(string Query)
		{
			int cnt = 0;
			if(con.State==ConnectionState.Closed)
			{
				con.Open();
			}
			cmd.CommandText = Query;
			cnt = cmd.ExecuteNonQuery();
			con.Close();
			return cnt;

		}

	}
}