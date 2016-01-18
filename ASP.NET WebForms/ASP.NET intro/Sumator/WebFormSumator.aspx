<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSumator.aspx.cs" Inherits="Sumator.WebFormSumator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sumator</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="CalcForm" runat="server">
        <asp:Label ID="LabelFirstNumber" runat="server" AssociatedControlID="TextBoxFirstNumber" Text="First Number:"></asp:Label>
        <asp:TextBox ID="TextBoxFirstNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelSecondNumber" runat="server" AssociatedControlID="TextBoxSecondNumber" Text="Second Number:"></asp:Label>
        <asp:TextBox ID="TextBoxSecondNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
        <br />
        Result:
        <asp:TextBox ID="TextBoxResult" runat="server" ReadOnly="True"></asp:TextBox>
    </form>
</body>
</html>
