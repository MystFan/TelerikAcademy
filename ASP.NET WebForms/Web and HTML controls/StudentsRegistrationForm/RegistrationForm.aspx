<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="StudentsRegistrationForm.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <meta name="description" content="The description of my page" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>

    <form id="FormStudent" runat="server">
        <div id="FormContent" runat="server">
            <asp:Label ID="LabelFirstName" runat="server" AssociatedControlID="TextBoxFirstName" Text="First Name: "></asp:Label>
            <asp:TextBox ID="TextBoxFirstName" runat="server" Mode="Encode"></asp:TextBox>
            <br />
            <asp:Label ID="LabelSecondName" runat="server" AssociatedControlID="TextBoxSecondName" Text="Second Name: "></asp:Label>
            <asp:TextBox ID="TextBoxSecondName" runat="server" Mode="Encode"></asp:TextBox>
            <br />
            <asp:Label ID="LabelFacultyNumber" runat="server" AssociatedControlID="TextBoxFacultyNumber" Text="Faculty Number: "></asp:Label>
            <asp:TextBox ID="TextBoxFacultyNumber" runat="server" MaxLength="8" Mode="Encode"></asp:TextBox>
            <br />
            <asp:Label ID="LabelUni" runat="server" Text="University: "></asp:Label>
            <asp:DropDownList ID="DropDownListUni" runat="server" OnTextChanged="DropDownListUni_TextChanged" AutoPostBack="True">
                <asp:ListItem Value="University of Oxford">University of Oxford</asp:ListItem>
                <asp:ListItem Value="Harvard University">Harvard University</asp:ListItem>
                <asp:ListItem Value="Stanford University">Stanford University</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
    </form>
</body>
</html>
