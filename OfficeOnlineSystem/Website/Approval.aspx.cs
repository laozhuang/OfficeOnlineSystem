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
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Text = "正在审批中.....";
    }

}