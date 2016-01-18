<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintName.aspx.cs" Inherits="PrintName.PrintName" 
    validateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formPrintName" runat="server">
    <div>
    
        <asp:Label ID="LabelName" runat="server" AssociatedControlID="TextBoxName" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonName" runat="server" Text="Print Name" OnClick="ButtonName_Click" />
    
    </div>
    </form>
</body>
</html>
