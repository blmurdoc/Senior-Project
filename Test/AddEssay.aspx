<%@ Page Title="Essay Analyzer - Add Essay" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddEssay.aspx.cs" Inherits="AddEssay" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <a href="Default.aspx"><< Back to Login</a>
        <h1>Essay Analyzer - Add Essay</h1>
        <asp:ValidationSummary ID="vsAddEssayValidation" runat="server" />
        <asp:FileUpload ID="fuEssayUpload" runat="server" />
        <asp:Button ID="btnAddEssay" runat="server" Text="Add Essay" OnClick="btnAddEssay_Click" />
    </div>
</asp:Content>