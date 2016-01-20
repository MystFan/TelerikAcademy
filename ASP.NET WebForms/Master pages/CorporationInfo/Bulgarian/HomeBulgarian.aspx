<%@ Page Title="" Language="C#" MasterPageFile="~/Bulgarian/InfoBulgarian.master" AutoEventWireup="true" 
    CodeBehind="HomeBulgarian.aspx.cs" Inherits="CorporationInfo.Bulgarian.HomeBulgarian" %>

<asp:Content ID="ContentHeadBulgarian" ContentPlaceHolderID="ContentPlaceHolderBulgarianHead" runat="server">
    <link href="CorpStyle.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentBulgarian" ContentPlaceHolderID="ContentPlaceHolderBulgarianMain" runat="server">
     <div class="title">MyPlace Информация</div>
    <ul>
        <li><a href="About.aspx">За Нас</a></li>
        <li><a href="Contacts.aspx">Контакти</a></li>
    </ul>
</asp:Content>
