using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer_DAL_.Respository;


namespace Shopping_cart
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Context.User.IsInRole("Product Management")))
            {
                Response.Redirect("Default.aspx");
            }

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product_edit.aspx");
        }
    }
}
