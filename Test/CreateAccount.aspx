<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <a href="Default.aspx"><< Back to Login</a>
    <h1>Essay Analyzer - Create Account</h1>
    <asp:ValidationSummary ID="vsCreateAccountValidationSummary" runat="server" />
    <table>
        <tr>
            <td>Enter Username:</td>
            <td><asp:TextBox ID="txtUsername" runat="server" /></td>
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Please input a username." Display="None" />
        </tr>
        <tr>
            <td>Enter Password:</td>
            <td><asp:TextBox ID="txtPassword" runat="server" /></td>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter a password." Display="None" />
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
        </tr>
    </table>
</asp:Content>