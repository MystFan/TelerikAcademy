<%@ Page Title="" Language="C#" MasterPageFile="~/English/InfoEnglish.master" AutoEventWireup="true" 
    CodeBehind="Contacts.aspx.cs" Inherits="CorporationInfo.English.Contacts" %>

<asp:Content ID="ContentHeadEnglishContacts" ContentPlaceHolderID="ContentPlaceHolderEnglishHead" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
</asp:Content>

<asp:Content ID="ContentEnglishContacts" ContentPlaceHolderID="ContentPlaceHolderEnglishMain" runat="server">
    <div class="title">Contacts</div>
    <ul id="english-contacts-list">
        <li>Address: <strong>Bulgaria Sofia str.Al.Malinov 31</strong></li>
        <li>Tel: <strong>359-0934753459</strong></li>
        <li>Web page: <strong>www.myplace.com</strong></li>
    </ul>
</asp:Content>
