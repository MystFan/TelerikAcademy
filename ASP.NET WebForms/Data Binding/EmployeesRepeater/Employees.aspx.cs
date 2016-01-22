namespace EmployeesRepeater
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;
    using DataNorthwind;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<Employee> employees = DataSource.GetEmployees();
                this.RepeaterEmployee.DataSource = employees;
                this.RepeaterEmployee.DataBind();
            }
        }
    }
}