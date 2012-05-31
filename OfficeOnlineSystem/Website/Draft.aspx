<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Draft.aspx.cs" Inherits="Draft" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="当前用户信息："></asp:Label>
    
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
        <br />
    
    </div>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <br />
    <asp:TreeView ID="TreeView1" runat="server" Height="206px" Width="202px">
        <Nodes>
            <asp:TreeNode Text="起草文件" Value="起草文件">
                <asp:TreeNode Text="编辑过往草稿文件" Value="编辑过往草稿文件"></asp:TreeNode>
                <asp:TreeNode Text="编辑新文件" Value="编辑新文件"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="查看已审批文件" Value="查看已审批文件">
                <asp:TreeNode Text="审批未通过文件" Value="审批未通过文件"></asp:TreeNode>
                <asp:TreeNode Text="审批通过文件" Value="审批通过文件"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
    <p style="margin-left: 400px">
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    </form>
</body>
</html>
