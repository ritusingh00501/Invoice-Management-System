using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8.Views
{
	public partial class customer : System.Web.UI.Page
	{
		Models.functions con;
		protected void Page_Load(object sender, EventArgs e)
		{
			con = new Models.functions();
			ShowCustomer();
		}
		private void ShowCustomer()
		{
			string Query = "select * from customer";
			CustomerList.DataSource = con.GetData(Query);
			CustomerList.DataBind();
		}

        protected void add_Click(object sender, EventArgs e)
        {
			try
			{
				if(cname.Value=="" || gender.SelectedIndex == -1 || country.SelectedIndex == -1 || address.Value=="" || email.Value=="" || contact.Value=="" )
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string custname = cname.Value;
					string Gender = gender.SelectedItem.ToString();
					string Country = country.SelectedItem.ToString();
					string Address = address.Value;
					string Email = email.Value;
					string Contact = contact.Value;

					string Query = "Insert into customer values('{0}','{1}','{2}','{3}','{4}',{5})";
					Query = string.Format(Query, custname, Email, Gender, Address, Country,Contact);
					con.SetData(Query);
					ShowCustomer();
					ErrMsg.Text = "Customer Added!!";
					cname.Value = "";
					gender.SelectedIndex = -1;
					country.SelectedIndex = -1;
					address.Value = "";
					email.Value = "";
					contact.Value = "";
				}
			}
			catch(Exception Ex) {
				ErrMsg.Text = Ex.Message;
			}
        }
		int key = 0;
		protected void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cname.Value = CustomerList.SelectedRow.Cells[2].Text;
			email.Value = CustomerList.SelectedRow.Cells[3].Text;
			gender.SelectedItem.Value = CustomerList.SelectedRow.Cells[4].Text;
			address.Value = CustomerList.SelectedRow.Cells[5].Text;
			country.SelectedItem.Value = CustomerList.SelectedRow.Cells[6].Text;
			contact.Value = CustomerList.SelectedRow.Cells[7].Text;
			if(cname.Value == "")
			{
				key = 0;
			}
			else
			{
				key = Convert.ToInt32(CustomerList.SelectedRow.Cells[1].Text);
			}
		}

		protected void update_Click(object sender, EventArgs e)
		{
			try
			{
				if (cname.Value == "" || gender.SelectedIndex == -1 || country.SelectedIndex == -1 || address.Value == "" || email.Value == "" || contact.Value == "")
				{
					ErrMsg.Text = "Missing Data!!";
				}
				else
				{
					string custname = cname.Value;
					string Gender = gender.SelectedItem.ToString();
					string Country = country.SelectedItem.ToString();
					string Address = address.Value;
					string Email = email.Value;
					string Contact = contact.Value;

					string Query = "update customer set cust_name='{0}',cust_email='{1}',gender='{2}',address='{3}',country='{4}',contact={5} where cust_id={6}";
					Query = string.Format(Query, custname, Email, Gender, Address, Country, Contact, CustomerList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowCustomer();
					ErrMsg.Text = "Customer Updated!!";
					cname.Value = "";
					gender.SelectedIndex = -1;
					country.SelectedIndex = -1;
					address.Value = "";
					email.Value = "";
					contact.Value = "";
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
				if (cname.Value == "" || gender.SelectedIndex == -1 || country.SelectedIndex == -1 || address.Value == "" || email.Value == "" || contact.Value == "")
				{
					ErrMsg.Text = "Select an Customer!!";
				}
				else
				{
					string custname = cname.Value;
					string Gender = gender.SelectedItem.ToString();
					string Country = country.SelectedItem.ToString();
					string Address = address.Value;
					string Email = email.Value;
					string Contact = contact.Value;

					string Query = "delete from customer where cust_id = {0}";
					Query = string.Format(Query, CustomerList.SelectedRow.Cells[1].Text);
					con.SetData(Query);
					ShowCustomer();
					ErrMsg.Text = "Customer Deleted!!";
					cname.Value = "";
					gender.SelectedIndex = -1;
					country.SelectedIndex = -1;
					address.Value = "";
					email.Value = "";
					contact.Value = "";
				}
			}
			catch (Exception Ex)
			{
				ErrMsg.Text = Ex.Message;
			}
		}
	}
}