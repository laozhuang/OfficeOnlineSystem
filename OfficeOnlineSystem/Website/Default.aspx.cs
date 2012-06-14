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
        Response.Redirect("/Website/Register.aspx");
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
            if (userQueryHql.GetUserByUserName(textbox1).role==1)
            {
                Session["username"] = textbox1; 
                Response.Redirect("/WebSite/Approval.aspx");
            }
            else
            {
                Session["username"] = textbox1;
                Response.Redirect("/WebSite/Draft.aspx");
            }
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Session["username"] = "stranger";
        Response.Redirect("/Website/PassFile.aspx");
    }
}