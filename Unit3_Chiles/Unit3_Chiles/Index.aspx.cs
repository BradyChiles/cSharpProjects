using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/** =========================================================

 Brady Chiles

 Operating System Windows 10
 Microsoft Visual Studio 2015

 CIS 174

 Name Of homework Assignment Unit 3

 Program Description: This program will accept input for the sales and the discount percent. It will
    then calculate the discount amount and total price after discount, displaying it on the form. The confirm
    button will take the user to a confirmation page. If calculate has not been clicked before confirm, it will 
    throw an error. The return button on the confirmation page will return the user to the main page.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Unit3_Chiles
{
    public partial class Index : System.Web.UI.Page
    {
        public static int calculated = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Shuts off unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            //This will determine if there is data in session state. If so it will display the data. 
            //This will only fire on the return from the confirmation page.
            if (Session["Sales"] != null)
            {
                double sales = (double)Session["Sales"];
                double discount = (double)Session["Discount"];
                double total = (double)Session["Total"];
                double percent = (double)Session["DPercent"] * 100;

                txtSalesPrice.Text = sales.ToString();
                txtDiscountPercent.Text = percent.ToString();
                lblDiscountAmount.Text = "Discount Amount: " + discount.ToString("c");
                lblTotalPrice.Text = "Total Price: " + total.ToString("c");
            }

        }

        //Calulcate Button Click
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            double salesPrice = 0;
            double discountPercent = 0;
            double discountAmount = 0;
            double totalSales = 0;
            calculated = 1;

            //Pull vaue from sales price text box
            salesPrice = Convert.ToDouble(txtSalesPrice.Text);

            //Takes the value from the discount percent text box and makes it a decimal.
            discountPercent = (Convert.ToDouble(txtDiscountPercent.Text)) / 100;

            //Calculate discount amount
            discountAmount = salesPrice * discountPercent;
            //Assigns the discount amount to the label
            lblDiscountAmount.Text = "Discount Amount: " + discountAmount.ToString("c");

            //Calculates total sales
            totalSales = salesPrice - discountAmount;
            //Assigns total sales to label
            lblTotalPrice.Text = "Total Price: " + totalSales.ToString("c");

            Session["Sales"] = salesPrice;
            Session["Discount"] = discountAmount;
            Session["Total"] = totalSales;
            Session["DPercent"] = discountPercent;

        }

        //On click - Confirm Button
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //If the calculate button has not been clicked, throw the error.
            if (calculated == 0)
            {
                lblCalcConfirmError.Text = "Click the Calculate button before you confirm.";
                //Otherwise, move to the confirmation page.
            }else {    
                Server.Transfer("Confirmation.aspx"); 
            }
        }
    }
}