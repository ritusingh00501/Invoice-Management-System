using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8.Views
{

	public partial class product : System.Web.UI.Page
	{
		Models.functions con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
			ShowProduct();
		}
		private void ShowProduct()
		{
			string Query = "select * from product";
			ProductList.DataSource = con.GetData(Query);
			ProductList.DataBind();
		}
		/*int key = 0;
		protected void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
			pname.Value = ProductList.SelectedRow.Cells[2].Text;
			pd.Value = ProductList.SelectedRow.Cells[3].Text;
			stock.Value = ProductList.SelectedRow.Cells[4].Text;
			if (pname.Value == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
			}

		}*/

		protected void add_Click(object sender, EventArgs e)
		{
			try
			{
				if (pname.Value == "" || pd.Value == "" || stock.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string Pname = pname.Value;
					string Pd = pd.Value;
					string Stock = stock.Value;
					string Query = "Insert into product values('{0}','{1}','{2}')";
					Query = string.Format(Query, Pname, Pd, Stock);
					con.SetData(Query);
					ShowProduct();
					ErrMsg.Text = "Product Added!!";
					pname.Value = "";
					pd.Value = "";
					stock.Value = "";
					
				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}
		}
		protected void update_Click(object sender, EventArgs e)
		{
			try
			{
				if (pname.Value == "" || pd.Value == "" || stock.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string Pname = pname.Value;
					string Pd = pd.Value;
					string Stock = stock.Value;
					string Query = "update product set name='{0}',type='{1}',qty='{2}' where prod_id={3}";
					Query = string.Format(Query,Pname,Pd,Stock, ProductList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowProduct();
					ErrMsg.Text = "Updated Successfully!!";
					pname.Value = "";
					pd.Value = "";
					stock.Value = "";

				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}

		}

		protected void delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (pname.Value == "" || pd.Value == "" || stock.Value == "")
				{
					ErrMsg.Text = "Select Data!!";
				}
				else
				{
					string Pname = pname.Value;
					string Pd = pd.Value;
					string Stock = stock.Value;
					string Query = "delete from product where prod_id = {0}";
					Query = string.Format(Query, ProductList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowProduct();
					ErrMsg.Text = "Deleted Successfully!!";
					pname.Value = "";
					pd.Value = "";
					stock.Value = "";

				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}
		}
		int key = 0;
		protected void InvoiceList_SelectedIndexChanged(object sender, EventArgs e)
		{
			pname.Value = ProductList.SelectedRow.Cells[2].Text;
			pd.Value = ProductList.SelectedRow.Cells[3].Text;
			stock.Value = ProductList.SelectedRow.Cells[4].Text;
			if (pname.Value == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(ProductList.SelectedRow.Cells[1].Text);
			}
		}
	}
}