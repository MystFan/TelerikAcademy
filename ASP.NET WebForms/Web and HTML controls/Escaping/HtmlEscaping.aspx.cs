namespace Escaping
{
    using System;
    using System.Web.UI;

    public partial class HtmlEscaping : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBoxText.Text = "<script>alert('hack')</script>";
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.LabelEscape.Text = this.TextBoxText.Text;
                this.TextBoxEscape.Text = this.TextBoxText.Text;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}