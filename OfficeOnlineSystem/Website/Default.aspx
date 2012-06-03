<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="Vincent.AutoAuthCode, Version=1.5.0.0, Culture=neutral, PublicKeyToken=b633909bc009d6d9"
    Namespace="Vincent.AutoAuthCode" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>用户登录页</title>
    <link href="StyleSheet.css" type= "text/css" rel="Stylesheet" />
</head>
<body style="background-color: #990099">
    <form id="form1" runat="server">
    <div style="margin-left: 120px">
      <div id="login" align="center" style="padding-top:5px;">
        <div id="systitle" class="style1"><strong>网上办公系统</strong></div>
    </div>
    </div>
    <table style="margin-left:auto; margin-right:auto;">
        <tr>
            <td style="width:150px; text-align:right;">           
            <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label> ：
            </td>
            <td><asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td style="width:150px;text-align:right;">          
            <asp:Label ID="Label2" runat="server" Text="密  码"></asp:Label>：
            </td>
        <td>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>         
            </td>
        </tr>
        <tr>
            <td >         
            </td>
            <td>
             <cc1:AuthCode ID="AuthCode1" runat="server" TextBoxClass="authText" EnableClientValidate="true"
            SubmitControlID="Button2" />
            </td>
        </tr>
        <tr>
            <td>
        </td>
            <td>
             <asp:Button ID="Button2" runat="server" Text="登  陆" onclick="Button2_Click1" />
            </td>
        </tr>
        <tr>   
        <td></td>        
              <td style="width:150px;text-align:right;"> 
               <asp:Button ID="Button4" runat="server" Text="还没注册?" Height="35px" 
               onclick="Button1_Click1" Width="158px" />
              </td>
        </tr>
        <tr>
              <td></td>
              <td style="width:150px;text-align:right;"> 
              <asp:Button ID="Button5" runat="server" Height="35px" Text="浏览文件" 
             Width="158px" onclick="Button3_Click" />
              </td>
        </tr>
    </table>
    </form>
</body>
</html>
