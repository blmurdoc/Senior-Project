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
                    <textarea id="editor1" name="editor1">
                        <asp:Literal runat="server" ID="litResults" />
                    </textarea>
                </div>
            </div>
                    </td>
                    <td style="width:40%">
                        <iframe src="results_display.aspx" style="width: 100%; height: 100%;"></iframe>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <script type="text/javascript">
        CKEDITOR.replace('editor1');
    </script>
</asp:Content>