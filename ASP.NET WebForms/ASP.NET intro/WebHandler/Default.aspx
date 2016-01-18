<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebHandler._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="row" runat="server">
                <div class="form-control">
                    <asp:Label ID="LabelText" runat="server" AssociatedControlID="TextBox" Text="Text"></asp:Label>
                    <asp:TextBox ID="TextBox" runat="server"  type="text"></asp:TextBox>
                </div>
                <div class="form-control">
                    <asp:Label ID="LabelTextWidth" runat="server" AssociatedControlID="TextWidth" Text="Text width"></asp:Label>
                    <asp:TextBox ID="TextWidth" runat="server" type="number" min="100" MaxLength="1000" step="50" />
                </div>
                    <asp:Button ID="GetText" runat="server" Text="Convert" OnClick="GetText_Click" />
            </div>
        </div>
    </div>

</asp:Content>
