using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DumpEvents
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page load");
            Response.Write("<br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page PreInit");
            Response.Write("<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init");
            Response.Write("<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Random rand = new Random();
            var red = rand.Next(0, 255);
            var green = rand.Next(0, 255);
            var blue = rand.Next(0, 255);
            this.Body.Style["background-color"] = "rgb(" + red + "," + green + "," + blue + ")";
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "Hello, ASP.NET";
            Response.Write("<br/>");
        }
    }
}