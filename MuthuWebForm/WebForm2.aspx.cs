using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuthuWebForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["Value"].ToString();
            TextBox2.Text = Session["FName"].ToString();
            TextBox3.Text = Session["Gender"].ToString();
            TextBox4.Text = Session["Mailid"].ToString();
            TextBox5.Text = Session["Dob"].ToString();
            TextBox6.Text = Session["Reg"].ToString();
            TextBox7.Text = Session["deg"].ToString();
            TextBox8.Text = Session["Branch"].ToString();
            TextBox9.Text = Session["Year"].ToString();
            TextBox10.Text = Session["College"].ToString();
            TextBox11.Text = Session["Phone"].ToString();
        }
    }
}