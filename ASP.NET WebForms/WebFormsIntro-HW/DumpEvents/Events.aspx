<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="DumpEvents.Events" ViewStateMode="Enabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="Body" runat="server">
    <h1> In Page PreRender change background color</h1>
    <form id="formEvents" runat="server">
    <div>
        <asp:Label ID="Label" runat="server">Event between Page load and PreRender</asp:Label>
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button" runat="server" Text="Submit" OnClick="Button_Click" />
    </div>
    </form>
</body>
</html>
