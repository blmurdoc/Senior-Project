<%@ Page Title="Essay Analyzer - Results" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h1>Essay Analyzer - Results</h1>
        <a href="EssayUpload.aspx" runat="server"><< Back to Essay Upload</a>
        <div class="border2" style="width:90%;">
            <table style="width:100%">
                <tr>
                    <td style="width:60%;">
            <div class="border1">
                <div id="EssayResults" style="min-height:500px;">
                    <textarea id="editor1" name="editor1" runat=">
                        <asp:Literal runat="server" ID="litResults" />
                    </textarea>
                </div>
            </div>
                    </td>
                    <td style="width:40%">
                        <iframe name="analysisframe" src="results_display.aspx" style="width: 100%; height: 100%;"></iframe>
                    </td>
                    <td style="min-height:100%; width:80px">
                        <table>
                            <tr><td><a href="results_display.aspx" target="analysisframe"><img alt="tab" src="Images/wordcount.png" /></a></td></tr>
                            <tr><td><a href="proximitydisplay.aspx" target="analysisframe"><img alt="tab" src="Images/proximity.png" /></a></td></tr>
                            <tr><td><a href="results_display.aspx" target="analysisframe"><img alt="tab" src="Images/export.png" /></a></td></tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <script type="text/javascript">
        CKEDITOR.replace('editor1');
    </script>
</asp:Content>