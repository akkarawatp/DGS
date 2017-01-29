namespace ClientDisplay
{
    partial class frmDisplayVDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisplayVDO));
            this.VDO = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.VDO)).BeginInit();
            this.SuspendLayout();
            // 
            // VDO
            // 
            this.VDO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VDO.Enabled = true;
            this.VDO.Location = new System.Drawing.Point(0, 0);
            this.VDO.Name = "VDO";
            this.VDO.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VDO.OcxState")));
            this.VDO.Size = new System.Drawing.Size(831, 473);
            this.VDO.TabIndex = 0;
            // 
            // frmDisplayVDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 473);
            this.ControlBox = false;
            this.Controls.Add(this.VDO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDisplayVDO";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmDisplayVDO";
            this.Load += new System.EventHandler(this.frmDisplayVDO_Load);
            this.Shown += new System.EventHandler(this.frmDisplayVDO_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.VDO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VDO;
    }
}