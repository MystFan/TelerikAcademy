<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesSystem.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="description" content="The description of my page" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="formEmployees" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server"
            AutoGenerateColumns="false" AllowPaging="true" onpageindexchanging="GridViewEmployees_PageIndexChanging">
            <Columns>
                <asp:HyperLinkField DataTextField="FirstName" 
                    HeaderText="First Name" DataNavigateUrlFields="Id"
                    DataNavigateUrlFormatString="EmployeeDetails.aspx?id={0}"/>
                <asp:BoundField DataField="LastName"
                    HeaderText="Last Name" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
