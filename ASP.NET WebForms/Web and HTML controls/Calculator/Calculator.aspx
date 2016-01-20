<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="CalcStyle.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="FormCalculator" runat="server">
        <div id="DigitsDisplay" runat="server">
            <asp:TextBox ID="TextBoxDisplay" runat="server" ReadOnly="True"></asp:TextBox>
        </div>
        <div id="numberField" runat="server">
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server" ID="TableRow1">
                    <asp:TableCell runat="server" ID="TableCell1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="1" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell2">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="2" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell3">
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="3" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell4">
                        <asp:Button ID="ButtonAddition" runat="server" OnClick="Button4_Click" Text="+" Width="33px" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="TableRow2">
                    <asp:TableCell runat="server" ID="TableCell5">
                        <asp:Button ID="Button4" runat="server" OnClick="Button5_Click" Text="4" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell6">
                        <asp:Button ID="Button5" runat="server" OnClick="Button6_Click" Text="5" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell7">
                        <asp:Button ID="Button6" runat="server" OnClick="Button7_Click" Text="6" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell8">
                        <asp:Button ID="ButtonSubtraction" runat="server" OnClick="Button8_Click" Text="-" Width="33px" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="TableRow3">
                    <asp:TableCell runat="server" ID="TableCell9">
                        <asp:Button ID="Button7" runat="server" OnClick="Button9_Click" Text="7" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell10">
                        <asp:Button ID="Button8" runat="server" OnClick="Button10_Click" Text="8" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell11">
                        <asp:Button ID="Button9" runat="server" OnClick="Button11_Click" Text="9" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell12">
                        <asp:Button ID="ButtonMultiplication" runat="server" OnClick="Button12_Click" Text="X" Width="33px" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" ID="TableRow4">
                    <asp:TableCell runat="server" ID="TableCell13">
                        <asp:Button ID="ButtonClear" runat="server" OnClick="Button13_Click" Text="Clear" Width="42px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell14">
                        <asp:Button ID="Button0" runat="server" OnClick="Button14_Click" Text="0" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell15">
                        <asp:Button ID="ButtonDivision" runat="server" OnClick="Button15_Click" Text="/" Width="33px" />
                    </asp:TableCell>
                    <asp:TableCell runat="server" ID="TableCell16">
                        <asp:Button ID="ButtonSquareRoot" runat="server" OnClick="Button16_Click" Text="&radic;" Width="33px" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <div id="resultSubmit" runat="server">
            <asp:Button ID="ButtonSubmitResult" runat="server" Text="=" Width="93px" OnClick="ButtonSubmitResult_Click" />
        </div>
    </form>
    <h2>Allways push = to calculate result!</h2>
</body>
</html>
