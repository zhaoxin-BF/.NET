<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4.Default.aspx.cs" Inherits="ASP.NETDemo._4_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Textnum1" runat="server"></asp:TextBox><br><br>
        <asp:Button ID="btnPass" runat="server" Text="复制到第二个文本框" OnClick="btnPass_Click" /><br><br>
        <asp:TextBox ID="Textnum2" runat="server"></asp:TextBox>

    </div>
    </form>
</body>
</html>
