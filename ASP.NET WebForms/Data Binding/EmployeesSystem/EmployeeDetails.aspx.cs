namespace EmployeesSystem
{
    using System;
    using System.Web.UI;
    using DataNorthwind;

    public partial class EmployeeDetails : Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DetailsViewEmployees.PageIndex = int.Parse(Request.Params["Id"]);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Id"] == null)
            {
                Response.Redirect("Employees.aspx");
            }

            this.DetailsViewEmployees.DataSource = DataSource.GetEmployeeById(int.Parse(Request.Params["Id"]));
            this.DataBind();
        }
    }
}