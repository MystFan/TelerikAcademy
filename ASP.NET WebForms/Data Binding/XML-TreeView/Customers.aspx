<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="XML_TreeView.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="FormCustomers" runat="server">
        <div>
            <asp:XmlDataSource ID="XmlDataSourceCustomers" runat="server" DataFile="~/Xml/customers.xml"></asp:XmlDataSource>
            <asp:TreeView ID="TreeViewCustomers" runat="server" DataSourceID="XmlDataSourceCustomers" ShowLines="true">

                <DataBindings>
                    <asp:TreeNodeBinding DataMember="Customer" TextField="Name" ValueField="CustomerId" />
                    <asp:TreeNodeBinding DataMember="Order" TextField="ShipDate" ValueField="OrderId" />
                    <asp:TreeNodeBinding DataMember="OrderItem" TextField="PartDesc" ValueField="OrderItemId" />
                    <asp:TreeNodeBinding DataMember="Invoice" TextField="Amount" ValueField="InvoiceId" />
                </DataBindings>

            </asp:TreeView>
        </div>
    </form>
</body>
</html>
