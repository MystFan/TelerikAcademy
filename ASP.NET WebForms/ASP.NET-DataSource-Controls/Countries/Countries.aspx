<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="Countries.Countries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, td, th {
            border: 1px solid black;
            border-collapse: collapse;
            text-align:center;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

        <asp:EntityDataSource ID="EntityDataSourceContinents" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EntitySetName="Continents"
            EnableFlattening="false" />

        <h1>Continents</h1>

        <asp:ListBox ID="ListBoxContinents" runat="server"
            DataSourceID="EntityDataSourceContinents"
            DataTextField="Name" DataValueField="Id"
            Rows="10" AutoPostBack="True" />

        <h1>Countries</h1>

        <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EntitySetName="Countries"
            Where="it.ContinentId=@ContID">
            <WhereParameters>
                <asp:ControlParameter Name="ContID" Type="Int32"
                    ControlID="ListBoxContinents" />
            </WhereParameters>
        </asp:EntityDataSource>

        <asp:GridView ID="GridViewCountries" runat="server"
            DataSourceID="EntityDataSourceCountries"
            AutoGenerateColumns="False" 
            DataKeyNames="Id"
            PageSize="3"
            AllowPaging="True" 
            AllowSorting="True"
            OnPageIndexChangeding="GridViewCountries_PageIndexChanging">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Country name" SortExpression="Name" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" />
            </Columns>
        </asp:GridView>


        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EntitySetName="Towns"
            Where="it.CountryId=@CountryID" EnableFlattening="False">
            <WhereParameters>
                <asp:ControlParameter Name="CountryID" Type="Int32"
                    ControlID="GridViewCountries" />
            </WhereParameters>
        </asp:EntityDataSource>

        <asp:ListView ID="ListView" runat="server"
            ItemType="Countries.Town" DataSourceID="EntityDataSourceTowns">

            <LayoutTemplate>
                <h1>Country Towns</h1>

                <table>
                    <tr>
                        <th>Name</th>
                        <th>Population</th>
                    </tr>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <%#: Item.Name %>
                    </td>
                    <td>
                        <%#: Item.Population %>
                    </td>
                </tr>
            </ItemTemplate>

        </asp:ListView>

        <asp:HyperLink runat="server" ID="HyperLinkEdit" NavigateUrl="~/Edit.aspx" Text="Go To Edit/Insert/Delete Page">

        </asp:HyperLink>
    </form>
</body>
</html>
