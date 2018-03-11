using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit3_Chiles
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Populate the labels with the data in session state.
            double sales = (double)Session["Sales"];
            double discount = (double)Session["Discount"];
            double total = (double)Session["Total"];

            lblSalesPrice.Text = "Sales Price: " + sales.ToString("c");
            lblDiscountAmount.Text = "Discount Amount: " + discount.ToString("c");
            lblTotalPrice.Text = "Total Price: " + total.ToString("c");
        }
    }
}