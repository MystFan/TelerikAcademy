<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArticlesControl.ascx.cs" 
    Inherits="WebFormsApplicationCache.ArticlesControl" %>

<%@ OutputCache Duration="60" VaryByParam="none" Shared="true"  %>

<div class="row">
    <h4>Update every minute</h4>
    Time: <%= DateTime.UtcNow %>
    <asp:Repeater runat="server" ItemType="WebFormsApplicationCache.Article" ID="ArticlesContainer">
        <ItemTemplate>
            <div class="col-md-8">
                <div><%#: Item.Text %></div>
                <span>creator: <%#: Item.Creator %></span>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
