namespace WebCamMod
{
    partial class VideoPlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayForm));
            this.videoSourcePlayerWebCam = new AForge.Controls.VideoSourcePlayer();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayerWebCam
            // 
            this.videoSourcePlayerWebCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayerWebCam.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayerWebCam.Name = "videoSourcePlayerWebCam";
            this.videoSourcePlayerWebCam.Size = new System.Drawing.Size(800, 450);
            this.videoSourcePlayerWebCam.TabIndex = 2;
            this.videoSourcePlayerWebCam.Text = "videoSourcePlayerWebCam";
            this.videoSourcePlayerWebCam.VideoSource = null;
            this.videoSourcePlayerWebCam.Visible = false;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(800, 450);
            this.axWindowsMediaPlayer.TabIndex = 3;
            // 
            // VideoPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.videoSourcePlayerWebCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoPlayForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.VideoPlayForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerWebCam;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}