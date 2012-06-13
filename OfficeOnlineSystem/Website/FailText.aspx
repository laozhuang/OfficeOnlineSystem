<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Approval.aspx.cs" Inherits="Approval" %>
<%@ Register TagPrefix="FTB" Namespace="FreeTextBoxControls" Assembly="FreeTextBox" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户审批页</title>
      <style type="text/css">
body
{
    <%--background-image:url('resources/woaidoudou%20(12).jpg');--%>
    background-repeat: repeat;
    background-attachment:fixed;
    background-position  :left top;
}
#menuShow{
border: 1px solid #999999;
background-color: #cccccc;
padding: 0px;
font-size: 10px;
font-family: tahoma;
position: absolute;
width: 150px;
height: auto;
}

#menuSelect{
border: 1px solid #999999;
background-color: #cccccc;
padding: 0px;
font-size: 10px;
font-family: tahoma;
position: absolute;
width: 48px;
height: 48px;
}

a {  font-family: "tahoma"; font-size: 16px; line-height: 16px; color: #333333; text-decoration: none}
a:hover {  font-family: "tahoma"; font-size: 16px; line-height: 16px; color: #FFFFFF; text-decoration: none}
</style>
</head>
<body>
    <form id="form1" runat="server">
     <table style="margin-left:200px; margin-right:auto;">
      <tr>
      <td align="center" width="120" height="5"><div align="center"><strong>当前用户信息</strong></div></td>
         <td width="130" height="5"><strong>正在审批文件...</strong><div align="center"></div></td>
       </tr>
      <%-- <tr style="left">
        <td align="left" width="187" height="5"><div align="center"><strong>文件列表</strong></div></td>
       </tr>--%>
       <tr>       
            <td>
             <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
         GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    Height="38px" Width="397px" AutoGenerateColumns="False" 
                    DataSourceID="ObjectDataSource1" DataKeyNames="id">
           <AlternatingRowStyle BackColor="White" />
                <%-- <EmptyDataTemplate>
                     <asp:HyperLink ID="HyperLink1" runat="server" 
                         NavigateUrl="<%# Text.aspx?TextID={0} %>">HyperLink</asp:HyperLink>
                 </EmptyDataTemplate>--%>
                 <Columns>
                     <asp:BoundField DataField="id" HeaderText="id号" SortExpression="id" >
                     <ItemStyle Font-Overline="False" Font-Size="Large" Font-Strikeout="False" 
                         Wrap="False" />
                     </asp:BoundField>
                     <asp:BoundField DataField="username" HeaderText="作者" 
                         SortExpression="username" />
                     <asp:BoundField DataField="title" HeaderText="标题" 
                         SortExpression="title" />
                               
                     <asp:CommandField SelectText="查看" ShowSelectButton="True" />
                 </Columns>
                 
           <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#FFCC66" ForeColor="#333333" 
               HorizontalAlign="Center" />
                 <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
           <SelectedRowStyle BackColor="Aqua"  Font-Bold="True" />
         
     </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    SelectMethod="GetAllPost_file" TypeName="DataAccessLayer.Post_fileQueryHql">
                </asp:ObjectDataSource>
            </td>
       </tr>
       </table>

       <table style="margin-left:200px; margin-right:auto;">
       
       <tr>
        <td>          
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
       </tr>      
       </table>         
       </form>
       
</body>
</html>
