<%@ Page Title="Essay Analyzer - Login" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Login" %>

<asp:Content ID="Main" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>Essay Analyzer - Login</h1>
        <asp:ValidationSummary ID="vsLoginValidation" runat="server" />
        <table>
            <tr>
                <td>Username:</td>
                <td><asp:TextBox ID="txtUsername" runat="server" /></td>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Please input a username." ControlToValidate="txtUsername" Display="None" />
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" /></td>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Please input a password." ControlToValidate="txtPassword" Display="None" />
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>