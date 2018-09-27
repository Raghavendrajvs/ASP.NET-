
using Data_Access_Layer_DAL_.Respository;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_cart
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!(Context.User.IsInRole("User")))
            //{

            //    Response.Redirect("Default.aspx");

            //}
            if (!Page.IsPostBack)
            {

                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
                Product_respository ps = new Product_respository();
                ps.getDetails();

                //int count1 = 0;
                for (int count = 0; count < ps.productslist.Count; count++)
                {
                    TableRow tablerow = new TableRow();
                    tb.Rows.Add(tablerow);
                    TableCell tcell = new TableCell();
                    HyperLink hp = new HyperLink();
                    Image mg = new Image();
                    PlaceHolder1.Controls.Add(mg);
                    mg.Width = 200;
                    mg.ImageUrl = ps.productslist[count].ImageUrl;
                    PlaceHolder1.Controls.Add(hp);
                    hp.Text = "<br/>" + ps.productslist[count].Name;
                    hp.NavigateUrl = "ProductDescription?Id=" + count;
                    Label lb = new Label();
                    PlaceHolder1.Controls.Add(lb);
                    lb.Text = "<br/>" + Convert.ToString(ps.productslist[count].Price) + "<br/>";
                    tablerow.Cells.Add(tcell);


                }


            }




        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Product_respository ps = new Product_respository();
            ps.SearchProduct(TextBox1.Text);
            Table tb = new Table();
            tb.ID = "1";
            PlaceHolder1.Controls.Add(tb);

            for (int count = 0; count < ps.productslist.Count; count++)
            {
                TableRow tablerow = new TableRow();
                tb.Rows.Add(tablerow);
                TableCell tcell = new TableCell();
                HyperLink hp = new HyperLink();
                Image mg = new Image();
                PlaceHolder1.Controls.Add(mg);
                mg.ImageUrl = ps.productslist[count].ImageUrl;
                mg.Height = 200;
                mg.Width = 200;
                PlaceHolder1.Controls.Add(hp);
                hp.Text = "<br/>" + ps.productslist[count].Name;
                hp.NavigateUrl = "ProductDetail?Id=" + count;
                Label lb = new Label();
                PlaceHolder1.Controls.Add(lb);
                lb.Text = "<br/>" + Convert.ToString(ps.productslist[count].Price) + "<br/>";
                tablerow.Cells.Add(tcell);
            }




        }

    }



}
