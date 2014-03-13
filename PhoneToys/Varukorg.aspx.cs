using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;


namespace PhoneToys
{
    public partial class Varukorg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            
            
            if (!Page.IsPostBack)
            {
                VarukorgRepeater.DataSource = Session["varukorg"];
                VarukorgRepeater.DataBind();
            }

            VarukorgRepeater.ItemCommand += new RepeaterCommandEventHandler(this.VarukorgRepeater_ItemCommand);

        }

        protected void VarukorgRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                int index = e.Item.ItemIndex;

                List<Varukorgen> v = (List<Varukorgen>)Session["varukorg"];
                v.RemoveAt(index);

                Session["varukorg"] = v;

                Response.Redirect("Varukorg");
            }
        }
    }
}