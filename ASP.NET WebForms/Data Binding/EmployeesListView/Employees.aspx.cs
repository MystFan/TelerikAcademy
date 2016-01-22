namespace EmployeesListView
{
    using System;
    using System.Web.UI;
    using DataNorthwind;

    public partial class Employees : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ListViewEmployees.DataSource = DataSource.GetEmployees();
                Page.DataBind();
            } 
        }
    }
}