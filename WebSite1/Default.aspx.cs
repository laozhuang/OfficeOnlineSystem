using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransfer;

public partial class _Default : System.Web.UI.Page
{
    private DataAccessLayer.NHibernateDataProvider _provider;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("http://localhost:27821/WebSite1/Register.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        //IList<User> user = _provider.GetPasswordByUsername(user_name);
        //if (pass_word != user)
        //{
        //    Response.Write("<script>alert('对不起,'+'你输入的用户名或者密码错误！')</script>");
        //}
        //else if (user_name == "SELECT office.leader FROM office WHERE users.office_id=office.id")
        //{
        //    Response.Redirect("http://localhost:27821/WebSite1/Approval.aspx");
        //}
        //else
        //{
        //    Response.Redirect("http://localhost:27821/WebSite1/Draft.aspx");
        //}
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //IList<User> user = _provider.GetPasswordByUsername(Page.User.Identity.Name);
        //string pass_word = 

    }
   
   
}