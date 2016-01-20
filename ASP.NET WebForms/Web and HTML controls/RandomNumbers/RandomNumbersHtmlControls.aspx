<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumbersHtmlControls.aspx.cs" Inherits="RandomNumbers.RandomNumbersHtmlControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Numbers</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <h1>Random Numbers Html Controls</h1>
    <form id="formRandomNums" runat="server">
        <div>
            <label id="LabelFirstNumber" for="TextBoxFirstNumber" runat="server">From Number: </label>
            <input id="TextBoxFirstNumber" runat="server" />
            <label id="LabelSecondNumber" for="TextBoxSecondNumber" runat="server">To Number: </label>
            <input id="TextBoxSecondNumber" runat="server" />
            <br />
            <input type="submit" id="ButtonSubmit" onserverclick="GenerateRandomNumber_Click" runat="server" value="Submit" />
            <br />
            <label id="LabelRandomNumber" for="TextBoxResult" runat="server">Random Number: </label>
            <input id="TextBoxRandomNumber" runat="server" readonly="true" />
        </div>
    </form>
    <a href="RandomNumbersWebControls.aspx">Random Numbers Web Controls</a>
</body>
</html>
