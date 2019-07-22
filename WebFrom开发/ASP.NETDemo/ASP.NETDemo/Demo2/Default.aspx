<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NETDemo.Demo2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    按钮计数器<br />
        <br/>
        <asp:Button ID="btnCal" runat="server" Text="点击我啊！" OnClick="btnCal_Click" />
        <br />
        <br/>
        您单击了<asp:Literal ID="Literal1" runat="server"></asp:Literal>次！
        </div>
    </form>
</body>
</html>
