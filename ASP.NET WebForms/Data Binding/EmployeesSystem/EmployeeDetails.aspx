<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="EmployeesSystem.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="formDetails" runat="server">
        <asp:DetailsView ID="DetailsViewEmployees" runat="server" 
            AutoGenerateRows="false"> 
            <Fields>
                <asp:BoundField DataField="FirstName" HeaderText="First name" HtmlEncode="true"/>
                <asp:BoundField DataField="LastName" HeaderText="Last name" HtmlEncode="true"/>
                <asp:BoundField DataField="Job" HeaderText="Job" HtmlEncode="true"/>
                <asp:BoundField DataFormatString="{0:d}" DataField="BirthDate" HeaderText="Birth Date" HtmlEncode="true"/>
                <asp:BoundField DataFormatString="{0:d}" DataField="HireDate" HeaderText="Hire Date" HtmlEncode="true"/>
                <asp:BoundField DataField="Address" HeaderText="Address" HtmlEncode="true"/>
                <asp:BoundField DataField="City" HeaderText="City" HtmlEncode="true"/>
                <asp:BoundField DataField="Country" HeaderText="Country" HtmlEncode="true"/>
                <asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="true"/>
            </Fields>           
        </asp:DetailsView>
        <a href="Employees.aspx" runat="server">Back</a>
    </form>
</body>
</html>
