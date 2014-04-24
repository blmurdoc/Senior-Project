<%@ Page Title="Essay Analyzer - Login" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Login" %>

<asp:Content ID="Main" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>Essay Analyzer</h1>
        <asp:Button ID="btnAdvanceToEssayUpload" runat="server" OnClick="btnAdvanceToEssayUpload_Click" Text="Go To Essay Upload" />
        <div align="center">
        <h3>About the Programmers</h3>
        <table>
            <tr>
                <td><a href="blakeblurb.html" target="blurbframe"><img src="Images/blake.gif" style="height:200px; width:150px;" /></a></td>
                <td><a href="jayseblurb.html" target="blurbframe"><img src="Images/jayse.gif" style="height:200px; width:150px;"  /></a></td>
                <td><a href="stephenblurb.html" target="blurbframe"><img src="Images/stephen.gif" style="height:200px; width:150px;"  /></a></td>
                <td><a href="jaredblurb.html" target="blurbframe"><img src="Images/jared.gif" style="height:200px; width:150px;"  /></a></td>
            </tr>
            <tr><td colspan="4"><iframe name="blurbframe" src="groupblurb.html" style="width: 100%; height: 100%;"></iframe></td></tr>
        </table>
        </div>
        </div>
</asp:Content>