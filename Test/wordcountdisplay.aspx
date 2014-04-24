<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wordcountdisplay.aspx.cs" Inherits="wordcountdisplay" %>

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
    </div>
    </form>
</body>
</html>
