using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using Entities;

namespace PhonetoysWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        private Data data = new Data();
        protected void Page_Load(object sender, EventArgs e)
        {
            countryDD.Items.Add("Sverige");
            countryDD.Items.Add("Norge");
            countryDD.Items.Add("Danmark");
            countryDD.Items.Add("Suomi");
        }

        protected void registerBTN_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Uname = UnameTB.Text;
            user.Email = EmailTB.Text;
            user.Password = PWTB.Text;
            user.Fname = FnameTB.Text;
            user.Lname = LnameTB.Text;
            user.Address = AddressTB.Text;
            user.ZipCode = Convert.ToInt32(ZipTB.Text);
            user.City = CityTB.Text;
            user.Country = countryDD.SelectedItem.Text;

            data.Register(user);
            Session["Username"] = EmailTB.Text;

            Response.Redirect("Index.aspx");

        }
    }
}