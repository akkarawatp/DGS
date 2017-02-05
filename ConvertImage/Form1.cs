using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DirectX.Capture;
//using JockerSoft.Media;
using NReco.VideoConverter;
using NReco.VideoInfo;

namespace ConvertImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //รองรับแค่ไฟล์ AVI
            //string sourceFile = @"D:\Tmp\VDO\Tesco.mp4";
            string sourceFile = @"D:\Tmp\VDO\VDO.avi";
            string destFile = @"D:\Tmp\VDO\AIS.m4v";


            //Dim ff As New NReco.VideoConverter.FFMpegConverter
            FFMpegConverter ff = new FFMpegConverter();
            ff.ConvertMedia(sourceFile, destFile, Format.mp4);

            Size zz = FrameGrabber.GetVideoSize(destFile);
            //double FrameRate = FrameGrabber.GetVideoFrameRate(destFile);

            FFProbe ffProb = new FFProbe();
            MediaInfo mInfo = ffProb.GetMediaInfo(destFile);

            long Duration = Convert.ToInt64(mInfo.Duration.TotalSeconds);

            double totalFrame = Convert.ToInt64(Duration);  //จำนวนเฟรมทั้งหมด
            
            for (double i = 0; i < totalFrame; i++) {
                FrameGrabber.SaveFramesFromVideo(destFile, i, zz, @"D:\Tmp\VDO\Temp\Tmp{0}.bmp");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
