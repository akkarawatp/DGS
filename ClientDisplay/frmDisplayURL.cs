using System;
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
    public partial class frmDisplayURL : Form
    {
        public frmDisplayURL()
        {
            InitializeComponent();
        }



        public string urlFile  = @"http://192.168.203.134/TestVDO/Manual-BI.pdf";

        private void frmDisplayURL_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            WindowState = FormWindowState.Maximized;

            wb.Url = new Uri(urlFile);
        }
    }
}
