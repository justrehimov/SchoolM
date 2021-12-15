<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginstudent.aspx.cs" Inherits="SchoolManagementSystem.loginstudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Student</title>
    <link href="login.css" rel="stylesheet"/>
</head>
<body>
   <form id="form" runat="server">
       
        <label class="label">E-mail</label>
        <asp:TextBox CssClass="input" ID="tb_email" runat="server" TextMode="Email"></asp:TextBox>
        <label class="label">Password</label>
        <asp:TextBox CssClass="input" ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
        <a class="link" href="resetpassword.aspx">Forgot password?</a>
        <asp:Button CssClass="login_btn" runat="server" Text="Login" OnClick="Unnamed1_Click" />
    </form>
</body>
</html>
