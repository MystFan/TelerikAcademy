namespace Calculator
{
    using System;

    public partial class Calculator : System.Web.UI.Page
    {
        private double result = 0;
        private string operation = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["operation"] != null)
            {
                operation = (string)ViewState["operation"];
            }
            else
            {
                ViewState.Add("operation", string.Empty);
            }

            if (ViewState["result"] != null)
            {
                result = (double)ViewState["result"];
            }
            else
            {
                result = 0d;
                ViewState.Add("result", 0d);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button2.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button3.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Calculate();
            ViewState["operation"] = "+";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button4.Text;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button5.Text;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button6.Text;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Calculate();
            ViewState["operation"] = "-";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button7.Text;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button8.Text;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button9.Text;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Calculate();
            ViewState["operation"] = "*";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text = string.Empty;
            ViewState["operation"] = string.Empty;
            ViewState["result"] = 0d;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            this.TextBoxDisplay.Text += this.Button0.Text;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Calculate();
            ViewState["operation"] = "/";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (this.TextBoxDisplay.Text == string.Empty)
            {
                this.TextBoxDisplay.Text = "0";
            }

            double value = double.Parse(this.TextBoxDisplay.Text);
            this.TextBoxDisplay.Text = Math.Sqrt(value).ToString();
        }

        protected void ButtonSubmitResult_Click(object sender, EventArgs e)
        {
            Calculate();
            ViewState["operation"] = string.Empty;
            this.TextBoxDisplay.Text = result.ToString();
        }

        private bool InOperation()
        {
            return operation != string.Empty;
        }

        private void Calculate()
        {
            if (this.TextBoxDisplay.Text == string.Empty)
            {
                this.TextBoxDisplay.Text = "0";
            }

            if (operation == "+" && result != 0)
            {
                result += double.Parse(this.TextBoxDisplay.Text);
            }
            else if(operation == "-" && result != 0)
            {
                result -= double.Parse(this.TextBoxDisplay.Text);
            }
            else if (operation == "*" && result != 0)
            {
                result *= double.Parse(this.TextBoxDisplay.Text);
            }
            else if (operation == "/" && result != 0)
            {
                result /= double.Parse(this.TextBoxDisplay.Text);
            }
            else
            {
                if(this.TextBoxDisplay.Text == string.Empty)
                {
                    this.TextBoxDisplay.Text = "0";
                }

                result = double.Parse(this.TextBoxDisplay.Text);
            }

            ViewState["result"] = result;
            this.TextBoxDisplay.Text = string.Empty;
        }
    }
}