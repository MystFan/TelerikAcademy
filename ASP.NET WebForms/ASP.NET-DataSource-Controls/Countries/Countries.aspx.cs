using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Countries
{
    public partial class Countries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewCountries_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridViewCountries.SelectedIndex = e.NewPageIndex;
            this.GridViewCountries.DataBind();
        }
    }
}