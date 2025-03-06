using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1_aspx
{
	public partial class New2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ddlSupplier.Enabled = false;
			ddlCategory.Enabled = false;
			txtDescription.Enabled = false;
			ddlCategory.SelectedValue = Request.Cookies["ddlCategory"].Value;
			ddlSupplier.SelectedValue = Request.Cookies["ddlSupplier"].Value;
			txtProduct.Text = Request.Cookies["txtProduct"].Value;
			txtDescription.Text = Request.Cookies["txtDescription"].Value;
			txtImage.Text = Request.Cookies["txtImage"].Value;
			Decimal decPrice = Convert.ToDecimal(Request.Cookies["txtPrice"].Value);
			txtPrice.Text = decPrice.ToString("c");
			txtNumberInStock.Text = Request.Cookies["txtNumberInStock"].Value;
			txtNumberOnOrder.Text = Request.Cookies["txtNumberOnOrder"].Value;
			txtReorderLevel.Text = Request.Cookies["txtReorderLevel"].Value;
			Byte bytNumberInStock = Convert.ToByte(Request.Cookies["txtNumberInStock"].Value);
			Byte bytNumberOnOrder = Convert.ToByte(Request.Cookies["txtNumberOnOrder"].Value);
			Decimal decValueInStock = decPrice * bytNumberInStock;
			Decimal decValueOnOrder = decPrice * bytNumberOnOrder;
			txtNumberInStock.Text = decValueInStock.ToString("c");
			txtNumberOnOrder.Text = decValueOnOrder.ToString("c");
		}

        protected void btn_Confir_Click(object sender, EventArgs e)
        {

        }

		protected void btn_back_Click(object sender, EventArgs e)
		{

		}
	}
}