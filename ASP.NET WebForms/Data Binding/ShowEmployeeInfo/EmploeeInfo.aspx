<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmploeeInfo.aspx.cs" Inherits="ShowEmployeeInfo.EmploeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employees Info</title>
    <script src="js/jquery.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link href="css/site.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3>Employees Sorting</h3>

            <asp:ListView ID="ListViewEmployees" runat="server"
                ItemType="DataNorthwind.Employee"
                OnSorting="ListViewEmployees_Sorting">

                <LayoutTemplate>
                    <table class="table" width="640px" runat="server" id="tblContacts">
                        <tr class="header" align="center" runat="server">
                            <td>
                                <asp:LinkButton runat="server" ID="SortByFirstNameButton"
                                    CommandName="Sort" Text="First Name"
                                    CommandArgument="FirstName" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByLastNameButton"
                                    CommandName="Sort" Text="Last Name"
                                    CommandArgument="LastName" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByJobButton"
                                    CommandName="Sort" Text="Job Title"
                                    CommandArgument="Title" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByBirthDateButton"
                                    CommandName="Sort" Text="Birth Date"
                                    CommandArgument="BirthDate" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByHireDateButton"
                                    CommandName="Sort" Text="Hire Date"
                                    CommandArgument="HireDate" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByCityButton"
                                    CommandName="Sort" Text="City"
                                    CommandArgument="City" />
                            </td>
                            <td>
                                <asp:LinkButton runat="server" ID="SortByCountryButton"
                                    CommandName="Sort" Text="Country"
                                    CommandArgument="Country" />
                            </td>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                    </table>
                </LayoutTemplate>

                <ItemTemplate>
                    <tr runat="server">
                        <td>
                            <asp:Label ID="FirstNameLabel" runat="server" Text='<%#: Item.FirstName %>' />
                        </td>
                        <td>
                            <asp:Label ID="LastNameLabel" runat="server" Text='<%#: Item.LastName %>' />
                        </td>
                        <td>
                            <asp:Label ID="JobLabel" runat="server" Text='<%#: Item.Job %>' />
                        </td>
                        <td>
                            <asp:Label ID="BirthDateLabel" runat="server" Text='<%#: Item.BirthDate %>' />
                        </td>
                        <td>
                            <asp:Label ID="HireDateLabel" runat="server" Text='<%#: Item.HireDate %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%#: Item.City %>' />
                        </td>
                        <td>
                            <asp:Label ID="CountryLabel" runat="server" Text='<%#: Item.Country %>' />
                        </td>
                    </tr>
                </ItemTemplate>

            </asp:ListView>

            <asp:DataPager ID="DataPagerEmployees" runat="server"
                PagedControlID="ListViewEmployees" PageSize="10"
                QueryStringField="page">
                <Fields>
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-info" ShowFirstPageButton="true"
                        ShowNextPageButton="false" ShowPreviousPageButton="false" />
                    <asp:NumericPagerField NumericButtonCssClass="btn btn-info" />
                    <asp:NextPreviousPagerField ButtonCssClass="btn btn-info" ShowLastPageButton="true"
                        ShowNextPageButton="false" ShowPreviousPageButton="false" />
                </Fields>
            </asp:DataPager>
        </div>
    </form>
    <div id="popUp"></div>
    <script src="js/pop-up.js"></script>
</body>
</html>
