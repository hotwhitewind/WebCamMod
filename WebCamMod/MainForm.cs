using AForge.Video.DirectShow;
using NAudio.Wave;
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
    public partial class Form1 : Form
    {
        private string _initVideoFilePath;
        private string _audioFilePath;
        private WaveOutEvent _waveOut;
        private Mp3FileReader _mp3Reader;
        private VideoCaptureDevice _device;

        public Form1()
        {
            InitializeComponent();
            cmbVideoSourceDeviceSelected.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cmbVideoSourceDeviceSelected.SelectedIndex = 0;
            cmbVideoSourceDeviceSelected.DisplayMember = "Name";
            _device = null;
            if (cmbVideoSourceDeviceSelected.Items.Count > 0)
            {
                var filter = cmbVideoSourceDeviceSelected.SelectedItem as FilterInfo;
                _device = new VideoCaptureDevice(filter.MonikerString);
                foreach (var cap in _device.VideoCapabilities)
                {
                    cmbVideoCapabilities.Items.Add($"{cap.FrameSize.Width}X{cap.FrameSize.Height}");
                }
                cmbVideoCapabilities.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(_audioFilePath))
            //{
            //    PlayAudioFile(_audioFilePath);
            //}
            if (_device != null)
            {
                VideoPlayForm playForm = new VideoPlayForm();
                _device.VideoResolution = _device.VideoCapabilities[cmbVideoCapabilities.SelectedIndex];
                playForm.Device = _device;
                playForm.IsPlayerForFileVisible = false;
                playForm.IsPlayerForWebCamIsVisible = true;
                if (!string.IsNullOrEmpty(_initVideoFilePath))
                {
                    playForm.InitVideoFilePath = _initVideoFilePath;
                    playForm.IsPlayerForFileVisible = true;
                    playForm.IsPlayerForWebCamIsVisible = false;
                }
                playForm.ShowDialog();
            }
        }

        private void PlayAudioFile(string pathToFile)
        {
            _waveOut = new WaveOutEvent();
            _waveOut.PlaybackStopped += _waveOut_PlaybackStopped;
            _mp3Reader = new Mp3FileReader(pathToFile);
            _waveOut.Init(_mp3Reader);
            _waveOut.Play();
        }

        private void _waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (_waveOut != null && _mp3Reader != null)
            {
                _mp3Reader.Dispose();
                _waveOut.Dispose();
            }
        }

        private void StopPlayAudioFile()
        {
            if(_waveOut != null && _mp3Reader != null)
            {
                _waveOut.Stop();
            }
        }

        private void btnInitVideoFilePathOpen_Click(object sender, EventArgs e)
        {
            var openFileDlg = new OpenFileDialog();
            if(openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _initVideoFilePath = tbInitVideoFilePath.Text = openFileDlg.FileName;
            }
        }

        private void btnAudioFilePathOpen_Click(object sender, EventArgs e)
        {
            var openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {

                _audioFilePath = tbAudioFilePath.Text = openFileDlg.FileName;
            }
        }
    }
}
