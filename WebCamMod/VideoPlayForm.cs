using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamMod
{
    public partial class VideoPlayForm : Form
    {
        public VideoCaptureDevice Device { get; set; }

        public string InitVideoFilePath { get; set; }

        public bool IsPlayerForFileVisible { get; set; }

        public bool IsPlayerForWebCamIsVisible { get; set; }

        delegate void ChangeVisibleDelegate();

        public VideoPlayForm()
        {
            InitializeComponent();
            InitVideoFilePath = string.Empty;
            axWindowsMediaPlayer.PlayStateChange += AxWindowsMediaPlayer_PlayStateChange;
        }

        private void AxWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer.fullScreen = true;
            }
            if(axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                ChangeVisibleForPlayFile();
                ChangeVisibleForPlayWeb();
            }
        }

        private void VideoPlayForm_Shown(object sender, EventArgs e)
        {
            videoSourcePlayerWebCam.Visible = IsPlayerForWebCamIsVisible;
            axWindowsMediaPlayer.Visible = IsPlayerForFileVisible;

            VideoCaptureDevice videoSource = Device;
            OpenVideoSource(videoSourcePlayerWebCam, videoSource);
            if (!string.IsNullOrEmpty(InitVideoFilePath))
            {
                axWindowsMediaPlayer.URL = InitVideoFilePath;
                axWindowsMediaPlayer.Ctlcontrols.play();
                axWindowsMediaPlayer.Ctlenabled = false;
            }
        }

        void ChangeVisibleForPlayFile()
        {
            if (axWindowsMediaPlayer.InvokeRequired)
            {
                var changeVis = new ChangeVisibleDelegate(ChangeVisibleForPlayFile);
                axWindowsMediaPlayer.Invoke(changeVis);
            }
            else
            {
                axWindowsMediaPlayer.Visible = false;
            }
        }

        void ChangeVisibleForPlayWeb()
        {
            if (videoSourcePlayerWebCam.InvokeRequired)
            {
                var changeVis = new ChangeVisibleDelegate(ChangeVisibleForPlayWeb);
                videoSourcePlayerWebCam.Invoke(changeVis);
            }
            else
            {
                videoSourcePlayerWebCam.Visible = true;
            }
        }

        private void OpenVideoSource(VideoSourcePlayer player, IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource(player);

            // start new video source
            player.VideoSource = source;
            player.Start();

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource(VideoSourcePlayer player)
        {
            if (player.VideoSource != null)
            {
                player.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!player.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (player.IsRunning)
                {
                    player.Stop();
                }

                player.VideoSource = null;
            }
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {

        }
    }
}
