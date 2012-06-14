<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>用户注册页</title>
<style id="custom_style" type="text/css">
body
{
    background-image:url('resources/woaidoudou%20(10).jpg');
    background-repeat: repeat;
    background-attachment:fixed;
    background-position  :left top;}
</style>
</head>
<body >
    <form id="form1" runat="server">
   <table style="margin-left:auto; margin-right:auto;">
   <tr>   
            <td style="width:150px; text-align:right;">           
            <asp:Label ID="Label3" runat="server" Text="用户名:"></asp:Label>
            </td>
            <td>
            <asp:TextBox ID="TextBox3" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>            
            <asp:RequiredFieldValidator ID="Validator1" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="用户名必须输入" Display="Static">       
            </asp:RequiredFieldValidator>                
            </td>
    </tr>
    <tr>
            <td style="width:150px; text-align:right;">           
            <asp:Label ID="Label4" runat="server" Text="密 码:"></asp:Label>
            </td>
            <td>
           <asp:TextBox ID="TextBox4" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4"
                ErrorMessage="密码必须输入" Display="Static">       
            </asp:RequiredFieldValidator>                
            </td>
    </tr>
    <tr>
            <td style="width:150px; text-align:right;">           
            <asp:Label ID="Label5" runat="server" Text="科室号:"></asp:Label>
            </td>
            <td>
           <asp:TextBox ID="TextBox5" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5"
                ErrorMessage="科室号必须输入" Display="Static">       
            </asp:RequiredFieldValidator>                
            </td>
    </tr>
    <tr>
            <td style="width:150px; text-align:right;">           
             <asp:Label ID="Label6" runat="server" Text="E-mail:"></asp:Label>
            </td>
            <td>
           <asp:TextBox ID="TextBox6" runat="server" Height="25px" 
             Width="155px"></asp:TextBox>       
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox6"
                ErrorMessage="科室号必须输入" Display="Static">       
            </asp:RequiredFieldValidator>                
            </td>
    </tr>
    <tr>
            <td style="width:150px; text-align:right;"> 
             <asp:RadioButton ID="RadioButton1" runat="server" Text="科长" GroupName="role"/>
             <asp:RadioButton ID="RadioButton2" runat="server" Text="科员" GroupName="role"/>
            </td>
    </tr> 
    <tr>
            <td style="width:150px; text-align:right;"> 
             <asp:Button ID="Button1" runat="server" Height="34px" onclick="Button1_Click" 
               Text="提交" Width="107px" />
            </td>
    </tr>  
   </table>
 </form>
</body>
</html>   
       
        
        
        
   
    
