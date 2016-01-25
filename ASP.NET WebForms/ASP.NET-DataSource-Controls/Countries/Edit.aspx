<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Countries.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Message{
            color:crimson;
        }

        .flag{
            width: 30px;
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="Message" runat="server" Visible="false">

        </h1>

        <h1>Continents</h1>

        <asp:ListView ID="ListViewUpdateContinents" runat="server"
            DataSourceID="EntityDataSourceUpdateContinents" DataKeyNames="Id" InsertItemPosition="LastItem"
            OnItemUpdating="ListViewUpdateContinents_ItemUpdating"
            OnItemInserting="ListViewUpdateContinents_ItemInserting"
            ItemType="Countries.Continent">
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF; color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF; color: #333333;">
                                    <th runat="server"></th>
                                    <th runat="server">Name</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #FFFFFF">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6; font-weight: bold; color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>

        <asp:EntityDataSource ID="EntityDataSourceUpdateContinents" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EnableDelete="True"
            EnableFlattening="False"
            EnableInsert="True"
            EnableUpdate="True"
            EntitySetName="Continents">
        </asp:EntityDataSource>

        <h1>Countries</h1>

        <asp:ListView ID="ListViewCountries" runat="server"
            DataSourceID="EntityDataSourceCountries" DataKeyNames="Id"
            InsertItemPosition="LastItem" ItemType="Countries.Country"
            OnItemUpdating="ListViewCountries_ItemUpdating"
            OnItemInserting="ListViewCountries_ItemInserting">


            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LanguageTextBox" runat="server" Text='<%# Bind("Language") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="ContinentIdDropDownList" runat="server"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# Bind("ContinentId")  %>'
                            DataSourceID="EntityDataSourceGetContinentsData"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:FileUpload ID="FlagUpdateFileUpload" runat="server" />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="LanguageTextBox" runat="server" Text='<%# Bind("Language") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="ContinentIdDropDownList" runat="server"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# Bind("ContinentId")  %>'
                            DataSourceID="EntityDataSourceGetContinentsData"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:FileUpload ID="FlagFileUpload" runat="server" />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF; color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LanguageLabel" runat="server" Text='<%# Eval("Language") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ContinentIdLabel" runat="server" Text='<%# Eval("ContinentId") %>' />
                    </td>
                    <td>
                         <asp:Image ID="FlagImage" runat="server" CssClass="flag" ImageUrl='<%#: ProcessMyDataItem(Eval("Flag")) %>'/>
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                    <th runat="server"></th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Language</th>
                                    <th runat="server">Population</th>
                                    <th runat="server">ContinentId</th>
                                    <th runat="server">Flag</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6; font-weight: bold; color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="LanguageLabel" runat="server" Text='<%# Eval("Language") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="ContinentIdDropDownList" runat="server"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# Bind("ContinentId")  %>'
                            DataSourceID="EntityDataSourceGetContinentsData"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="FlagLabel" runat="server" Text='<%# Eval("Flag") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>

        </asp:ListView>

        <asp:EntityDataSource ID="EntityDataSourceCountries" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EnableDelete="True" EnableFlattening="False"
            EnableInsert="True" EnableUpdate="True"
            EntitySetName="Countries"
            Include="Continent">
        </asp:EntityDataSource>

        <asp:EntityDataSource ID="EntityDataSourceGetContinentsData" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EnableFlattening="False" EntitySetName="Continents"
            Select="it.[Id], it.[Name]">
        </asp:EntityDataSource>

        <h1>Towns</h1>

        <asp:ListView ID="ListViewTowns" runat="server"
            DataSourceID="EntityDataSourceTowns" DataKeyNames="Id" InsertItemPosition="LastItem"
            OnItemUpdating="ListViewTowns_ItemUpdating"
            OnItemInserting="ListViewTowns_ItemInserting">
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    </td>
                    <td>
                         <asp:DropDownList ID="CountryIdDropDownList" runat="server"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# Bind("CountryId")  %>'
                            DataSourceID="EntityDataSourceGetCountriesData"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="CountryIdDropDownList" runat="server"
                            AppendDataBoundItems="true"
                            SelectedValue='<%# Bind("CountryId")  %>'
                            DataSourceID="EntityDataSourceGetCountriesData"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                    <th runat="server"></th>
                                    <th runat="server">Name</th>
                                    <th runat="server">Population</th>
                                    <th runat="server">CountryId</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%# Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryIdLabel" runat="server" Text='<%# Eval("CountryId") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>

        </asp:ListView>

        <asp:EntityDataSource ID="EntityDataSourceTowns" runat="server" 
            ConnectionString="name=CountriesEntities" 
            DefaultContainerName="CountriesEntities" 
            EnableDelete="True" 
            EnableFlattening="False" 
            EnableInsert="True" 
            EnableUpdate="True" 
            EntitySetName="Towns"
            Include="Country">
        </asp:EntityDataSource>

        <asp:EntityDataSource ID="EntityDataSourceGetCountriesData" runat="server"
            ConnectionString="name=CountriesEntities"
            DefaultContainerName="CountriesEntities"
            EnableFlattening="False" 
            EntitySetName="Countries" 
            Select="it.[Id], it.[Name]">
        </asp:EntityDataSource>
    </form>
</body>
</html>
