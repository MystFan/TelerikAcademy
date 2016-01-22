<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesRepeater.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, td, th {
            border: 1px solid #000;
            border-collapse: collapse;
        }

        td, th {
            padding: 3px;
            text-align: center;
        }
    </style>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="formEmployees" runat="server">

        <asp:Repeater ID="RepeaterEmployee" runat="server" ItemType="DataNorthwind.Employee">
            <HeaderTemplate>
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
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#: Item.FirstName %> </td>
                    <td><%#: Item.LastName %> </td>
                    <td><%#: Item.Job %> </td>
                    <td><%#: Item.BirthDate.ToString("MM/dd/yyyy") %> </td>
                    <td><%#: Item.HireDate.ToString("MM/dd/yyyy") %> </td>
                    <td><%#: Item.Address %> </td>
                    <td><%#: Item.City %> </td>
                    <td><%#: Item.Country %> </td>
                    <td><%#: Item.Phone %> </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

    </form>
</body>
</html>
