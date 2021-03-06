﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDisplay
{
    public partial class frmDisplayVDO : Form
    {
        public frmDisplayVDO()
        {
            InitializeComponent();
        }

        public string FileUrl = "";
        private void frmDisplayVDO_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
        }

        private void frmDisplayVDO_Shown(object sender, EventArgs e)
        {

            //VDO.URL = @"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4";
            //VDO.URL = @"http://192.168.203.134/TestVDO/3273.mp4";
            //VDO.URL = @"http://192.168.203.134/TestVDO/VDO.avi";

            VDO.settings.setMode("loop", true);
            VDO.URL = FileUrl;
            VDO.uiMode = "none";
            VDO.stretchToFit = true;

            VDO.Ctlcontrols.play();
        }

        private void VDO_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
        //    If e.newState.ToString = "8" Then
        //    'เมื่อไฟล์ VDO เล่นจบ
        //End If


        //''########## Video State Reference
        //'0 = Undefined
        //'1 = Stopped (by User)
        //'2 = Paused
        //'3 = Playing
        //'4 = Scan Forward
        //'5 = Scan Backwards
        //'6 = Buffering
        //'7 = Waiting
        //'8 = Media Ended
        //'9 = Transitioning
        //'10 = Ready
        //'11 = Reconnecting
        //'12 = Last
            //VDO.Ctlcontrols.currentPosition
            
            //VDO.Ctlcontrols.
        }
    }
}
