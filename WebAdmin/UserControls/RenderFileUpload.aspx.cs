using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Engine;

namespace WebAdmin.UserControls
{
    public partial class RenderFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Files.Count == 0) return;

            HttpPostedFile fileContent = Request.Files[0];
            string FileFilter = Request.Form["FileFilter"].ToString() ;
            string TempFilePath = ContentENG.getTempUploadPath() + Session["UserName"].ToString() + "\\";

            string[] tmpExt = fileContent.FileName.Trim().Split('.');
            if (tmpExt.Length >= 2)
            {
                string FileExt = tmpExt[tmpExt.Length - 1].ToString();
                if (FileFilter.ToLower().IndexOf(FileExt.ToLower()) <= -1) {
                    Session.Remove("UploadTempFileName");
                    Response.Write("false|ไม่รองรับไฟล์ที่เลือก");
                    return;
                }
            }
            else {
                Session.Remove("UploadTempFileName");
                Response.Write("false|ไม่รองรับไฟล์ที่เลือก");
                return;
            }

            try {
                if (Directory.Exists(TempFilePath) == false) {
                    Directory.CreateDirectory(TempFilePath);
                }

                string FilePath = TempFilePath + fileContent.FileName;
                if (File.Exists(FilePath) == true) {
                    Session.Remove("UploadTempFileName");
                    Response.Write("false|ไฟล์ที่เลือกซ้ำ");
                    return;
                }

                fileContent.SaveAs(FilePath);
                if (File.Exists(FilePath) == true)
                {
                    Session["UploadTempFileName"] = fileContent.FileName;
                    Response.Write("true|" + fileContent.FileName);
                }
                else {
                    Response.Write("false|" + fileContent.FileName);
                }

            }
            catch (Exception ex) {
                Response.Write("false|Exception " + ex.Message + Environment.NewLine + ex.StackTrace);
            }

        }
    }
}