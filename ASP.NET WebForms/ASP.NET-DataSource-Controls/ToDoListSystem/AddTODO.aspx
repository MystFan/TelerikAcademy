<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTODO.aspx.cs" Inherits="ToDoListSystem.TODOlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <style>
        .container {
            margin-top: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div>
                <asp:Label ID="LabelToDoTitle" AssociatedControlID="TextBoxToDoTitle" runat="server" Text="Title"></asp:Label>
                <asp:TextBox ID="TextBoxToDoTitle" runat="server"></asp:TextBox>
            </div>

            <asp:Label ID="LabelToDoBody" AssociatedControlID="TextAriaToDoBody" runat="server" Text="Content"></asp:Label>
            <textarea id="TextAriaToDoBody" runat="server" cols="20" rows="5"></textarea>
            <br />
            <asp:Label ID="LabelCategories" AssociatedControlID="DropDownListCategories" runat="server" Text="Categories"></asp:Label>
            <asp:DropDownList ID="DropDownListCategories"
                ItemType="ToDoSystem.Models.Category"
                SelectMethod="GetCategories"
                DataTextField="Name"
                DataValueField="Id"
                runat="server">
            </asp:DropDownList>
            <asp:Button ID="ButtonAddToDo" runat="server" OnClick="ButtonAddToDo_Click" Text="Add TODO" />
        </div>
        <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="~/ToDoList.aspx">
                <h1>Back</h1>
        </asp:HyperLink>

    </form>
</body>
</html>
