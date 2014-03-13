using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;


namespace PhoneToys
{
    public partial class Light : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LightOffBTN_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.spark.io/v1/devices/48ff6c065067555035261587/LightOff?access_token=0db5f14f8deff81a1ac03b43508f15e7e8637af7");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
        }

        protected void LightOnBTN_Click(object sender, EventArgs e)
        {
            //https://api.spark.io/v1/devices/48ff6c065067555035261587/Light?access_token=0db5f14f8deff81a1ac03b43508f15e7e8637af7;
            var client = new RestClient("https://api.spark.io/v1/devices/48ff6c065067555035261587/Light?access_token=0db5f14f8deff81a1ac03b43508f15e7e8637af7");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
        }
    }
}