<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlEscaping.aspx.cs" Inherits="Escaping.HtmlEscaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Html escaping</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="FormDisplayText" runat="server">
        <div id="container" runat="server">
            <asp:Label ID="LabelText" runat="server" AssociatedControlID="TextBoxText" Text="Enter Some Text:"></asp:Label>
            <asp:TextBox ID="TextBoxText" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
            <br />
        </div>
        <br />
        <asp:Label ID="LabelEscape" runat="server" AssociatedControlID="TextBoxEscape" Mode="Encode"></asp:Label>
        <asp:TextBox ID="TextBoxEscape" runat="server" Mode="Encode"></asp:TextBox>
        <br />
        <br />
        Text box: <%: this.TextBoxEscape.Text %>
        <br />
        Label: <%: this.LabelEscape.Text %>
    </form>
</body>
</html>
