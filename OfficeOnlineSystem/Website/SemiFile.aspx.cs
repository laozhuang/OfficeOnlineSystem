using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DataTransfer;
using DataAccessLayer;

public partial class SemiText : System.Web.UI.Page
{
    FileBL fileBL = new FileBL();
    Post_file tem = new Post_file();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ID = (int)GridView1.SelectedDataKey.Values["id"];
        tem = fileBL.GetPFileById(ID);
       
        FreeTextBox1.Text = tem.content;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();        
        tem.content = this.FreeTextBox1.Text;
        tem.username = Session["username"].ToString();

        //初始status为0，表示尚未审批
        tem.status = 0;
        fileBL.PostSemiFile(tem);
        Response.Write("/Website/Persion.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();
        tem.content = this.FreeTextBox1.Text;
        tem.username = Session["username"].ToString();
        fileBL.UpdateSemiFile(tem);
        Response.Write("/Website/Persion.aspx");
    }
}