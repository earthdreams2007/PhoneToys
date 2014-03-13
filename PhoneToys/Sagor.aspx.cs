using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;

namespace PhoneToys
{
    public partial class Sagor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Test test = new Test();
                Test test2 = new Test();
                Test test3 = new Test();

                List<Test> testet = new List<Test>();

                test.Bild = "~/Images/bamse.jpg";
                test.pris = 123;
                test.text = "MinGrid";
                test2.Bild = "~/Images/bamse.jpg";
                test2.pris = 250;
                test2.text = "Mineyed";
                test3.Bild = "~/Images/bamse.jpg";
                test3.pris = 156;
                test3.text = "Minerereeeid";

                testet.Add(test);
                testet.Add(test);
                testet.Add(test);
                testet.Add(test2);
                testet.Add(test2);
                testet.Add(test2);
                testet.Add(test3);
                testet.Add(test3);
                testet.Add(test3);

                SagoView.DataSource = testet;
                SagoView.DataBind();
            }
            SagoView.ItemCommand += new EventHandler<ListViewCommandEventArgs>(this.SagoView_ItemCommand);
        }

        protected void SagoView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            List<Varukorgen> varor = (List<Varukorgen>)Session["varukorg"];
            int index = e.Item.DataItemIndex;

            string sagoNamn = ((Label)SagoView.Items[index].FindControl("text")).Text;

            int pris = Convert.ToInt32(((Label)SagoView.Items[index].FindControl("pris")).Text);

            Varukorgen varan = new Varukorgen();

            varan.Pris = pris;
            varan.Saga = sagoNamn;

            varor.Add(varan);

            Session["varukorg"] = varor;

            Response.Redirect("Sagor");
        }
    }
}