<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="DirectoryFiles.aspx.cs" Inherits="WebFormsApplicationCache.DirectoryFiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <ul>
        <% foreach (var filePath in (List<string>)this.GetFilePaths())
            { %>

            <li><%= filePath %></li>

      <% } %>
    </ul>
</asp:Content>
