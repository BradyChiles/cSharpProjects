using System;
using System.Web.UI;
using Unit5_Chiles.App_Code;

/** =========================================================

 Brady Chiles

 Operating System Windows 10

 Microsoft Visual Studio 2015

 CIS 174

 Name Of homework Assignment Unit 5 Royal Inss and Suites

 Program Description: This program will take input from the user for a submission form on a reservation.
    It will then validate several fields using required field, compare, and regular expression. Once it has cleared validation
    it will post to a confirmation page where the user can look over the entries, and click a button to modify and return to the 
    input page or confirma and receive a confirmation message (as well as save firstName and email in cookies). IF the user clicks modify, 
    on return to the input page, the fields will be filled with the previously input data.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace Unit4_Chiles
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Shuts of unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //Sets the arrival date text box to current date
            txtArrival.Text = DateTime.Today.ToShortDateString();

            //Will fill the fields with the information stored in session if this is the return to the input page. Otherwise they will be blank/default.
            if (Session["reservation"] != null)
            {
                Reservation reservation = (Reservation)Session["reservation"];

                txtArrival.Text = reservation.ArrivalDate.ToString("MM/dd/yyyy");
                txtDeparture.Text = reservation.DepartureDate.ToString("MM/dd/yyyy");
                ddlPeople.SelectedValue = reservation.NoOfPeople.ToString();

                if(reservation.BedType == "2 Queen")
                {
                    rdo2Queen.Checked = true;
                }else if(reservation.BedType == "Queen")
                {
                    rdoQueen.Checked = true;
                }else if(reservation.BedType == "King")
                {
                    rdoKing.Checked = true;
                }

                txtSpecialRequests.Text = reservation.SpecialRequests;
                txtFirstName.Text = reservation.FirstName;
                txtLastName.Text = reservation.LastName;
                txtEmail.Text = reservation.Email;
                txtPhone.Text = reservation.Phone;
            }

        }

        //When submit is pressed, will store the data in the fields in sesssion state. And redirect to the confirmation page.
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            
            reservation.ArrivalDate = Convert.ToDateTime(txtArrival.Text);
            reservation.DepartureDate = Convert.ToDateTime(txtDeparture.Text);

            TimeSpan tsDays = reservation.DepartureDate - reservation.ArrivalDate;
            reservation.NoOfDays = Convert.ToInt32(tsDays.Days);

            reservation.NoOfPeople = Convert.ToInt32(ddlPeople.SelectedValue);

            if(rdo2Queen.Checked == true)
            {
                reservation.BedType = "2 Queen";
            }else if(rdoQueen.Checked == true)
            {
                reservation.BedType = "Queen";
            }else if(rdoKing.Checked == true)
            {
                reservation.BedType = "King";
            }

            reservation.SpecialRequests = txtSpecialRequests.Text;
            reservation.FirstName = txtFirstName.Text;
            reservation.LastName = txtLastName.Text;
            reservation.Email = txtEmail.Text;
            reservation.Phone = txtPhone.Text;
            reservation.PreferredMethod = ddlContact.SelectedValue;

            Session["reservation"] = reservation;

            Response.Redirect("Confirmation.aspx");
        }

        //Reset all the fields to defaults
        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Reset all fields
            txtArrival.Text = DateTime.Today.ToShortDateString();
            txtDeparture.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtSpecialRequests.Text = "";
            txtPhone.Text = "";
            rdoKing.Checked = true;
            rdo2Queen.Checked = false;
            rdoQueen.Checked = false;
            ddlPeople.SelectedIndex = 0;
            ddlContact.SelectedIndex = 0;
        }
    }
}