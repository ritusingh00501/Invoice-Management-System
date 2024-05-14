using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication8.Views
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		Models.functions con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
			if(!IsPostBack)
			{
				ShowInvoice();
				GetCustname();
			}
			
		}
		private void ShowInvoice()
		{
			string Query = "select * from invoice";
			InvoiceList.DataSource = con.GetData(Query);
			InvoiceList.DataBind();
		}
		private void GetCustname()
		{
			string Query = "select * from customer";
			cust_name.DataTextField = con.GetData(Query).Columns["cust_name"].ToString();
			cust_name.DataValueField = con.GetData(Query).Columns["cust_id"].ToString();
			cust_name.DataSource = con.GetData(Query);
			cust_name.DataBind();
		}
		
		protected void add_Click(object sender, EventArgs e)
        {
			try
			{
				if (cust_name.SelectedIndex == -1 || custemail.Value == "" || date.Value == "" || item.Value == "" || quantity.Value == "" || price.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string Cname = cust_name.SelectedValue.ToString();
					string Cemail = custemail.Value;
					string Date = date.Value;
					string Item =item.Value;
					int Qty = Convert.ToInt32(quantity.Value);
					int Price = Convert.ToInt32(price.Value);

					string Query = "Insert into invoice values({0},'{1}','{2}','{3}',{4},{5})";
					Query = string.Format(Query, Cname, Cemail, Date, Item, Qty, Price);
					con.SetData(Query);
					ShowInvoice();
					ErrMsg.Text = "Invoice Added!!";
					cust_name.SelectedIndex = -1;
					custemail.Value = "";
					date.Value = "";
					item.Value = "";
					quantity.Value = "";
					price.Value = "";
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
			cust_name.SelectedValue = InvoiceList.SelectedRow.Cells[2].Text;
			custemail.Value = InvoiceList.SelectedRow.Cells[3].Text;
			date.Value = InvoiceList.SelectedRow.Cells[4].Text;
			item.Value = InvoiceList.SelectedRow.Cells[5].Text;
			quantity.Value = InvoiceList.SelectedRow.Cells[6].Text;
			price.Value = InvoiceList.SelectedRow.Cells[7].Text;
			if (cust_name.SelectedIndex == -1)
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(InvoiceList.SelectedRow.Cells[1].Text);
			}
		}
		protected void update_Click(object sender, EventArgs e)
		{
			try
			{
				if (cust_name.SelectedIndex == -1 || custemail.Value == "" || date.Value == "" || item.Value == "" || quantity.Value == "" || price.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string Cname = cust_name.SelectedValue.ToString();
					string Cemail = custemail.Value;
					string Date = date.Value;
					string Item = item.Value;
					int Qty = Convert.ToInt32(quantity.Value);
					int Price = Convert.ToInt32(price.Value);

					string Query = "update invoice set cust_name={0},email='{1}',date='{2}',item='{3}',qty={4},price={5} where in_id={6}";
					Query = string.Format(Query, Cname, Cemail, Date, Item, Qty, Price, InvoiceList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowInvoice();
					ErrMsg.Text = "Invoice Updated!!";
					cust_name.SelectedIndex = -1;
					custemail.Value = "";
					date.Value = "";
					item.Value = "";
					quantity.Value = "";
					price.Value = "";
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
				if (cust_name.SelectedIndex == -1 || custemail.Value == "" || date.Value == "" || item.Value == "" || quantity.Value == "" || price.Value == "")
				{
					ErrMsg.Text = "Select an Invoice!!";
				}
				else
				{
					string Cname = cust_name.SelectedValue.ToString();
					string Cemail = custemail.Value;
					string Date = date.Value;
					string Item = item.Value;
					int Qty = Convert.ToInt32(quantity.Value);
					int Price = Convert.ToInt32(price.Value);

					string Query = "delete from invoice where in_id={0}";
					Query = string.Format(Query, InvoiceList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowInvoice();
					ErrMsg.Text = "Invoice Deleted!!";
					cust_name.SelectedIndex = -1;
					custemail.Value = "";
					date.Value = "";
					item.Value = "";
					quantity.Value = "";
					price.Value = "";
				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}
		}

    }
}