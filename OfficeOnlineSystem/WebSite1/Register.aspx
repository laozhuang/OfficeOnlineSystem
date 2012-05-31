<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label3" runat="server" Text="用户名:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="密码:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="科室号:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="科长" />
    &nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" Text="科员" />
    </div>
    <asp:Button ID="Button1" runat="server" Height="34px" onclick="Button1_Click" 
        Text="提交" Width="107px" />
    </form>
</body>
</html>
