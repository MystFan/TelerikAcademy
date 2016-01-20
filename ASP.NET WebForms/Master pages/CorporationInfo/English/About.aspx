<%@ Page Title="" Language="C#" MasterPageFile="~/English/InfoEnglish.master" AutoEventWireup="true" 
    CodeBehind="About.aspx.cs" Inherits="CorporationInfo.English.About" %>

<asp:Content ID="ContentHeadAbout" ContentPlaceHolderID="ContentPlaceHolderEnglishHead" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
</asp:Content>

<asp:Content ID="ContentAbout" ContentPlaceHolderID="ContentPlaceHolderEnglishMain" runat="server">
    <div class="title">About us</div>
    <ul id="english-info-list">
        <li>Name: <strong>MyPlace</strong></li>
        <li>Employees: <strong>23</strong></li>
        <li>Address: <strong>Sofia</strong></li>
    </ul>
</asp:Content>
