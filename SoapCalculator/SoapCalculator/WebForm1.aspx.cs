using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoapCalculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String num1 = TextBox1.Text;
            String num2 = TextBox2.Text;
            int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Label1.Text = Convert.ToString(result);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String num1 = TextBox1.Text;
            String num2 = TextBox2.Text;
            int result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
            Label1.Text = Convert.ToString(result);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {


            String num1 = TextBox1.Text;
            String num2 = TextBox2.Text;
            int result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
            Label1.Text = Convert.ToString(result);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            String num1 = TextBox1.Text;
            String num2 = TextBox2.Text;
            Double result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
            Label1.Text = Convert.ToString(result);
        }
    }
}