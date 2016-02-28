<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsSystem.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>News System</h1>
    </div>

    <div class="row">
        <asp:ListView runat="server" ID="ListViewArticles"
            SelectMethod="ListViewArticles_GetData"
            ItemType="NewsSystem.Web.Models.Article"
            AutoGenerateColumns="False">

            <ItemTemplate>
                <div class="row">
                    <p>
                        <h4>
                            <asp:HyperLink ID="TitleHyperLink" NavigateUrl='<%#: "~/Categories?id=" + Item.Id %>' runat="server" Text='<%#: Item.Title %>' />
                            <asp:Label ID="CategoryTextBox" runat="server" Text='<%#: Item.Category.Name %>' />
                        </h4>
                    </p>
                    <p>
                        <asp:Label ID="ContentLabel" runat="server" Text='<%#: Item.Content %>' />
                    </p>
                    <p>
                        Likes:
                        <asp:Literal ID="LikesLiteral" Text="<%# Item.Likes.Count() %>" runat="server" />
                    </p>
                    <p>
                        by
                        <asp:Literal ID="LiteralUser" Text="<%#: Item.Author.UserName %>" runat="server" />
                        created on:
                        <asp:Literal ID="LiteralDate" Text="<%#: Item.CreatedOn %>" runat="server" />
                    </p>
                </div>
            </ItemTemplate>

            <LayoutTemplate>
                <div id="itemPlaceholder" runat="server"></div>
            </LayoutTemplate>

        </asp:ListView>
    </div>

    <div class="row">
        <h1>All Categories</h1>
        <div class="col-md-4">
            <asp:ListView runat="server" ID="ListViewCategories"
                SelectMethod="ListViewCategories_GetData"
                ItemType="NewsSystem.Web.Models.CategoryHomeViewModel"
                AutoGenerateColumns="False">

                <ItemTemplate>
                    <p>
                        <h3>
                            <asp:Label ID="CategoryTextBox" runat="server" Text='<%#: Item.CategoryName %>' />
                        </h3>
                        <ul>
                            <asp:Repeater ID="ArticlesRepeater" runat="server" DataSource="<%# Item.Articles %>" 
                                ItemType="NewsSystem.Web.Models.Article">
                                <ItemTemplate>
                                    <li><asp:HyperLink runat="server" NavigateUrl='<%#: "~/ArticleDetails.aspx?id=" + Item.Id %>' Text="<%#: Item.Title %>" ID="HyperLinkArticle">
                                        </asp:HyperLink> 
                                        by <strong><%#: Item.Author.UserName %></strong></li>
                                </ItemTemplate>
                            </asp:Repeater>
                        </ul>
                    </p>
                </ItemTemplate>

                <EmptyDataTemplate>
                    No Categories
                </EmptyDataTemplate>

                <LayoutTemplate>
                    <div id="itemPlaceholder" runat="server"></div>
                </LayoutTemplate>

            </asp:ListView>
        </div>
    </div>

</asp:Content>
