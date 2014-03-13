using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;

namespace PhoneToys
{
    public partial class Phonetoys2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["varukorg"] != null)
            {
                if (((List<Varukorgen>)Session["varukorg"]).Count > 0)
                {
                    List<Varukorgen> vara = ((List<Varukorgen>)Session["varukorg"]);
                    varukorgAntalLabel.Text = ((List<Varukorgen>)Session["varukorg"]).Count.ToString();
                }
                else
                {
                    varukorgAntalLabel.Text = "0";
                }
            }
            else
            {
                varukorgAntalLabel.Text = "0";
            }

            if (Session["Username"] != null)
            {
                loginRegisterUL.Visible = false;
            }
            else
            {
                loginRegisterUL.Visible = true;
                LogOutUser.Visible = false;
            }
        }

        protected void LogOutUser_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Index");
        }
    }
}