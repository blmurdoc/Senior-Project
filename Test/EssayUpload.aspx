<%@ Page Title="Essay Analyzer - Add Essay" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EssayUpload.aspx.cs" Inherits="AddEssay" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <a href="Default.aspx"><< Main Menu</a>
        <h1>Essay Analyzer - Essay Upload</h1>
        <asp:ValidationSummary ID="vsAddEssayValidation" runat="server" />
        <asp:FileUpload ID="fuEssayUpload" runat="server" />
        <asp:Button ID="btnAnalyzeEssay" runat="server" Text="Analyze Essay" OnClick="btnAnalyzeEssay_Click" />
    </div>
</asp:Content>