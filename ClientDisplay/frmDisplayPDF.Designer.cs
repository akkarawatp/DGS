namespace ClientDisplay
{
    partial class frmDisplayPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplayPDF));
            this.PDF = new AxPDFViewerLib.AxPDFViewer();
            this.lblDisplayPDF = new System.Windows.Forms.Label();
            this.timerChangePage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDF.Enabled = true;
            this.PDF.Location = new System.Drawing.Point(0, 0);
            this.PDF.Name = "PDF";
            this.PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF.OcxState")));
            this.PDF.Size = new System.Drawing.Size(857, 566);
            this.PDF.TabIndex = 0;
            // 
            // lblDisplayPDF
            // 
            this.lblDisplayPDF.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayPDF.Location = new System.Drawing.Point(694, 41);
            this.lblDisplayPDF.Name = "lblDisplayPDF";
            this.lblDisplayPDF.Size = new System.Drawing.Size(100, 23);
            this.lblDisplayPDF.TabIndex = 1;
            // 
            // timerChangePage
            // 
            this.timerChangePage.Enabled = true;
            this.timerChangePage.Interval = 5000;
            this.timerChangePage.Tick += new System.EventHandler(this.timerChangePage_Tick);
            // 
            // frmDisplayPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 566);
            this.ControlBox = false;
            this.Controls.Add(this.lblDisplayPDF);
            this.Controls.Add(this.PDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisplayPDF";
            this.Text = "frmDisplayPDF";
            this.Load += new System.EventHandler(this.frmDisplayPDF_Load);
            this.Shown += new System.EventHandler(this.frmDisplayPDF_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal AxPDFViewerLib.AxPDFViewer PDF;
        private System.Windows.Forms.Label lblDisplayPDF;
        private System.Windows.Forms.Timer timerChangePage;
    }
}