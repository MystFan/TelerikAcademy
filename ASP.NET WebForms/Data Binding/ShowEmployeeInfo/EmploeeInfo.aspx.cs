namespace ShowEmployeeInfo
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using DataNorthwind;

    public partial class EmploeeInfo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ListViewEmployees.DataSource = DataSource.GetEmployees();
            this.ListViewEmployees.DataBind();
        }

        private void BindSortedEmployees(string SortExpression)
        {
            ListViewEmployees.DataSource = DataSource.GetSortedByQueryEmployees("Select * from Employees" + SortExpression);
            ListViewEmployees.DataBind();
        }

        protected void ListViewEmployees_Sorting(object sender, ListViewSortEventArgs e)
        {
            string SortDirection = "ASC";

            if (ViewState["SortExpression"] != null)
            {
                if (ViewState["SortExpression"].ToString() == e.SortExpression)
                {
                    ViewState["SortExpression"] = null;
                    SortDirection = "DESC";
                }
                else
                {
                    ViewState["SortExpression"] = e.SortExpression;
                }
            }
            else
            {
                ViewState["SortExpression"] = e.SortExpression;
            }

            BindSortedEmployees(" order by " + e.SortExpression + " " + SortDirection);
        }
    }
}