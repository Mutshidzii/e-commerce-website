using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webapp_ui.ServiceReference1;

namespace webapp_ui
{
    public partial class deletepriceoffer : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            client.deletepriceoffer(Convert.ToInt32(id));
            Response.Redirect("discount.aspx");
        }
    }
}