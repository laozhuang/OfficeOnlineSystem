using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using DataTransfer;
using BLL;
public partial class Approval : System.Web.UI.Page
{
    Post_fileQueryHql post_fileQueryHql = new Post_fileQueryHql();
    Treat_fileQueryHql treat_fileQueryHql = new Treat_fileQueryHql();

    FileBL filebl = new FileBL();
    UserBL userbl = new UserBL();

    Post_file tem = new Post_file();

    User temuser = new User();
    protected void Page_Load(object sender, EventArgs e)
    {
        string name=Session["username"].ToString();
        temuser=userbl.GetUserByName(name);
        Label2.Text="用户名："+name;
        Label3.Text = "科室号：" + temuser.office_id;
        Label4.Text = "E-mail：" + temuser.email;
        Label5.Text = "身份：科长" ;
    }
 
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
            int ID = (int)GridView1.SelectedDataKey.Values["id"];
            tem = post_fileQueryHql.GetPost_fileById(ID);
            Label1.InnerHtml = tem.content;
            Session["file"] = tem;          
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
            tem = (Post_file)Session["file"];      
            filebl.filePass(tem);
            GridView1.DataBind();     
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
            tem = (Post_file)Session["file"]; 
            filebl.fileNoPass(tem);
            GridView1.DataBind();
    }
}