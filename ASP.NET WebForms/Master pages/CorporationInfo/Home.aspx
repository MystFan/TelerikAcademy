<%@ Page Title="" Language="C#" MasterPageFile="~/Corporation.Master" 
    AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CorporationInfo.Home" %>

<asp:Content ID="ContentHeadHome" ContentPlaceHolderID="head" runat="server">
    <link href="CorpStyle.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentHome" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="title">Language</div>
    <ul id="myMenu">
        <li><a href="~/English/HomeEnglish.aspx" runat="server">English</a></li>
        <li><a href="~/Bulgarian/HomeBulgarian.aspx" runat="server">Bulgarian</a></li>
    </ul>
</asp:Content>
