using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				// Initialize your page here if needed
			}
		}

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
			// Add the entered item to the GridView
			DataTable dtItems = new DataTable();
			if (ViewState["Items"] != null)
			{
				dtItems = (DataTable)ViewState["Items"];
			}
			else
			{
				dtItems.Columns.AddRange(new DataColumn[3] { new DataColumn("ItemName"), new DataColumn("Quantity"), new DataColumn("Price") });
			}

			dtItems.Rows.Add(txtItemName.Text, txtQuantity.Text, txtPrice.Text);
			gvItems.DataSource = dtItems;
			gvItems.DataBind();
			ViewState["Items"] = dtItems;
		}
		protected void btnGenerateInvoice_Click(object sender, EventArgs e)
		{
			// Generate the invoice based on the entered items
			// You can implement your logic here to generate the invoice
			// For example, you can use the items in the GridView to calculate the total amount, taxes, etc.
			// Then you can display the invoice or save it as a PDF, etc.
		}
	}
 }
