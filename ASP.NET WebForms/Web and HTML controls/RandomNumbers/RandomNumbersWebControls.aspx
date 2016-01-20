<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbersWebControls.aspx.cs" Inherits="RandomNumbers.RandomNumbersWebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random number</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <h1>Random number Web Controls</h1>
    <form id="formRandomNums" runat="server">
        <div>
            <asp:Label ID="LabelFirstNumber" runat="server" AssociatedControlID="TextBoxFirstNumber" Text="From number:"></asp:Label>
            <asp:TextBox ID="TextBoxFirstNumber" runat="server" CausesValidation="True"></asp:TextBox>
            <br />
            <asp:Label ID="LabelFirstNumber0" runat="server" AssociatedControlID="TextBoxSecondNumber" Text="To number:"></asp:Label>
            <asp:TextBox ID="TextBoxSecondNumber" runat="server" CausesValidation="True"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonRandomNumber" runat="server" OnClick="ButtonRandomNumber_Click" Text="Random" />
            <br />
            <asp:Label ID="LabelResult" runat="server" AssociatedControlID="TextBoxResult" Text="Result:"></asp:Label>
            <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
