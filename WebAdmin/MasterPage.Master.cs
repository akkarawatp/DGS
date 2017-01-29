using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAdmin
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) {
                if (Session["UserName"] == null) {
                    Response.Redirect("frmLogin.aspx?rnd=" + DateTime.Now.Millisecond);
                }
            }
        }
    }
}