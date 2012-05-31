<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Approval.aspx.cs" Inherits="Approval" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" Text="当前用户信息："></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </div>
    ：<br />
    <asp:TreeView ID="TreeView1" runat="server">
        <Nodes>
            <asp:TreeNode Text="审批文件" Value="审批文件">
                <asp:TreeNode Text="未审批文件" Value="未审批文件"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="查看文件" Value="查看文件">
                <asp:TreeNode Text="审批通过文件" Value="审批通过文件"></asp:TreeNode>
                <asp:TreeNode Text="审批未通过文件" Value="审批未通过文件"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
    </form>
</body>
</html>
