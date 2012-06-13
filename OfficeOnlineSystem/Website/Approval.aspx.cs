using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using DataTransfer;

public partial class Approval : System.Web.UI.Page
{
    Post_fileQueryHql post_fileQueryHql = new Post_fileQueryHql();
    Treat_fileQueryHql treat_fileQueryHql = new Treat_fileQueryHql();
    Post_file tem = new Post_file();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
 
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
            int ID = (int)GridView1.SelectedDataKey.Values["id"];
            tem = post_fileQueryHql.GetPost_fileById(ID);
            Label1.Text = tem.content.ToString();
            Label1.Visible = true;
            Session["file"] = tem;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
            tem = (Post_file)Session["file"];      
            tem.status = 1;
            
            Treat_file treat_file = new Treat_file();

            treat_file.status = 1;
            treat_file.title = tem.title;
            treat_file.username = tem.username;
            treat_file.content = tem.content;

            post_fileQueryHql.UpdatePost_file(tem);
            treat_fileQueryHql.CreateTreatFile(treat_file);
            post_fileQueryHql.DeletePost_file(tem);
            GridView1.DataBind();     
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
            tem = (Post_file)Session["file"]; 
            tem.status = 2;
            post_fileQueryHql.UpdatePost_file(tem);       
    }
}