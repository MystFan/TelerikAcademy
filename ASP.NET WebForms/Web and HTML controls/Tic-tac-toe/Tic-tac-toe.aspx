<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tic-tac-toe.aspx.cs" Inherits="Tic_tac_toe.Tic_tac_toe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic-tac-toe</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="FormTicTacToe" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Width="33px" SkinID="cell" position="1"/>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Width="33px" SkinID="cell" position="2"/>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Width="33px" SkinID="cell" position="3"/>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Width="33px" SkinID="cell" position="4"/>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Width="33px" SkinID="cell" position="5"/>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Width="33px" SkinID="cell" position="6"/>
        <br />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Width="33px" SkinID="cell" position="7"/>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Width="33px" SkinID="cell" position="8"/>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Width="33px" SkinID="cell" position="9"/>
    </form>
</body>
</html>
