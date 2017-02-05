//****************************************************************************
// Module           :   Default.aspx.cs
// Type             :   ASP.NET web page code behind
// Developer        :   Alexander Bell (Infosoft International Inc)
// DateCreated      :   06/29/2009
// LastModified     :   10/18/2009

// Description      :   YouTube API for ASP.NET (DEMO)
//****************************************************************************
// DISCLAIMER: This Application is provide on AS IS basis without any warranty
//****************************************************************************

//****************************************************************************
// TERMS OF USE     :   ALL CONTENT IS SHOWN FOR DEMO PURPOSE ONLY
//                  :   You can use it at your sole risk
//****************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Engine;

namespace WebDisplay
{
    public partial class frmDisplayYouTupe : System.Web.UI.Page
    {
        #region init settings
        // player width
        private int _W = 640;

        // player height
        private int _H = 505;

        // autoplay disabled
        bool auto = false;
        #endregion

        #region Page Load event
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                #region Start mode customization via Web Query String
                int idx = 0;
                string qry = "";

                // Web Query to set autoplay option
                try
                {
                    qry = "auto";
                    qry = (Request.QueryString[qry] == null) ? "" : Request.QueryString[qry];
                    if (qry != "") { auto = Boolean.Parse(qry); }
                }
                catch { }

                // Web Query to set item index
                try
                {
                    qry = "item";
                    qry = (Request.QueryString[qry] == null) ? "" : Request.QueryString[qry];
                    if (qry != "") { idx = int.Parse(qry); }
                }
                catch { }
                #endregion


                // generate script on page load
                Literal1.Text = YouTubeScript.Get(@"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4", auto, _W, _H);
            }
            else
            {
                // generate script on page postback
                //Literal1.Text = YouTubeScript.Get(cmbPlaylist.SelectedValue, false, _W, _H);
            }
        }
        #endregion

        #region User events
        /// <summary>
        /// Script to start video at predefined time, change border color
        /// </summary>
        protected void Button1_Click(object sender, EventArgs e)
        {
            // set start time = 15 sec, change border colors
            //Literal1.Text = YouTubeScript.Get(cmbPlaylist.SelectedValue, true, _W, _H, true, "maroon", "", 15);
        }

        /// <summary>
        /// Script to start video at predefined time, remove border
        /// </summary>
        protected void Button2_Click(object sender, EventArgs e)
        {
            // set start time = 60 sec, remove border
            //Literal1.Text = YouTubeScript.Get(cmbPlaylist.SelectedValue, true,  _W, _H, false, "", "", 60);
        }
        #endregion

    }
}