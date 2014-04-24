<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wordfreqdisplay.aspx.cs" Inherits="wordfreqdisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCCCCC">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2 style="text-align:center">Analysis</h2>    
    <div>
        <table border="1" >
            <tr><td colspan="2"; >Word Frequency Table</td></tr>
            <asp:Literal runat="server" ID="litWordFrequency" />
        </table>
    </div>
    </form>
</body>
</html>
