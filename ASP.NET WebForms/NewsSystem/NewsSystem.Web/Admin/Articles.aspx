<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="NewsSystem.Web.Admin.Articles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:ListView ID="ListViewArticles" runat="server"
        ItemType="NewsSystem.Web.Models.Article"
        DataKeyNames="Id"
        AllowPaging="True"
        AllowSorting="True"
        SelectMethod="ListViewAericles_GetData"
        InsertMethod="ListViewAericles_InsertItem"
        DeleteMethod="ListViewAericles_DeleteItem"
        UpdateMethod="ListViewAericles_UpdateItem"
        OnItemCanceling="ListViewArticles_ItemCanceling"
        AutoGenerateColumns="False">

        <LayoutTemplate>
            <div class="row">
                <asp:HyperLink NavigateUrl="?orderBy=Title" CssClass="btn btn-md-2 btn-default" Text="Sort by Title" runat="server" />
                <asp:HyperLink NavigateUrl="?orderBy=CreatedOn" CssClass="btn btn-md-2  btn-default" Text="Sort by Date" runat="server" />
                <asp:HyperLink NavigateUrl="?orderBy=Category.Name" CssClass="btn btn-md-2  btn-default" Text="Sort by Category" runat="server" />
                <asp:HyperLink NavigateUrl="?orderBy=Likes.Count()" CssClass="btn btn-md-2  btn-default" Text="Sort by Likes" runat="server" />
            </div>
            <div runat="server" id="itemPlaceholder"></div>
            <div class="row">
                <asp:Button ID="ButtonNewArticle" runat="server" Text="Insert new Article" CssClass="btn btn-primary" OnClick="ButtonNewArticle_Click" />
            </div>
            <asp:DataPager ID="DataPager1" PageSize="3" runat="server">
                <Fields>
                    <asp:NextPreviousPagerField ButtonType="Button" ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ButtonType="Button" ShowNextPageButton="true" ShowPreviousPageButton="false" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>

        <EditItemTemplate>
            <div class="row">
                <h1>Edit article</h1>
                <div class="col-md-6">
                    <div class="form-group">
                        <strong>
                            <asp:Label Text="Title" runat="server" /></strong>
                        <asp:TextBox ID="TextBoxUpdate" Text="<%#: Item.Title %>" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <asp:DropDownList ID="DropDownListCategories" CssClass="form-control" runat="server" ItemType="NewsSystem.Web.Models.Category"
                            SelectMethod="GetCategories" AppendDataBoundItems="true"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        Content
                        <asp:TextBox runat="server" ID="TextBoxContent" Rows="5" Text="<%#: Item.Content %>" CssClass="form-control" TextMode="MultiLine" />
                    </div>
                    <div class="form-group">

                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" CssClass="btn btn-success" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>

        </EditItemTemplate>

        <InsertItemTemplate>
            <div class="row">
                <h1>Insert article</h1>
                <div class="col-md-6">
                    <div class="form-group">
                        <strong>
                            <asp:Label Text="Title" runat="server" /></strong>
                        <asp:TextBox ID="TextBoxInsert" Text="<%#: BindItem.Title %>" runat="server" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <asp:DropDownList ID="DropDownListCategoriesInsert" CssClass="form-control" runat="server" ItemType="NewsSystem.Web.Models.Category"
                            SelectMethod="GetCategories" AppendDataBoundItems="true"
                            DataValueField="Id" DataTextField="Name">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        Content
                        <asp:TextBox runat="server" ID="TextBoxContentInsert" Rows="5" Text="<%#: BindItem.Content %>" CssClass="form-control" TextMode="MultiLine" />
                    </div>
                    <div class="form-group">

                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" CssClass="btn btn-success" />
                        <asp:Button ID="CancelInsertButton" runat="server" CommandName="Cancel" Text="Cancel" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>
        </InsertItemTemplate>

        <ItemTemplate>
            <div>
                <h3>
                    <%#: Item.Title %>
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" CssClass="btn btn-danger" />
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" CssClass="btn btn-primary" />
                </h3>
                <p>
                    Category: <%#: Item.Category.Name %>
                </p>
                <p>
                    <%#: Item.Content %>
                </p>
                <p>
                    Likes count: <%#: Item.Likes.Count %>
                </p>
                <p>
                    by <%#: Item.Author.UserName %>  created on <%#: Item.CreatedOn %>
                </p>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
