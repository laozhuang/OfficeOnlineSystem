<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
    </style>
</head>
<body style="background-color: #990099">
    <form id="form1" runat="server">
    <div style="margin-left: 120px">
      <div id="login" align="center" style="padding-top:5px;">
        <div id="systitle" class="style1"><strong>网上办公系统</strong></div>
    </div>
    </div>
    <p style="margin-left: 560px">
        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
        ：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 560px" >
        <asp:Label ID="Label2" runat="server" Text="密  码"></asp:Label>
        ： 
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 560px" >
        <asp:Button ID="Button2" runat="server" Text="登  陆" />
    </p>
    
    
    
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    
    <div style="margin-left: 80px">
        <asp:Button ID="Button1" runat="server" Text="还没注册?" Height="35px" 
            onclick="Button1_Click1" Width="158px" />
    </div>
    
    </form>
</body>
</html>
