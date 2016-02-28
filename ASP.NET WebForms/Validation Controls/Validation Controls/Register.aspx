<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Validation_Controls.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FormRegister" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:ValidationSummary runat="server" ValidationGroup="RegisterInfo" ForeColor="Red" />
        <asp:ValidationSummary runat="server" ValidationGroup="PersonalInfo" ForeColor="Red" />
        <asp:ValidationSummary runat="server" ValidationGroup="ContactsInfo" ForeColor="Red" />
        <h1>Register</h1>
        <fieldset>
            <legend>Login Info</legend>

            Username:
            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server"
                ValidationGroup="RegisterInfo"
                ID="RequiredFieldValidatorUsername"
                ControlToValidate="TextBoxUsername"
                Display="Dynamic"
                ErrorMessage="Password field is required!"
                ForeColor="Red"
                EnableClientScript="false">
            </asp:RequiredFieldValidator>

            <br />

            Password:                
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                ValidationGroup="RegisterInfo"
                ControlToValidate="TextBoxPassword"
                runat="server"
                Display="Dynamic"
                ErrorMessage="Password field is required!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:RequiredFieldValidator>

            <br />

            Confirm Password:
           
            <asp:TextBox ID="TextBoxRepeatPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatPassword"
                ValidationGroup="RegisterInfo"
                ControlToValidate="TextBoxRepeatPassword"
                runat="server" Display="Dynamic"
                ErrorMessage="Confirm Password field is required!"
                ForeColor="Red"
                EnableClientScript="False" />
            <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                ValidationGroup="RegisterInfo"
                ControlToCompare="TextBoxPassword"
                ControlToValidate="TextBoxRepeatPassword"
                Display="Dynamic"
                ErrorMessage="Password doesn't match!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:CompareValidator>
        </fieldset>
        <fieldset>
            <legend>Personal Info</legend>
            First Name:
            <asp:TextBox runat="server" ID="TextBoxFirstName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName"
                ValidationGroup="PersonalInfo"
                ControlToValidate="TextBoxFirstName"
                runat="server" Display="Dynamic"
                ErrorMessage="First name field is required!"
                ForeColor="Red"
                EnableClientScript="False" />

            <br />

            Last Name:
            <asp:TextBox runat="server" ID="TextBoxLastName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName"
                ValidationGroup="PersonalInfo"
                ControlToValidate="TextBoxLastName"
                runat="server" Display="Dynamic"
                ErrorMessage="Last name field is required!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:RequiredFieldValidator>

            <br />

            Age:
            <asp:TextBox runat="server" ID="TextBoxAge" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge"
                ValidationGroup="PersonalInfo"
                ControlToValidate="TextBoxAge"
                runat="server" Display="Dynamic"
                ErrorMessage="Age field is required!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator runat="server" ID="RangeValidator"
                ValidationGroup="PersonalInfo"
                ControlToValidate="TextBoxAge"
                Display="Dynamic"
                MinimumValue="18"
                MaximumValue="81"
                ErrorMessage="Minimum age 18 years old!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:RangeValidator>

            <br />


            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    Gender:
            <asp:RadioButtonList ID="RadioButtonListGender" runat="server" AutoPostBack="true" OnSelectedIndexChanged="RadioButtonListGender_SelectedIndexChanged">
                <asp:ListItem Text="Fimale" Value="1" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Male" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server"
                        ControlToValidate="RadioButtonListGender"
                        ValidationGroup="ContactsInfo"
                        Display="Dynamic"
                        ErrorMessage="Gender is required!">
                    </asp:RequiredFieldValidator>
                </ContentTemplate>
            </asp:UpdatePanel>


        </fieldset>
        <fieldset>
            <legend>Contacts</legend>
            Email:
            <asp:TextBox ID="TextBoxEmail" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorEmail"
                ValidationGroup="ContactsInfo"
                runat="server" ForeColor="Red"
                Display="Dynamic"
                ErrorMessage="An email address is required!"
                ControlToValidate="TextBoxEmail"
                EnableClientScript="false" />
            <asp:RegularExpressionValidator
                ValidationGroup="ContactsInfo"
                ID="RegularExpressionValidatorEmail"
                runat="server" ForeColor="Red"
                Display="Dynamic"
                ErrorMessage="Email address is incorrect!"
                ControlToValidate="TextBoxEmail"
                EnableClientScript="False"
                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}">
            </asp:RegularExpressionValidator>

            <br />

            Phone number:
            <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorPhone"
                ValidationGroup="ContactsInfo"
                runat="server" ForeColor="Red"
                Display="Dynamic"
                ErrorMessage="Phone number is required!"
                ControlToValidate="TextBoxPhone"
                EnableClientScript="false" />
            <asp:RegularExpressionValidator runat="server"
                ID="RegularExpressionValidatorPhone"
                ControlToValidate="TextBoxPhone"
                ValidationGroup="ContactsInfo"
                ForeColor="Red"
                Display="Dynamic"
                ErrorMessage="Phone number is invalid!"
                EnableClientScript="false"
                ValidationExpression="^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$">

            </asp:RegularExpressionValidator>

            <br />

            Address:
            <asp:TextBox runat="server" ID="TextBoxAddress"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress"
                ValidationGroup="ContactsInfo"
                ControlToValidate="TextBoxAddress"
                runat="server" Display="Dynamic"
                ErrorMessage="Address field is required!"
                ForeColor="Red"
                EnableClientScript="False">
            </asp:RequiredFieldValidator>
        </fieldset>

        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Panel ID="PanelMale" runat="server" Visible="false">
                    <asp:CheckBoxList ID="CheckBoxListCars" runat="server">
                        <asp:ListItem Text="BMV" Value="BMV"></asp:ListItem>
                        <asp:ListItem Text="Toyota" Value="Toyota"></asp:ListItem>
                        <asp:ListItem Text="Audi" Value="Audi"></asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
                <asp:Panel ID="PanelFimale" runat="server" Visible="false">
                    <asp:DropDownList ID="DropDownListCoffees" runat="server">
                        <asp:ListItem Text="Lavazza" Value="Lavazza"></asp:ListItem>
                        <asp:ListItem Text="New Brazil" Value="New Brazil"></asp:ListItem>
                        <asp:ListItem Text="Mocca" Value="Mocca"></asp:ListItem>
                    </asp:DropDownList>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />

    </form>
</body>
</html>
