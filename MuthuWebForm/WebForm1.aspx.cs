using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MuthuWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Value"] = TextBox1.Text;
            Session["FName"] = TextBox4.Text;
            Session["Gender"] = RadioButtonList1.SelectedItem.Text;
            Session["Mailid"] = TextBox3.Text;
            Session["Dob"] = Calendar1.SelectedDate;
            Session["Reg"] = TextBox5.Text;
            Session["deg"] = DropDownList2.Text;
            Session["Branch"] = DropDownList1.Text;
            Session["Year"] = DropDownList3.Text;
            Session["College"] = RadioButtonList2.Text;
            Session["Phone"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}