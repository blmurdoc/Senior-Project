<%@ Page Language="C#" AutoEventWireup="true" CodeFile="spellcheckdisplay.aspx.cs" Inherits="spellcheckdisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #CCCCCC">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2 style="text-align:center">Analysis</h2>    
    <div>
        Total Word Count: <asp:Literal runat="server" ID="litWordCount" /><br/>
        <table border="1" >
            <tr><td>Misspelled Words Table</td></tr>
            <asp:Literal runat="server" ID="litMisspelledWords" />
        </table>
    </div>
    </form>
</body>
</html>
