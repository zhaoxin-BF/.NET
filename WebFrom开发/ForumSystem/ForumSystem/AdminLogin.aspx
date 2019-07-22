<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ForumSystem.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>
        用户名：<asp:TextBox ID="Textumame" runat="server"></asp:TextBox>
        <br />
        <br />
        密码啊：<asp:TextBox ID="Textupwd" runat="server" TextMode="Password" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="登录" OnClick="btnSubmit_Click" />
        <br />
        <asp:Literal ID="ltaInfo" runat="server"></asp:Literal>
    </div>
    </form>
    </center>

</body>
</html>
