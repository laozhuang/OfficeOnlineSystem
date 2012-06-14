using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransfer;
using DataAccessLayer;
using BLL;
public partial class Draft : System.Web.UI.Page
{
    Post_fileQueryHql post_fileQueryHql = new Post_fileQueryHql();
    Post_file tem = new Post_file();

    FileBL fileBL = new FileBL();
    UserBL userbl = new UserBL();

    User temuser = new User();

    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();
        temuser = userbl.GetUserByName(name);
        Label1.Text = "用户名：" + name;
        Label3.Text = "科室号：" + temuser.office_id;
        Label4.Text = "E-mail：" + temuser.email;
        Label5.Text = "身份：科员";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       string name=Session["username"].ToString();
        tem.title = TextBox2.Text;
        tem.content = this.FreeTextBox1.Text;
        tem.username = Session["username"].ToString();
        
        //初始status为0，表示尚未审批
        tem.status = 0;
        fileBL.PostSemiFile(tem);
        Response.Redirect("/Website/PassFile.aspx");
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();
        tem.title = TextBox2.Text;
        tem.content = this.FreeTextBox1.Text;
        tem.username = Session["username"].ToString();
        fileBL.UpdateSemiFile(tem);
        Response.Redirect("/Website/SemiFile.aspx");
    }
}