using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Engine;

namespace WebDisplay
{
    public partial class frmSample : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //string fileUrl = @"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4";
                //string value = @"D:\Tmp\VDO\VDO.avi";

                //string fileUrl = @"http://192.168.203.139/TestVDO/Manual-BI.pdf";
                //string fileUrl = @"http://192.168.203.139/TestVDO/6.mp4";
                //BuiltPDFObject(fileUrl);

                DisplayContent();
            }
        }


        private void DisplayContent()
        {
            int CurrentContentIndex = 0;
            DataTable dtContent = new DataTable();
            if (Session["Content"] == null)
            {
                dtContent = ContentENG.GetListContent();
                Session["Content"] = dtContent;
                Session["CurrentContentIndex"] = 0;
            }
            else {
                dtContent = (DataTable)Session["Content"];
                CurrentContentIndex = Convert.ToInt16(Session["CurrentContentIndex"]);
            }

            DataRow dr = dtContent.Rows[CurrentContentIndex];

            string FileUrl = dr["file_url"].ToString();
            if (FileUrl.ToLower().EndsWith(".pdf") == true)
            {
                BuiltPDFObject(FileUrl);
            }
            else if ((FileUrl.ToLower().EndsWith(".mp4") == true) || (FileUrl.ToLower().EndsWith(".avi") == true) || (FileUrl.ToLower().EndsWith(".mpg") == true))
            {

                BuiltVideoObject(FileUrl);
            }

            TimerChangeContent.Enabled = true;
            TimerChangeContent.Interval = Convert.ToInt16(dr["duration_min"]) * 60000;
        }

        private void BuiltPDFObject(string fileURL) {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<embed src='" + fileURL + "' width='100%' height='680px' />");
            lit1.Text = sb.ToString();
        }

        //private void BuiltVideoObject(string fileUrl) {
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("<object id='mediaPlayer' width='100%' height='680px'  classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95'");
        //    sb.AppendLine("codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'");
        //    sb.AppendLine("standby='Loading Microsoft Windows Media Player components...' type='application/x-oleobject'>");
        //    sb.AppendLine(" <param name='fileName' value=" + fileUrl + " />");
        //    sb.AppendLine(" <param name='animationatStart' value='true'/>");
        //    sb.AppendLine(" <param name='transparentatStart' value='true'/>");
        //    sb.AppendLine(" <param name='autoStart' value='true'/>");
        //    sb.AppendLine(" <param name='showControls' value='false'/>");
        //    sb.AppendLine(" <param name='loop' value='true'/>");
        //    sb.AppendLine(" <param name='AutoSize' value='false' />");
        //    sb.AppendLine(" <param name='allowFullScreen' value='true' />");
        //    sb.AppendLine("</object>");

        //    lit1.Text = sb.ToString();
        //}

        private void BuiltVideoObject(string fileUrl)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<object id='mediaPlayer' width='100%' height='680px'  classid='CLSID:22d6f312-b0f6-11d0-94ab-0080c74c7e95'");
            //sb.AppendLine("codebase='http://activex.microsoft.com/activex/controls/mplayer/en/nsmp2inf.cab#Version=5,1,52,701'");
            sb.AppendLine(" standby='Loading Microsoft Windows Media Player components...' type='application/x-shockwave-flash'>");
            sb.AppendLine(" <param name='fileName' value=" + fileUrl + " />");
            sb.AppendLine(" <param name='animationatStart' value='true'/>");
            sb.AppendLine(" <param name='transparentatStart' value='true'/>");
            sb.AppendLine(" <param name='autoStart' value='true'/>");
            sb.AppendLine(" <param name='showControls' value='false'/>");
            sb.AppendLine(" <param name='loop' value='true'/>");
            sb.AppendLine(" <param name='AutoSize' value='false' />");
            sb.AppendLine(" <param name='allowFullScreen' value='true' />");
            sb.AppendLine("</object>");

            lit1.Text = sb.ToString();
        }

        //type='application/x-shockwave-flash

        protected void TimerChangeContent_Tick(object sender, EventArgs e)
        {
            if (Session["CurrentContentIndex"] != null)
            {
                int CurrentContentIndex = Convert.ToInt16(Session["CurrentContentIndex"]);
                DataTable dtContent = (DataTable)Session["Content"];
                if (CurrentContentIndex >= (dtContent.Rows.Count - 1))
                {
                    CurrentContentIndex = 0;
                }
                else
                {
                    CurrentContentIndex += 1;
                }

                Session["CurrentContentIndex"] = CurrentContentIndex;
            }
            else {
                Session["CurrentContentIndex"] = 0;
            }

            DisplayContent();
        }
    }
}