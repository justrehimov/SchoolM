<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="SchoolManagementSystem.resetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset password</title>
    <link href="reset.css" rel="stylesheet"/>
</head>
<body>
     <form id="form" runat="server">
       
        <label class="label">E-mail</label>
        <asp:TextBox CssClass="input" ID="tb_email" runat="server" TextMode="Email"></asp:TextBox>
         <label class="label">Code</label>
        <asp:TextBox CssClass="input" ID="tb_code" runat="server" Enabled="false" TextMode="Number"></asp:TextBox>
        <label class="label">New password</label>
        <asp:TextBox CssClass="input" ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
         <asp:DropDownList CssClass="input" ID="person" runat="server">
                <asp:ListItem Text="Student" Value="student"></asp:ListItem>
                <asp:ListItem Text="Teacher" Value="teacher"></asp:ListItem>
        </asp:DropDownList>
         <div class="butoncontent">
        <asp:Button CssClass="btn" runat="server" Text="Send Code" OnClick="Unnamed1_Click" />
        <asp:Button CssClass="btn" runat="server" Text="Reset" OnClick="Unnamed2_Click" />
         </div>
         
    </form>
</body>
</html>
