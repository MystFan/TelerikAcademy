<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="NewsSystem.Web.ArticleDetails" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DetailsView runat="server" ID="DetailsView"
                SelectMethod="DetailsView_GetItem"
                ItemType="NewsSystem.Web.Models.Article"
                AutoGenerateRows="false">
                <Fields>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Content" HeaderText="Content" />
                    <asp:BoundField DataField="Category.Name" HeaderText="Category" />
                    <asp:BoundField DataField="Author.UserName" HeaderText="Author" />
                    <asp:BoundField DataField="CreatedOn" HeaderText="Date" DataFormatString="{0:d}" />
                </Fields>
            </asp:DetailsView>
        </ContentTemplate>
    </asp:UpdatePanel>



    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Panel runat="server" ID="FormViewVote">
                <p>
                    <asp:Button ID="LikeButton" Text="Like" runat="server" OnClick="LikeButton_Click" />
                </p>
                <p>
                    <asp:Button ID="DislikeButton" Text="Dislike" runat="server" OnClick="DislikeButton_Click" />
                </p>
            </asp:Panel> 

        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:DetailsView ID="DetailsViewLikes" runat="server" SelectMethod="DetailsView_GetItem"
                ItemType="NewsSystem.Web.Models.Article"
                AutoGenerateRows="false">
                <Fields>
                    <asp:BoundField DataField="Likes.Count" HeaderText="Likes" />
                </Fields>
            </asp:DetailsView>


        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="LikeButton" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
