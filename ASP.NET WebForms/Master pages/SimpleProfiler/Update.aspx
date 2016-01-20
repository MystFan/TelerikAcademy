<%@ Page Title="" Language="C#" MasterPageFile="~/MyPlace.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="SimpleProfiler.Update" %>

<asp:Content ID="ContentUpdateHead" ContentPlaceHolderID="head" runat="server">
    <link href="update-page.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="ContentUpdateProfile" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <fieldset>
        <legend>Update Profile</legend>
        <div>
            <label for="firstName">First name:</label>
            <input id="firstName" type="text" placeholder="First name" />
        </div>
        <div>
            <label for="lastName">Last name:</label>
            <input id="lastName" type="text" placeholder="Last name" />
        </div>
        <div>
            <label>Age:</label>
            <input type="number" min="1" max="110" />
        </div>
        <div>
            <label>Place:</label>
            <input type="text" placeholder="Place" />
        </div>
    </fieldset>
</asp:Content>
