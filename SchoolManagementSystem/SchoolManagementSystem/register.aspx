<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="SchoolManagementSystem.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register page</title>
    <link href="register.css" rel="stylesheet"/>
</head>
<body>
   <form id="form" runat="server">
        <label class="label">Name</label>
        <asp:TextBox CssClass="input" ID="tb_name" runat="server" ></asp:TextBox>
        <label class="label">Surname</label>
        <asp:TextBox CssClass="input" ID="tb_surname" runat="server"></asp:TextBox>
        <label class="label">E-mail</label>
        <asp:TextBox CssClass="input" ID="tb_email" runat="server" TextMode="Email"></asp:TextBox>
        <label class="label">Password</label>
        <asp:TextBox CssClass="input" ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>

        <asp:DropDownList CssClass="input" ID="person" runat="server">
                <asp:ListItem Text="Student" Value="student"></asp:ListItem>
                <asp:ListItem Text="Teacher" Value="teacher"></asp:ListItem>
        </asp:DropDownList>

        <asp:Button CssClass="register_btn" runat="server" Text="Register" OnClick="Unnamed1_Click" />
    </form>
</body>
</html>
