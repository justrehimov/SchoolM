<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teacher.aspx.cs" Inherits="SchoolManagementSystem.teacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher</title>
<link href="teacher.css" rel="stylesheet"/>
</head>
<body>
 <form id="form" runat="server">
   <header class="header">
       <a href="index.aspx">Home</a>
       <a href="loginteacher.aspx">Log out</a>
       <asp:Button CssClass="show_btn" ID="show_btn" runat="server" Text="Show Students" OnClick="show_btn_Click" />
    </header>
    <div id="content" runat="server">
              <asp:GridView CssClass="gridview" ID="gridview" runat="server" Font-Size="Large"  AutoGenerateColumns="False" CellPadding="5" CellSpacing="20" EmptyDataText="No data found" ForeColor="#333333"  GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField  DataField ="name" HeaderText="Name" ReadOnly="True"/>
                        <asp:BoundField  DataField ="surname" HeaderText="Surname" ReadOnly="True"/>
                        <asp:BoundField  DataField ="email" HeaderText="E-mail" ReadOnly="True"/>
                        <asp:BoundField  DataField ="password" HeaderText="Password" ReadOnly="True"/>
                    </Columns>                  
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>    
    </div>
     </form>
</body>
</html>
