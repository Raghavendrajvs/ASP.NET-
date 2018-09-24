using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment
{
    public partial class registration : System.Web.UI.Page
    {


        
         
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string firstname;
        protected void firstName(object sender, EventArgs e)
        {
            firstname = FirstName.Text;
        }
        string lastname;
        protected void lastName(object sender, EventArgs e)
        {

            lastname = LastName.Text;
        }
        string gender;
        protected void Gender_(object sender, EventArgs e)
        {
            gender = Gender.Text;
        }
        DateTime dateofbirth;
        protected void dateofBirth(object sender, EventArgs e)
        {
            dateofbirth = Convert.ToDateTime(DateofBirth.Text);
        }
        int age;
        protected void Age_(object sender, EventArgs e)
        {

            if (age < 0 && age > 100)
            {
                Console.WriteLine("not valid");
            }
            else
            {
                age = Convert.ToInt32(Age.Text);
            }
        }
        string country;
        protected void country_(object sender, EventArgs e)
        {
            country = Country.Text;
        }
        //string details;
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("www.chrome.com");
            //details = FirstName.Text + LastName.Text+ Gender.Text+ Convert.ToDateTime(DateofBirth.Text)+Convert.ToInt32(Age.Text) + Country.Text;
        }
    }
    }