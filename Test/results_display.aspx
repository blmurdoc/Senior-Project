<%@ Page Language="C#" AutoEventWireup="true" CodeFile="results_display.aspx.cs" Inherits="results_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCCCCC">
<head runat="server">
    <title>
    </title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script src="jquery.collapse.js"></script>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery-ui-1.10.4.custom.js"></script>
    <script src="Scripts/jquery-ui-1.10.4.custom.min.js"></script>
    <link href="Styles/jquery-ui-1.10.4.custom.css" rel="stylesheet" />
    <link href="Styles/jquery-ui-1.10.4.custom.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <h2 style="text-align:center">Analysis</h2>    
    <div>
        Total Word Count: <asp:Literal runat="server" ID="litWordCount" /><br/>
        <table border="1" >
            <tr><td colspan="2"; >Word Frequency Table</td></tr>
            <asp:Literal runat="server" ID="litWordFrequency" />
        </table>
    </div>
    </form>
</body>
</html>
