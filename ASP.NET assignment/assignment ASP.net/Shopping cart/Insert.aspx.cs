using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer_DAL_.Respository;
using System.Data.SqlClient;

namespace Shopping_cart
{
    public partial class Preview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Product_respository ps = new Product_respository();
            ps.Insert(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text,TextBox4.Text);
            Response.Redirect("Product_edit.aspx");
        }
    }
    }