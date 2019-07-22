<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Demo1.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="color:white; font-weight:100;">
        <center>
        <h1>论坛系统登录</h1>
         用户名：<asp:TextBox ID="texLoginId" runat="server"></asp:TextBox>
        <br />
        <br />
        密码啊：<asp:TextBox ID="texLoginPwd" runat="server" TextMode="Password" ></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="rbt0" runat="server" Text="普通用户" GroupName="Type" OnCheckedChanged="rbt0_CheckedChanged"/>
            <asp:RadioButton ID="rbt1" runat="server" Text="管理员" GroupName="Type" OnCheckedChanged="rbt1_CheckedChanged"/>
            <br />
            <br />
        <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnreg" runat="server" Text="注册" />
        <br />
        <asp:Literal ID="ltaInfo" runat="server"></asp:Literal>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </center>
    </div>
</asp:Content>
