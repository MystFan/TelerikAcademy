<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarSaler.aspx.cs" Inherits="CarsSystem.CarSeler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cars</title>
    <link href="CarSearchStyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <asp:Literal ID="LiteralContainer" runat="server"></asp:Literal>
    <form id="formCarSaler" runat="server">
        <div class="select">
            <asp:Label ID="LabelProducers" runat="server">Producers: </asp:Label>
            <asp:DropDownList ID="DropDownListProducers" runat="server" OnSelectedIndexChanged="DropDownListProducers_SelectedIndexChanged" AutoPostBack="True"
                DataTextField="Name" DataValueField="Name">
            </asp:DropDownList>
        </div>
        <div class="select">
            <asp:Label ID="LabelModels" runat="server">Models: </asp:Label>
            <asp:DropDownList ID="DropDownListModels" runat="server">
            </asp:DropDownList>
        </div>
        <asp:RadioButtonList ID="RadioButtonListEnginType" runat="server">
            <asp:ListItem Value="Gas">Gas</asp:ListItem>
            <asp:ListItem Value="Disel">Disel</asp:ListItem>
        </asp:RadioButtonList>
        <asp:CheckBoxList ID="CheckBoxListExtres" runat="server">
        </asp:CheckBoxList>
        <asp:Button ID="ButtonSubmit" runat="server"  OnClick="ButtonSubmit_Click" Text="Search"/>
    </form>
</body>
</html>
