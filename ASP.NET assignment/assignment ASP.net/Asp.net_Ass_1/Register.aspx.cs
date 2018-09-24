using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net_Ass_1
{
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
       
            //string details;
            protected void Button1_Click(object sender, EventArgs e)
            {
                PersonData Ps = new PersonData();
                Ps.FName = FirstName.Text;
                Ps.LName = LastName.Text;
                Ps.age = Convert.ToInt32(Age.Text);
                Ps.dateofbirth = Convert.ToInt32(DateofBirth.Text);
                Ps.Gender = Gender.Text;
                Ps.Country = Country.Text;
            Response.Redirect("www.chrome.com");

        } 
            //details = FirstName.Text + LastName.Text+ Gender.Text+ Convert.ToDateTime(DateofBirth.Text)+Convert.ToInt32(Age.Text) + Country.Text;
        
    }
}