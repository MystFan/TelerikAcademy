using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation_Controls
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate("RegisterInfo");
            Page.Validate("PersonalInfo");
            Page.Validate("ContactsInfo");
        }

        protected void RadioButtonListGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            var radioValue = (RadioButtonList)sender;

            if (radioValue.SelectedValue == "1")
            {
               this.PanelMale.Visible = false;
               this.PanelFimale.Visible = true;
            }
            else
            {
               this.PanelFimale.Visible = false;
               this.PanelMale.Visible = true;
            }
        }
    }
}