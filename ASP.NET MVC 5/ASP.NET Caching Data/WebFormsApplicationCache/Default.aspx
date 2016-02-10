<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApplicationCache._Default" %>

<%@ Register Src="~/ArticlesControl.ascx" TagPrefix="articles" TagName="ArticlesControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <articles:ArticlesControl runat="server" />
    </div>
</asp:Content>
