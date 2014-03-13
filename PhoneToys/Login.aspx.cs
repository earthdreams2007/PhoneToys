using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PhoneToys
{
    public partial class Login : System.Web.UI.Page
    {

        private Data data = new Data();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void loginBTN_Click(object sender, EventArgs e)
        //{
        //    string Email = loginEmailTB.Text;
        //    string Password = loginPWTB.Text;
        //    if (data.authenticateUser(Email, Password))
        //    {
        //        Session["Username"] = Email;
        //    }
        //    loginBTN.Text = (string)Session["Username"];


        //}



        protected void AdminBTN_Click1(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void MemberBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemberLogin.aspx");
        }

    }
}