<%@ Page Title="" Language="C#" MasterPageFile="~/English/InfoEnglish.master" AutoEventWireup="true" 
    CodeBehind="HomeEnglish.aspx.cs" Inherits="CorporationInfo.English.HomeEnglish" %>

<asp:Content ID="ContentEnglishHead" ContentPlaceHolderID="ContentPlaceHolderEnglishHead" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
</asp:Content>

<asp:Content ID="ContentEnglish" ContentPlaceHolderID="ContentPlaceHolderEnglishMain" runat="server">
    <div class="title">MyPlace Info</div>
    <ul>
        <li><a href="About.aspx">About</a></li>
        <li><a href="Contacts.aspx">Contacts</a></li>
    </ul>
</asp:Content>
