<%@ Page Title="" Language="C#" MasterPageFile="~/Bulgarian/InfoBulgarian.master" AutoEventWireup="true" 
    CodeBehind="About.aspx.cs" Inherits="CorporationInfo.Bulgarian.About" %>

<asp:Content ID="ContentHeadBulgarian" ContentPlaceHolderID="ContentPlaceHolderBulgarianHead" runat="server">
    <link href="CorpStyle.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentBulgarianAbout" ContentPlaceHolderID="ContentPlaceHolderBulgarianMain" runat="server">
        <div class="title">За Нас</div>
    <ul id="english-info-list">
        <li>Име: <strong>MyPlace</strong></li>
        <li>Служители: <strong>23</strong></li>
        <li>Адрес: <strong>Sofia</strong></li>
    </ul>
</asp:Content>
