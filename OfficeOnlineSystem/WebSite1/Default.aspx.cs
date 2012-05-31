using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransfer;
using DataAccessLayer;

public partial class _Default : System.Web.UI.Page
{
    UserQueryHql userQueryHql = new UserQueryHql();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("/WebSite1/Register.aspx");
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        string textbox1 = TextBox1.Text.Trim();
        string textbox2 = TextBox2.Text;
        if (!userQueryHql.IsUserExist(textbox1))
        {
            Response.Write("<script>alert('对不起,'+'你尚未注册！')</script>");
        }
        else if (textbox2 != userQueryHql.GetUserByUserName(textbox1).password)
        {
            Response.Write("<script>alert('对不起,'+'你输入的用户名或者密码错误！')</script>");
        }
        else
        {
            if (userQueryHql.GetUserByUserName(textbox1).role)
            {
                Response.Redirect("/WebSite1/Approval.aspx");
            }
            else
            {
                Response.Redirect("/WebSite1/Draft.aspx");
            }
        }
    }
   
}