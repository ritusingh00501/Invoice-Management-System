using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8.Views
{
	public partial class billing : System.Web.UI.Page
	{
		Models.functions con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
			if (!IsPostBack)
			{
				ShowInvoice();
				DataTable dt = new DataTable();
				dt.Columns.AddRange(new DataColumn[7]
					{
						new DataColumn("ID"),
						new DataColumn("CustomerID"),
						new DataColumn("Date"),
						new DataColumn("Item"),
						new DataColumn("Price"),
						new DataColumn("Quantity"),
						new DataColumn("Total")
				}
					);
				ViewState["Bill"] = dt;
				this.BindGrid();
			}

		}
		protected void BindGrid()
		{
			BillList.DataSource = ViewState["Bill"];
			BillList.DataBind();
		}
		private void ShowInvoice()
		{
			string Query = "select in_id as Code,cust_name as CutomerID,date as Date,item as Item,qty as Quantity,price as Price from invoice";
			InvoiceList.DataSource = con.GetData(Query);
			InvoiceList.DataBind();
		}
		int key = 0;
		protected void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cname.Value = InvoiceList.SelectedRow.Cells[2].Text;
			//custemail.Value = InvoiceList.SelectedRow.Cells[3].Text;
			date.Value = InvoiceList.SelectedRow.Cells[3].Text;
			item.Value = InvoiceList.SelectedRow.Cells[4].Text;
			qty.Value = InvoiceList.SelectedRow.Cells[5].Text;
			price.Value = InvoiceList.SelectedRow.Cells[6].Text;
			if (cname.Value == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(InvoiceList.SelectedRow.Cells[1].Text);
			}
		}
		private void insertBill()
		{
			try
			{
				if (cname.Value == "" || date.Value == "" || item.Value == "" || qty.Value == "" || price.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string Cname = cname.Value.ToString();
					//string Cemail = custemail.Value;
					string Date = date.Value;
					string Item = item.Value;
					int Qty = Convert.ToInt32(qty.Value);
					int Price = Convert.ToInt32(price.Value);

					string Query = "Insert into invoice values({0},'{1}','{2}',{3},{4},{5})";
					Query = string.Format(Query, Cname, Date, Item, Qty, Price,Amount);
					con.SetData(Query);
					ShowInvoice();
					ErrMsg.Text = "Invoice Added!!";
					cname.Value = "";
					//custemail.Value = "";
					date.Value = "";
					item.Value = "";
					qty.Value = "";
					price.Value = "";
				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}
		}

		int grdtotal;
		int Amount;
		protected void Addbill_Click(object sender, EventArgs e)
		{
			int total = Convert.ToInt32(qty.Value) * Convert.ToInt32(price.Value);
			DataTable dt = (DataTable)ViewState["Bill"];
			dt.Rows.Add(BillList.Rows.Count + 1,
				cname.Value.Trim(),
				date.Value.Trim(),
				item.Value.Trim(),
				price.Value.Trim(),
				qty.Value.Trim(),
				total 
				);
			ViewState["Bill"] = dt;
			this.BindGrid();

			//int grdtotal = 0;
			for(int i=0;i<BillList.Rows.Count-1;i++)
			{
				grdtotal = grdtotal + Convert.ToInt32(BillList.Rows[i].Cells[7].Text);
			}
			Amount = grdtotal;
			Grdtotaltb.Text = "Rs " + Amount;
			cname.Value = "";
			date.Value = "";
			item.Value = "";
			price.Value = "";
			qty.Value = "";
			//grdtotal = 0;
		}

		protected void print_Click(object sender, EventArgs e)
		{
			insertBill();
		}
	}
}