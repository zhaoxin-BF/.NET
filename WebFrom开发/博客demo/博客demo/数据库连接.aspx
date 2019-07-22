<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="数据库连接.aspx.cs" Inherits="博客demo.数据库连接" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            账户：<asp:TextBox ID="id" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="id" ErrorMessage="该信息必须填写" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            密码：<asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="该信息必须填写" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="注册" style="height: 27px" />
        <asp:Button ID="查询" runat="server" OnClick="查询_Click" Text="查询" />
        <asp:Button ID="登录" runat="server" OnClick="登录_Click" Text="登录" />
    </form>
</body>
</html>
