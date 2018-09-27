using Data_Access_Layer_DAL_.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping_cart
{
    public partial class Product_Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
                Product_respository ps = new Product_respository();
                ps.getDetails();
                for (int count = 0; count < ps.productslist.Count; count++)
                {
                    TableRow tablerow = new TableRow();
                    tb.Rows.Add(tablerow);
                    TableCell tcell = new TableCell();
                    Label l = new Label();
                    HyperLink preview = new HyperLink();
                    HyperLink update = new HyperLink();
                    HyperLink delete = new HyperLink();
                    PlaceHolder1.Controls.Add(l);
                    l.Text = ps.productslist[count].Name;
                    l.Width = 300;
                    PlaceHolder1.Controls.Add(preview);
                    preview.Text = "Preview";
                    preview.NavigateUrl = "ProductDescription?Id=" + count;
                    preview.Width = 300;
                    PlaceHolder1.Controls.Add(update);
                    update.Text = "Update";
                    update.NavigateUrl = "Update?Id=" + count;
                    update.Width = 300;
                    PlaceHolder1.Controls.Add(delete);
                    delete.Text = "Delete";
                    delete.NavigateUrl = "Delete?Id=" + count;
                    delete.Width = 300;

                }
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert.aspx");
        }
    }
}