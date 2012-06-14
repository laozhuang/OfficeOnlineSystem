using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using DataTransfer;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //获取网页上用户信息
        string user_name = TextBox3.Text.Trim();
        string pass_word = TextBox4.Text;
        string email = TextBox6.Text;
        int role;
        if (RadioButton1.Checked)
        {
            role = 1;
        }
        else
        {
            role = 0;
        }
        int office_id = int.Parse(TextBox5.Text);

        //存储用户信息
        User user = new User();
        user.username = user_name;
        user.password = pass_word;
        user.email = email;
        user.role = role;
        user.office_id = office_id;

        //把用户信息放进数据库
        UserQueryHql userQueryHql = new UserQueryHql();
        userQueryHql.CreateUser(user);
        Response.Redirect("/WebSite/Default.aspx");
    }
}