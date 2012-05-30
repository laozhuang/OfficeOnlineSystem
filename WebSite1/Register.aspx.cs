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
        string user_name = TextBox3.Text.Trim();
        string pass_word = TextBox4.Text;
        int office_id = int.Parse(TextBox5.Text);
        NHibernateDataProviderHelper helper = new NHibernateDataProviderHelper();
        NHibernateDataProvider provider = new NHibernateDataProvider(helper.GetSession());
        User user = new User();
        user.Username = user_name;
        user.Office_id = office_id;
        user.Password=pass_word;
        provider.CreateUser(user);
        //Response.Write("<script>alert('恭喜！'+'注册成功，您现在可以起草公文或审批公文')</script>");
        
        Response.Redirect("http://localhost:27821/WebSite1/Default.aspx");
    }
}