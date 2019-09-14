using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GitDemoProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        static float a, c, d;

        static char b;

        protected void Page_Load(object sender, EventArgs e)

        {



        }

        protected void b1_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b1.Text;

            }

            else

                t.Text = t.Text + b1.Text;

        }

        protected void b2_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b2.Text;

            }

            else

                t.Text = t.Text + b2.Text;

        }

        protected void b3_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b3.Text;

            }

            else

                t.Text = t.Text + b3.Text;

        }

        protected void b4_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b4.Text;

            }

            else

                t.Text = t.Text + b4.Text;

        }

        protected void b5_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b5.Text;

            }

            else

                t.Text = t.Text + b5.Text;

        }

        protected void b6_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b6.Text;

            }

            else

                t.Text = t.Text + b5.Text;

        }

        protected void b7_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b7.Text;

            }

            else

                t.Text = t.Text + b7.Text;

        }



        protected void b8_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b8.Text;

            }

            else

                t.Text = t.Text + b8.Text;

        }



        protected void b9_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b9.Text;

            }

            else

                t.Text = t.Text + b9.Text;

        }



        protected void b0_Click(object sender, EventArgs e)

        {

            if ((t.Text == "+") || (t.Text == "-") || (t.Text == "*") || (t.Text == "/"))

            {

                t.Text = "";

                t.Text = t.Text + b0.Text;

            }

            else

                t.Text = t.Text + b0.Text;

        }



        protected void add_Click(object sender, EventArgs e)

        {

            a = Convert.ToInt32(t.Text);

            t.Text = "";

            b = '+';

            t.Text += b;

        }

        protected void sub_Click(object sender, EventArgs e)

        {

            a = Convert.ToInt32(t.Text);

            t.Text = "";

            b = '-';

            t.Text += b;

        }

        protected void mul_Click(object sender, EventArgs e)

        {

            a = Convert.ToInt32(t.Text);

            t.Text = "";

            b = '*';

            t.Text += b;

        }

        protected void div_Click(object sender, EventArgs e)

        {

            a = Convert.ToInt32(t.Text);

            t.Text = "";

            b = '/';

            t.Text += b;

        }

        protected void eql_Click(object sender, EventArgs e)

        {

            c = Convert.ToInt32(t.Text);

            t.Text = "";

            if (b == '/')

            {

                d = a / c;

                t.Text += d;

                a = d;

            }

            else if (b == '+')

            {

                d = a + c;

                t.Text += d;

                a = d;

            }

            else if (b == '-')

            {

                d = a - c;

                t.Text += d;

                a = d;

            }

            else

            {

                d = a * c;

                t.Text += d;

                a = d;

            }



        }


        protected void clr_Click(object sender, EventArgs e)

        {

            t.Text = "";

        }

    }
}