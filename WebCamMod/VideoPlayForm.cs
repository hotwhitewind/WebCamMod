using AForge;
using AForge.Controls;
using AForge.Imaging.Filters;
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

        delegate void ChangeVisibleDelegateForWeb(bool v);


        public bool IsChangeFilter { get; set; }

        public List<FiltersFactory.IFilter> FilterList { get; set; }

        public int TimeFilter { get; set; }

        public string AudioFilePath { get; set; }

        private LevelsLinear levelLinear = new LevelsLinear();
        private BrightnessCorrection brightnessCorrection = new BrightnessCorrection();
        private Invert invert = new Invert();
        private Timer _timer;
        private int _filterIndex;
        private int _maxFilter;
        private FiltersFactory.IFilter _audioFilter;

        public VideoPlayForm()
        {
            InitializeComponent();
            InitVideoFilePath = string.Empty;
            axWindowsMediaPlayer.PlayStateChange += AxWindowsMediaPlayer_PlayStateChange;
            brightnessCorrection.AdjustValue = 100;
            levelLinear.InRed = new IntRange(30, 230);
            levelLinear.InGreen = new IntRange(50, 240);
            levelLinear.InBlue = new IntRange(10, 210);
            _timer = new Timer();
            _timer.Tick += _timer_Tick;
            _filterIndex = 0;
            _audioFilter = null;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if(_filterIndex + 1 == _maxFilter)
            {
                _timer.Stop();
                if (_audioFilter != null)
                {
                    _audioFilter.StopAudio();
                }
                ChangeVisibleForPlayWeb(false);
            }
            _filterIndex++;
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
                ChangeVisibleForPlayWeb(true);
                _timer.Start();
            }
        }

        private void VideoPlayForm_Shown(object sender, EventArgs e)
        {
            videoSourcePlayerWebCam.Visible = IsPlayerForWebCamIsVisible;
            axWindowsMediaPlayer.Visible = IsPlayerForFileVisible;
            _maxFilter = FilterList.Count;
            _filterIndex = 0;
            _timer.Interval = TimeFilter * 1000;
            _audioFilter = null;
            VideoCaptureDevice videoSource = Device;
            OpenVideoSource(videoSourcePlayerWebCam, videoSource);
            if (!string.IsNullOrEmpty(InitVideoFilePath))
            {
                axWindowsMediaPlayer.URL = InitVideoFilePath;
                axWindowsMediaPlayer.Ctlcontrols.play();
                axWindowsMediaPlayer.Ctlenabled = false;
            }
            else
            {
                _timer.Start();
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

        void ChangeVisibleForPlayWeb(bool visible)
        {
            if (videoSourcePlayerWebCam.InvokeRequired)
            {
                var changeVis = new ChangeVisibleDelegateForWeb(ChangeVisibleForPlayWeb);
                videoSourcePlayerWebCam.Invoke(changeVis);
            }
            else
            {
                videoSourcePlayerWebCam.Visible = visible;
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

        private void videoSourcePlayerWebCam_NewFrame(object sender, ref Bitmap image)
        {
            if (_filterIndex < _maxFilter)
            {
                if (IsChangeFilter)
                {
                    if (FilterList[_filterIndex].IsAudio())
                    {
                        if (_audioFilter == null && !string.IsNullOrEmpty(AudioFilePath))
                        {
                            _audioFilter = FilterList[_filterIndex];
                            FilterList[_filterIndex].PlayAudio(AudioFilePath);
                        }
                    }
                    else
                    {
                        if(_audioFilter != null)
                        {
                            _audioFilter.StopAudio();
                        }
                        try
                        {
                            var filteredImage = FilterList[_filterIndex].GetNewFrame(image);
                            image = filteredImage;
                        }
                        catch(Exception)
                        {
                        }
                    }
                }
                else
                {
                    for(int i = 0; i < _filterIndex + 1; i++)
                    {
                        try
                        {
                            if (i < _maxFilter)
                            {
                                if (FilterList[i].IsAudio())
                                {
                                    if (_audioFilter == null && !string.IsNullOrEmpty(AudioFilePath))
                                    {
                                        _audioFilter = FilterList[i];
                                        FilterList[i].PlayAudio(AudioFilePath);
                                    }
                                }
                                else
                                {
                                    image = FilterList[i].GetNewFrame(image);
                                }
                            }
                        }
                        catch (Exception)
                        { }
                    }
                }
            }
        }

        private void VideoPlayForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Close();
            }
        }

        private void VideoPlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            if (_audioFilter != null)
            {
                _audioFilter.StopAudio();
            }
            CloseCurrentVideoSource(videoSourcePlayerWebCam);
        }
    }
}
