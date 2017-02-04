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
                string fileUrl1 = @"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4";
                string fileUrl2 = @"D:\Tmp\VDO\VDO.avi";

                BuiltVideoObject("1",fileUrl1, litContent1);
                BuiltVideoObject("2",fileUrl2, litContent2);
            }
        }


        private void BuiltVideoObject(string PlayerID, string fileUrl, Literal lit)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<object id='mediaPlayer" + PlayerID + "' width='100%' height='680px'  classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95'");
            sb.AppendLine("codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'");
            sb.AppendLine("standby='Loading Microsoft Windows Media Player components...' type='application/x-oleobject'>");
            sb.AppendLine(" <param name='fileName' value=" + fileUrl + " />");
            sb.AppendLine(" <param name='animationatStart' value='true'/>");
            sb.AppendLine(" <param name='transparentatStart' value='true'/>");
            sb.AppendLine(" <param name='autoStart' value='true'/>");
            sb.AppendLine(" <param name='showControls' value='false'/>");
            sb.AppendLine(" <param name='loop' value='true'/>");
            sb.AppendLine(" <param name='AutoSize' value='false' />");
            sb.AppendLine(" <param name='allowFullScreen' value='true' />");
            sb.AppendLine("</object>");

            lit.Text = sb.ToString();
        }
    }
}