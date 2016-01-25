<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="ToDoListSystem.AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div>
                <asp:Label ID="LabelCategoryName" AssociatedControlID="TextBoxCategoryName" runat="server" Text="Category Name"></asp:Label>
                <asp:TextBox ID="TextBoxCategoryName" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="ButtonAddCategory" runat="server" OnClick="ButtonAddCategory_Click" Text="Add Category" />
        </div>
        <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="~/ToDoList.aspx">
                <h1>Back</h1>
        </asp:HyperLink>
    </form>
</body>
</html>
