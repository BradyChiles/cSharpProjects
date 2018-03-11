using System;
using System.Web;
using Unit5_Chiles.App_Code;

namespace Unit5_Chiles
{
    public partial class Confirmation : System.Web.UI.Page
    {

        //Fill the labels with the data in session state (from the input page).
        protected void Page_Load(object sender, EventArgs e)
        {
            Reservation reservation = (Reservation)Session["reservation"];

            lblFirstName.Text = reservation.FirstName;
            lblLastName.Text = reservation.LastName;
            lblEmail.Text = reservation.Email;
            lblPhone.Text = reservation.Phone;
            lblContact.Text = reservation.PreferredMethod;

            lblArrival.Text = reservation.ArrivalDate.ToString("MM/dd/yyyy");
            lblDeparture.Text = reservation.DepartureDate.ToString("MM/dd/yyyy");
            lblDays.Text = reservation.NoOfDays.ToString();
            lblPeople.Text = reservation.NoOfPeople.ToString();
            lblBed.Text = reservation.BedType;
            lblSpecial.Text = reservation.SpecialRequests;
        }

        //Create cookies for firstName and email, as well as print a confirmation message.
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = new HttpCookie("firstName", lblFirstName.Text);
            nameCookie.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(nameCookie);

            HttpCookie emailCookie = new HttpCookie("email", lblEmail.Text);
            emailCookie.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(emailCookie);

            lblConfirmation.Text = "Thank you for your request.";
            lblConfirmation2.Text = "We will get back to you within 24 hours.";

        }
    }
}