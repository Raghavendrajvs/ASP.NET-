using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer_DAL_.Respository;
namespace Shopping_cart
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Product_respository ps = new Product_respository();
            ps.getDetails();
            int qint = Convert.ToInt32(Request.QueryString["Id"]);
           
            TextBox1.Text = ps.productslist[qint].Name;
            TextBox2.Text = ps.productslist[qint].Price;
            Image1.ImageUrl = ps.productslist[qint].ImageUrl;
            TextBox3.Text = ps.productslist[qint].Description;
        }
    }
}