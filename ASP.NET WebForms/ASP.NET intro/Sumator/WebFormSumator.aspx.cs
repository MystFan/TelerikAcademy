namespace Sumator
{
    using System;
    using System.Web.UI;

    public partial class WebFormSumator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.TextBoxFirstNumber.Text == "")
            {
                this.TextBoxFirstNumber.Text = "0";
            }
            if (this.TextBoxSecondNumber.Text == "")
            {
                this.TextBoxSecondNumber.Text = "0";
            }
        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal firstNum = decimal.Parse(this.TextBoxFirstNumber.Text);
                decimal secondNum = decimal.Parse(this.TextBoxSecondNumber.Text);
                decimal sum = firstNum + secondNum;
                this.TextBoxResult.Text = sum.ToString();
            }
            catch(Exception ex)
            {
                this.TextBoxResult.Text = "Input number was not in a correct format";
            }
      }
    }
}