using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_cart
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Context.User.IsInRole("Order Management")))
            {

                Response.Redirect("Default.aspx");

            }
        }
    }
}