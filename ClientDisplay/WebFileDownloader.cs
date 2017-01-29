using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ClientDisplay
{
    public class WebFileDownloader
    {
        public event AmountDownloadedChangedEventHandler AmountDownloadedChanged;
        public delegate void AmountDownloadedChangedEventHandler(long iNewProgress);
        public event FileDownloadSizeObtainedEventHandler FileDownloadSizeObtained;
        public delegate void FileDownloadSizeObtainedEventHandler(long iFileSize);
        public event FileDownloadCompleteEventHandler FileDownloadComplete;
        public delegate void FileDownloadCompleteEventHandler();
        public event FileDownloadFailedEventHandler FileDownloadFailed;
        public delegate void FileDownloadFailedEventHandler(Exception ex);


        private string mCurrentFile = string.Empty;
        public string CurrentFile
        {
            get { return mCurrentFile; }
        }

        public bool DownloadFile(string URL, string Location)
        {
            try
            {
                mCurrentFile = GetFileName(URL);
                WebClient WC = new WebClient();
                WC.DownloadFile(URL, Location);
                if (FileDownloadComplete != null)
                {
                    FileDownloadComplete();
                }
                return true;
            }
            catch (Exception ex)
            {
                if (FileDownloadFailed != null)
                {
                    FileDownloadFailed(ex);
                }
                return false;
            }
        }

        private string GetFileName(string URL)
        {
            try
            {
                return URL.Substring(URL.LastIndexOf("/") + 1);
            }
            catch (Exception ex)
            {
                return URL;
            }
        }
        public bool DownloadFileWithProgress(string URL, string Location)
        {
            FileStream FS = default(FileStream);
            try
            {
                mCurrentFile = GetFileName(URL);
                WebRequest wRemote = default(WebRequest);
                byte[] bBuffer = null;
                bBuffer = new byte[257];
                int iBytesRead = 0;
                int iTotalBytesRead = 0;

                FS = new FileStream(Location, FileMode.Create, FileAccess.Write);
                wRemote = WebRequest.Create(URL);
                wRemote.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                WebResponse myWebResponse = wRemote.GetResponse();
                if (FileDownloadSizeObtained != null)
                {
                    FileDownloadSizeObtained(myWebResponse.ContentLength);
                }
                Stream sChunks = myWebResponse.GetResponseStream();
                do
                {
                    iBytesRead = sChunks.Read(bBuffer, 0, 256);
                    FS.Write(bBuffer, 0, iBytesRead);
                    iTotalBytesRead += iBytesRead;
                    if (myWebResponse.ContentLength < iTotalBytesRead)
                    {
                        if (AmountDownloadedChanged != null)
                        {
                            AmountDownloadedChanged(myWebResponse.ContentLength);
                        }
                    }
                    else
                    {
                        if (AmountDownloadedChanged != null)
                        {
                            AmountDownloadedChanged(iTotalBytesRead);
                        }
                    }
                } while (!(iBytesRead == 0));
                sChunks.Close();
                FS.Close();
                if (FileDownloadComplete != null)
                {
                    FileDownloadComplete();
                }
                return true;
            }
            catch (Exception ex)
            {
                if ((FS != null))
                {
                    FS.Close();
                    FS = null;
                }
                if (FileDownloadFailed != null)
                {
                    FileDownloadFailed(ex);
                }
                return false;
            }
        }

        public static string FormatFileSize(long Size) {
            string ret = "";
            try {
                Int32 KB = 1024;
                Int32 MB = KB * KB;

                if (Size < KB)
                {
                    ret = Size.ToString("D") + " bytes";
                }
                else {
                    if ((Size / KB) < 1000)
                    {
                        ret = (Size / KB).ToString("N") + "KB";
                    }
                    else if ((Size / KB) < 1000000)
                    {
                        ret = (Size / MB).ToString("N") + "MB";
                    }
                    else if ((Size / KB) < 10000000) {
                        ret = (Size / MB / KB).ToString("N") + "GB";
                    }
                }
            }
            catch (Exception ex) {
                ret=Size.ToString();
            }

            return ret;
        }
        

    }
}
