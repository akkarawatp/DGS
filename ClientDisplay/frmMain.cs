using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace ClientDisplay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        DataTable dtContent = new DataTable();
        int CurrentContentIndex = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Visible = false;

            dtContent = ContentENG.GetListContent();
            if (dtContent.Rows.Count > 0)
            {
                DisplayContent();
            }

            
        }

        private void DisplayContent() {
            DataRow dr = dtContent.Rows[CurrentContentIndex];

            string FileUrl = dr["file_url"].ToString();
            if (FileUrl.ToLower().EndsWith(".pdf") == true) {
                frmDisplayPDF frm = new frmDisplayPDF();
                frm.FileUrl = FileUrl;
                frm.FileID = "1.pdf";
                frm.Show(this);

            } else if ((FileUrl.ToLower().EndsWith(".mp4") == true) || (FileUrl.ToLower().EndsWith(".avi")==true) || (FileUrl.ToLower().EndsWith(".mpg") == true)) { 

                frmDisplayVDO frm = new frmDisplayVDO();
                frm.FileUrl = FileUrl;
                frm.Show(this);
            }

            timerChangeContent.Enabled = true;
            timerChangeContent.Interval = Convert.ToInt16(dr["duration_min"]) * 60000;
        }

        private void timerChangeContent_Tick(object sender, EventArgs e)
        {
            if (CurrentContentIndex >= (dtContent.Rows.Count - 1))
            {
                CurrentContentIndex = 0;
            }
            else {
                CurrentContentIndex += 1;
            }

            CloseAllChildForm();
            DisplayContent();
        }

        private void CloseAllChildForm() {
            for (int i =  Application.OpenForms.Count - 1; i>0; i--) {
                if (Application.OpenForms[i] != this) {
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
