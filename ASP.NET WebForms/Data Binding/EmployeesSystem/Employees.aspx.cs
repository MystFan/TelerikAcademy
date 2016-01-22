namespace EmployeesSystem
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using DataNorthwind;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var employees = DataSource.GetEmployees();
                this.GridViewEmployees.DataSource = employees;
                this.DataBind();
            }  
        }

        protected void GridViewEmployees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridViewEmployees.PageIndex = e.NewPageIndex;
            var employees = DataSource.GetEmployees();
            this.GridViewEmployees.DataSource = employees;
            this.DataBind();
        }
    }
}