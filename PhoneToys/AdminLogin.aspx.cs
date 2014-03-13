using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace PhoneToys
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        private Data data = new Data();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogInABTN_Click(object sender, EventArgs e)
        {
            if (data.authenticateAdmin(UnameTB.Text, PWTB.Text))
            {
                Session["Username"] = UnameTB.Text;
                Response.Redirect("Admin.aspx");
            }
            if (data.authenticateEditor(UnameTB.Text, PWTB.Text))
            {
                Session["Username"] = UnameTB.Text;
                Response.Redirect("Editor.aspx");
            }
            
        }
    }
}