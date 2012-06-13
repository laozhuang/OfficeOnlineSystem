using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataTransfer;
using DataAccessLayer;
public partial class Draft : System.Web.UI.Page
{
    Post_fileQueryHql post_fileQueryHql = new Post_fileQueryHql();
    Post_file tem = new Post_file();
    protected void Page_Load(object sender, EventArgs e)
    {       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        tem.title = TextBox2.Text;
        tem.content = this.FreeTextBox1.HtmlStrippedText;
        tem.username = Session["username"].ToString();
        
        //初始status为0，表示尚未审批
        tem.status = 0;    
        post_fileQueryHql.CreatePostFile(tem);
        Response.Write("/Website/Draft.aspx");
    }
}