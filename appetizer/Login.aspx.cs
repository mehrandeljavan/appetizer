using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appetizer
{
    public partial class Login : CommonPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"]!=null)
            {
                logout_user();
                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String user_name = this.txtUserName.Text;
            String password = this.txtPasswod.Text;
            Taxer.Models.User tmp_User = new Taxer.Models.UserHandler().GetDetails(Convert.ToInt64(user_name));
            if (tmp_User.Password.Trim() == password)
            {
                Session["CurrentUser"] = tmp_User;
                if (Request.QueryString["requested_page"] != null)
                    Response.Redirect(Request.QueryString["requested_page"]);
                else
                    Response.Redirect("~/Index.aspx");
            }
            else
            {
                Session["CurrentUser"] = null;
            }
        }
    }
}