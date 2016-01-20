namespace RandomNumbers
{
    using System;
    using System.Web.UI;

    public partial class RandomNumbersHtmlControls : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.TextBoxFirstNumber.Value == "")
            {
                this.TextBoxFirstNumber.Value = "0";
            }
            if (this.TextBoxSecondNumber.Value == "")
            {
                this.TextBoxSecondNumber.Value = "0";
            }
        }

        protected void GenerateRandomNumber_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int fromNumber = int.Parse(this.TextBoxFirstNumber.Value);
                int toNumber = int.Parse(this.TextBoxSecondNumber.Value);
                int randomNumber = rand.Next(fromNumber, toNumber);
                this.TextBoxRandomNumber.Value = randomNumber.ToString();
            }
            catch (Exception ex)
            {
                this.TextBoxRandomNumber.Value = ex.Message;
            }
        }
    }
}