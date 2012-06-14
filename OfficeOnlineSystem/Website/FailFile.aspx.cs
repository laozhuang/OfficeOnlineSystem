using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransfer;
using DataAccessLayer;
using BLL;

public partial class FailFile : System.Web.UI.Page
{   
    FileBL filebl = new FileBL();
    UserBL userbl = new UserBL();

    User temuser = new User();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();
        temuser = userbl.GetUserByName(name);
        Label1.Text = "用户名：" + name;
        Label3.Text = "科室号：" + temuser.office_id;
        Label4.Text = "E-mail：" + temuser.email;
        if (temuser.role==1)
        {
            Label5.Text = "身份：科长";
        }
        else if (temuser.role == 0)
        {
            Label5.Text = "身份：科员";
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {       
        int ID = (int)this.GridView4.SelectedDataKey.Values["id"];
        Treat_file t = filebl.GetTFileById(ID);
        Label2.InnerHtml = t.content;
        Label2.Visible = true;
    }
    protected void GridView4_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridView4.DataBind();
        Label2.Visible = false;
    }
}