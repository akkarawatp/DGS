using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Engine
{
    public class ContentENG
    {
        public static DataTable GetListContent() {
            DataTable dt = new DataTable();
            dt.Columns.Add("file_url");
            dt.Columns.Add("duration_min",typeof(int));
            try {
                //VDO.URL = @"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4";
                //VDO.URL = @"http://192.168.203.134/TestVDO/3273.mp4";
                //VDO.URL = @"http://192.168.203.134/TestVDO/VDO.avi";


                DataRow dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/MICROSOFT_PRESS_EBOOK_CREATINGMOBILEAPPSWITHXAMARINFORMS_PDF.PDF";
                dr["duration_min"] = 2;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/VDO.avi";
                dr["duration_min"] = 10;
                dt.Rows.Add(dr);
                

                dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/3273.mp4";
                dr["duration_min"] = 3;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["file_url"]= @"https://tescolotuslc.com/learningcenterstaging/storage/document/2017/01/25/08/4611/20170125-083104.doc1mp4.mp4";
                dr["duration_min"] = 1;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/ATB-LCK_UM_Locker_v2r0_kug20160724.pdf";
                dr["duration_min"] = 2;
                dt.Rows.Add(dr);


                dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/3273.mp4";
                dr["duration_min"] = 3;
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["file_url"] = @"http://192.168.203.134/TestVDO/Manual-BI.pdf";
                dr["duration_min"] = 2;
                dt.Rows.Add(dr);

                
            }
            catch (Exception ex) { }

            return dt;

        }

        public static string getTempUploadPath() {
            return System.Configuration.ConfigurationManager.AppSettings["TempFilePath"].ToString();
        }

    }
}
