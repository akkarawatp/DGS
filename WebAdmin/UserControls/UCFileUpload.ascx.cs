using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using Engine;   

namespace WebAdmin.UserControls
{
    public partial class UCFileUpload : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string FileFilter {
            set{
                txtFileFilter.Text = value;
            }
        }

        public void SaveFile(string destPath) {
            if (Session["UploadTempFileName"] == null)
            {
                Alert("กรุณาเลือกไฟล์");
                return;
            }

            if (Session["UploadTempFileName"]==null)
            {
                Alert("กรุณาเลือกไฟล์");
                return;
            }

            string FileName = Session["UploadTempFileName"].ToString();
            string TempPath = ContentENG.getTempUploadPath() + Session["UserName"].ToString() + "\\";

            string FilePath = TempPath + FileName.Trim();
            if (File.Exists(FilePath) == true)
            {
                File.Move(FilePath, destPath);
                //ทำบางอย่างก่อนแล้วค่อยลบ Session
                Session.Remove("UploadTempFileName");
            }
        }

        public void ClearTempFolder(string UserName) {
            string TempPath = ContentENG.getTempUploadPath() + UserName + "\\";
            if (Directory.Exists(TempPath) == true) {
                Directory.Delete(TempPath);
            }
        }

        protected void Alert(string message)
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "err_msg", (Convert.ToString("alert('") + message) + "');", true);
        }
    }
}