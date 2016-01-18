namespace WebHandler
{
    using System;
    using System.Web.UI;

    public partial class _Default : Page
    {
        protected void GetText_Click(object sender, EventArgs e)
        {
            string text = this.TextBox.Text;
            string textWidth = this.TextWidth.Text;

            Response.Redirect("text.img?text=" + text + "&width=" + textWidth);
        }
    }
}