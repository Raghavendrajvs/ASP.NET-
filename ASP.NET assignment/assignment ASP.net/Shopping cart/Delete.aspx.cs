using Data_Access_Layer_DAL_.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_cart
{
    public partial class Delete : System.Web.UI.Page
    {
        Product_respository ps = new Product_respository();
        protected void Page_Load(object sender, EventArgs e)
        {
            ps.getDetails();
            int qint = Convert.ToInt32(Request.QueryString["Id"]);
            TextBox1.Text = Convert.ToString(ps.productslist[qint].Id);
            TextBox2.Text = ps.productslist[qint].Name;
            TextBox3.Text = ps.productslist[qint].Price;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ps.Delete(Convert.ToInt32(TextBox1.Text));
            Response.Redirect("Product_edit.aspx");
        }
    }
}