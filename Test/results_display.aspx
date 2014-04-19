<%@ Page Language="C#" AutoEventWireup="true" CodeFile="results_display.aspx.cs" Inherits="results_display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCCCCC">
<head runat="server">
    <title>
    </title>
</head>
<body>
    <form id="form1" runat="server">
    <h2 style="text-align:center">Analysis</h2>    
    <div>
        Total Word Count: <asp:Literal runat="server" ID="litWordCount" /><br/>
        <table border="1" >
            <tr><td colspan="2"; >Word Frequency Table</td></tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
