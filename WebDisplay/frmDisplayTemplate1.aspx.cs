using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Engine;

namespace WebDisplay
{
    public partial class frmDisplayTemplate1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) {
                string fileUrl1 = @"http://103.253.72.88/AppSignage/SignageVDO/Tesco1.m4v";
                string fileUrl2 = @"http://103.253.72.88/AppSignage/SignageVDO/AIS.m4v";

                EmbedObjectScriptENG.BuiltVideoObject("1", fileUrl1, litContent1, "", litStartScript1, Request, 100);
                EmbedObjectScriptENG.BuiltVideoObject("2", fileUrl2, litContent2, "", litStartScript2, Request);

                //string BrowserName = HttpContext.Current.Request.Browser.Browser;
                //if ((BrowserName == "InternetExplorer") || BrowserName=="IE")
                //{
                //    BuiltIEVideoObject("1", fileUrl1, litContent1);
                //    BuiltIEVideoObject("2", fileUrl2, litContent2);
                //}
                //else {
                //    BuiltChromeVideoObject("1", fileUrl1, litContent1);
                //    BuiltChromeVideoObject("2", fileUrl2, litContent2);
                //}
            }
        }


        

        //private void BuiltVideoObject(string PlayerID, string fileUrl, Literal lit)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("<object id='mediaPlayer" + PlayerID + "' width='100%' height='680px'  classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95'");
        //    sb.AppendLine(" type='application/x-oleobject'>");
        //    sb.AppendLine(" <param name='fileName' value=" + fileUrl + " />");
        //    sb.AppendLine(" <param name='animationatStart' value='true'/>");
        //    sb.AppendLine(" <param name='transparentatStart' value='true'/>");
        //    sb.AppendLine(" <param name='autoStart' value='true'/>");
        //    sb.AppendLine(" <param name='showControls' value='false'/>");
        //    sb.AppendLine(" <param name='loop' value='true'/>");
        //    sb.AppendLine(" <param name='AutoSize' value='false' />");
        //    sb.AppendLine(" <param name='allowFullScreen' value='true' />");
        //    sb.AppendLine("</object>");

        //    lit.Text = sb.ToString();
        //}
    }
}