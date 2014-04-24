<%@ Page Language="C#" AutoEventWireup="true" CodeFile="proximitydisplay.aspx.cs" Inherits="proximitydisplay" %>

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
            <tr><td colspan="2"; >Word Proximity Table</td></tr>
            <asp:Literal runat="server" ID="litWordProximity" />
        </table>
    </div>
    </form>
</body>
</html>
