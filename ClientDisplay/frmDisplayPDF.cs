using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDisplay
{
    public partial class frmDisplayPDF : Form
    {
        public frmDisplayPDF()
        {
            InitializeComponent();
        }

        public string FileUrl = ""; //@"http://192.168.203.134/TestVDO/ATB-LCK_UM_Locker_v2r0_kug20160724.pdf";
        public string FileID = "";

        private void frmDisplayPDF_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
        }

        private void frmDisplayPDF_Shown(object sender, EventArgs e)
        {
            string SavePath = Application.StartupPath +  @"\TempPDF\";
            if (Directory.Exists(SavePath) == false) {
                Directory.CreateDirectory(SavePath);
            }

            if (File.Exists(SavePath + FileID) == false)
            {
                frmProcessDownload f = new frmProcessDownload();
                f.URL = FileUrl;
                f.PathDownloadTo = SavePath + FileID;
                f.ShowDialog(this.Owner);
            }
            
            if (File.Exists(SavePath + FileID)==true) {
                PDF.LoadFile(SavePath + FileID);
                PDF.SetReadOnly();
                PDF.DisableCopyToolbarButton();
                PDF.DisableHotKeyCopy();
                PDF.DisableHotKeyPrint();
                PDF.DisableHotKeySave();
                PDF.DisableHotKeySearch();
                PDF.DisableHotKeyShowBookMarks();
                PDF.DisableHotKeyShowThumnails();
                PDF.DisableHotKeyShowToolbars();
                PDF.DisablePrintToolbarButton();
                PDF.DisableSaveToolbarButton();

                PDF.GotoFirstPage();

                lblDisplayPDF.Dock = DockStyle.Fill;
                lblDisplayPDF.Parent = PDF;
            }
        }

        private void timerChangePage_Tick(object sender, EventArgs e)
        {
            PDF.GotoNextPage();
        }
    }
}
