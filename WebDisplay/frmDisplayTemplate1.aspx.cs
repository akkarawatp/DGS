using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebDisplay
{
    public partial class frmDisplayTemplate1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false) {
                string fileUrl1 = @"http://103.253.72.88/AppSignage/SignageVDO/Tesco1.m4v";
                string fileUrl2 = @"http://103.253.72.88/AppSignage/SignageVDO/AIS.m4v";

                string BrowserName = HttpContext.Current.Request.Browser.Browser;
                if ((BrowserName == "InternetExplorer") || BrowserName=="IE")
                {
                    BuiltIEVideoObject("1", fileUrl1, litContent1);
                    BuiltIEVideoObject("2", fileUrl2, litContent2);
                }
                else {
                    BuiltChromeVideoObject("1", fileUrl1, litContent1);
                    BuiltChromeVideoObject("2", fileUrl2, litContent2);
                }
            }
        }


        private void BuiltChromeVideoObject(string PayerID, string fileUrl, Literal lit) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<video id='my-video"  + PayerID + "' class='video-js' style='width:100%;height:100%'");
            sb.AppendLine(" poster='MY_VIDEO_POSTER.jpg'  data-setup=" + (char)39 + "{" + (char)34 + "controls" + (char)34 + ": true, " + (char)34 + "autoplay" + (char)34 + ": true, " + (char)34 + "preload" + (char)34 + ": " + (char)34 + "auto" + (char)34 + " }" + (char)39 + " >");
            sb.AppendLine("     <source src='" + fileUrl + "' type='video/mp4' />");
            sb.AppendLine("     <p class='vjs-no-js'>");
            sb.AppendLine("         To view this video please enable JavaScript, and consider upgrading to a web browser that");
            sb.AppendLine("         <a href='http://videojs.com/html5-video-support/' target='_blank'>supports HTML5 video</a>");
            sb.AppendLine("     </p>");
            sb.AppendLine("</video>");

            lit.Text = sb.ToString();

        }

        private void BuiltIEVideoObject(string PlayerID, string fileUrl, Literal lit)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<object id='mediaPlayer" + PlayerID + "' width='100%' height='680px'  classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95'");
            //sb.AppendLine("codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'");
            sb.AppendLine("standby='Loading Microsoft Windows Media Player components...' type='application/x-shockwave-flash'>");
            sb.AppendLine(" <param name='fileName' value=" + fileUrl + " />");
            sb.AppendLine(" <param name='animationatStart' value='true'/>");
            sb.AppendLine(" <param name='transparentatStart' value='true'/>");
            sb.AppendLine(" <param name='autoStart' value='true'/>");
            sb.AppendLine(" <param name='showControls' value='true'/>");
            sb.AppendLine(" <param name='loop' value='true'/>");
            sb.AppendLine(" <param name='AutoSize' value='false' />");
            sb.AppendLine(" <param name='allowFullScreen' value='true' />");
            sb.AppendLine("</object>");

            lit.Text = sb.ToString();
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