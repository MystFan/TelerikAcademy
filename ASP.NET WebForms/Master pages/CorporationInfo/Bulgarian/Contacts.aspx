<%@ Page Title="" Language="C#" MasterPageFile="~/Bulgarian/InfoBulgarian.master" AutoEventWireup="true" 
    CodeBehind="Contacts.aspx.cs" Inherits="CorporationInfo.Bulgarian.Contacts" %>

<asp:Content ID="ContentHeadContacts" ContentPlaceHolderID="ContentPlaceHolderBulgarianHead" runat="server">
    <link href="CorpStyle.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentContacts" ContentPlaceHolderID="ContentPlaceHolderBulgarianMain" runat="server">
        <div class="title">Контакти</div>
    <ul id="english-contacts-list">
        <li>Адрес: <strong>България София ул.Ал.Малинов 31</strong></li>
        <li>Телефон: <strong>359-0934753459</strong></li>
        <li>Уеб страница: <strong>www.myplace.com</strong></li>
    </ul>
</asp:Content>
