namespace RandomNumbers
{
    using System;
    using System.Web.UI;

    public partial class RandomNumbersWebControls : Page
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

        protected void ButtonRandomNumber_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int firstNum = int.Parse(this.TextBoxFirstNumber.Text);
                int secondNum = int.Parse(this.TextBoxSecondNumber.Text);
                int randomNum = rand.Next(firstNum, secondNum);
                this.TextBoxResult.Text = randomNum.ToString();
            }
            catch (Exception ex)
            {
                this.TextBoxResult.Text = ex.Message;
            }
        }
    }
}