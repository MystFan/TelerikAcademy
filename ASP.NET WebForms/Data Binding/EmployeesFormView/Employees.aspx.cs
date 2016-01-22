namespace EmployeesFormView
{
    using System;
    using System.Web.UI;
    using DataNorthwind;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridViewEmployees.DataSource = DataSource.GetEmployees();
            this.DataBind();

            if (Request.Params["id"] != null)
            {
                var id = int.Parse(Request.Params["id"]);
                this.FormViewEmployees.DataSource = DataSource.GetEmployeeById(id);
                this.FormViewEmployees.DataBind();
            }
        }
    }
}