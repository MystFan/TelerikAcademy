<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesFormView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td, th, table {
            border: 1px solid #000;
            border-collapse: collapse;
        }

        table {
            margin: 10px;
        }
    </style>
    <meta name="description" content="The description of my page" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="formEmployees" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server"
            AutoGenerateColumns="false">
            <Columns>
                <asp:HyperLinkField DataTextField="FirstName"
                    HeaderText="First Name" DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="Employees.aspx?id={0}" />

                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
            </Columns>
        </asp:GridView>
        <asp:FormView ID="FormViewEmployees" runat="server" ItemType="DataNorthwind.Employee" EnableViewState="False">
            <ItemTemplate>
                <table>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Job</th>
                        <th>Birth Date</th>
                        <th>Hire Date</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>Country</th>
                        <th>Phone Number</th>
                    </tr>
                    <tr>
                        <td><%#: Item.FirstName %></td>
                        <td><%#: Item.LastName%></td>
                        <td><%#: Item.Job %></td>
                        <td><%#: Item.BirthDate.ToString("MM/dd/yyyy") %></td>
                        <td><%#: Item.HireDate.ToString("MM/dd/yyyy") %></td>
                        <td><%#: Item.Address %></td>
                        <td><%#: Item.City %></td>
                        <td><%#: Item.Country %></td>
                        <td><%#: Item.Phone %></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
        <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="Employees.aspx">Hide</asp:HyperLink>
    </form>
</body>
</html>
