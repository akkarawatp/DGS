using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace ClientDisplay
{
    public partial class frmProcessDownload : Form
    {
        public frmProcessDownload()
        {
            InitializeComponent();
        }

        public string URL = "";

        public string PathDownloadTo = "";
        private WebFileDownloader withEventsField__Downloader;
        private WebFileDownloader _Downloader
        {
            get { return withEventsField__Downloader; }
            set
            {
                if (withEventsField__Downloader != null)
                {
                    withEventsField__Downloader.FileDownloadSizeObtained -= _Downloader_FileDownloadSizeObtained;
                    withEventsField__Downloader.FileDownloadComplete -= _Downloader_FileDownloadComplete;
                    withEventsField__Downloader.FileDownloadFailed -= _Downloader_FileDownloadFailed;
                    withEventsField__Downloader.AmountDownloadedChanged -= _Downloader_AmountDownloadedChanged;
                }
                withEventsField__Downloader = value;
                if (withEventsField__Downloader != null)
                {
                    withEventsField__Downloader.FileDownloadSizeObtained += _Downloader_FileDownloadSizeObtained;
                    withEventsField__Downloader.FileDownloadComplete += _Downloader_FileDownloadComplete;
                    withEventsField__Downloader.FileDownloadFailed += _Downloader_FileDownloadFailed;
                    withEventsField__Downloader.AmountDownloadedChanged += _Downloader_AmountDownloadedChanged;
                }
            }
        }

        private void frmProgressDownload_Load(object sender, System.EventArgs e)
        {
            DownloadFile();
        }

        private void _Downloader_FileDownloadSizeObtained(long iFileSize)
        {
            ProgBar.Value = 0;
            ProgBar.Maximum = Convert.ToInt32(iFileSize);
        }

        //FIRES WHEN DOWNLOAD IS COMPLETE
        private void _Downloader_FileDownloadComplete()
        {
            ProgBar.Value = ProgBar.Maximum;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        //FIRES WHEN DOWNLOAD FAILES. PASSES IN EXCEPTION INFO
        private void _Downloader_FileDownloadFailed(System.Exception ex)
        {
            //MessageBox.Show("An error has occured during download: " & ex.Message)
            this.Close();
        }

        //FIRES WHEN MORE OF THE FILE HAS BEEN DOWNLOADED
        private void _Downloader_AmountDownloadedChanged(long iNewProgress)
        {
            ProgBar.Value = Convert.ToInt32(iNewProgress);
            lblProgress.Text = WebFileDownloader.FormatFileSize(iNewProgress) + " of " + WebFileDownloader.FormatFileSize(ProgBar.Maximum) + " downloaded";
            Application.DoEvents();
        }

        private void DownloadFile() {
            if (System.IO.File.Exists(PathDownloadTo) == true) {
                System.IO.File.SetAttributes(PathDownloadTo, System.IO.FileAttributes.Normal);
                System.IO.File.Delete(PathDownloadTo);
            }

            try {
                _Downloader = new WebFileDownloader();
                _Downloader.DownloadFileWithProgress(URL, PathDownloadTo);
            }
            catch (Exception ex) {
                this.Close();
            }
        }

    }
}
