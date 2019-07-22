<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3.CalDemo.aspx.cs" Inherits="ASP.NETDemo._3_CalDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="num1" runat="server"></asp:TextBox>+<asp:TextBox ID="num2" runat="server"></asp:TextBox>=<asp:TextBox ID="numSult" runat="server"></asp:TextBox>
        <asp:Button ID="btnCal" runat="server" Text="计算" OnClick="btnCal_Click" />
    </div>
    </form>
</body>
</html>
