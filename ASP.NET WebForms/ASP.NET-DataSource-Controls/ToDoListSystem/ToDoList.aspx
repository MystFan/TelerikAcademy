﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToDoList.aspx.cs" Inherits="ToDoListSystem.ToDoList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:HyperLink ID="HyperLinkAddToDo" runat="server" NavigateUrl="~/AddTODO.aspx">
                <h1>Add new TODO</h1>
            </asp:HyperLink>

            <asp:HyperLink ID="HyperLinkAddCategory" runat="server" NavigateUrl="~/AddCategory.aspx">
                <h1>Add new Category</h1>
            </asp:HyperLink>

            <asp:ListView ID="ListView" runat="server"
                SelectMethod="GetTodos"
                UpdateMethod="GridViewToDos_UpdateItem"
                DeleteMethod="GridViewToDos_DeleteItem"
                ItemType="ToDoSystem.Models.ToDo"
                AllowPaging="True" AllowSorting="True"
                DataKeyNames="Id"
                PageSize="5"
                AutoGenerateEditButton="True"
                AutoGenerateDeleteButton="True"
                AutoGenerateColumns="False">

                <EditItemTemplate>
                    <tr style="background-color: #999999;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:TextBox ID="TitleTextBox" runat="server" Text='<%#: Item.Title %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="BodyTextBox" runat="server" Text='<%#: Item.Body %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="DateTextBox" ReadOnly="true" runat="server" Text='<%#: Item.LastChangeDate %>' />
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownListCategories" runat="server" ItemType="ToDoSystem.Models.Category"
                                SelectMethod="GetCategories" AppendDataBoundItems="true"
                                DataValueField="Id" DataTextField="Name">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </EditItemTemplate>

                <ItemTemplate>
                    <tr style="background-color: #E0FFFF; color: #333333;">
                        <td>
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                        </td>
                        <td>
                            <asp:Label ID="TitleLabel" runat="server" Text='<%#: Item.Title %>' />
                        </td>
                        <td>
                            <asp:Label ID="BodyLabel" runat="server" Text='<%#: Item.Body %>' />
                        </td>
                        <td>
                            <asp:Label ID="DateLabel" runat="server" Text='<%#: Item.LastChangeDate %>' />
                        </td>
                        <td>
                            <asp:Label ID="CategoryNameLabel" runat="server" Text='<%#: Item.Category.Name %>' />
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
                                        <th runat="server">Title</th>
                                        <th runat="server">Content</th>
                                        <th runat="server">Date</th>
                                        <th runat="server">Category</th>
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
            </asp:ListView>
        </div>
    </form>
</body>
</html>
