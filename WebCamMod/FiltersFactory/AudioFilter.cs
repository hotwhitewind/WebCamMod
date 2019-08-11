using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class AudioFilter : IFilter
    {
        private WaveOutEvent _waveOut;
        private Mp3FileReader _mp3Reader;

        public Bitmap GetNewFrame(Bitmap source)
        {
            return null;
        }

        private void _waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (_waveOut != null && _mp3Reader != null)
            {
                _mp3Reader.Dispose();
                _waveOut.Dispose();
            }
        }

        public bool IsAudio()
        {
            return true;
        }

        public string NameUnique()
        {
            return "Audio player";
        }

        public void PlayAudio(string filePath)
        {
            _waveOut = new WaveOutEvent();
            _waveOut.PlaybackStopped += _waveOut_PlaybackStopped;
            _mp3Reader = new Mp3FileReader(filePath);
            _waveOut.Init(_mp3Reader);
            _waveOut.Play();
        }

        public void StopAudio()
        {
            if (_waveOut != null && _mp3Reader != null)
            {
                _waveOut.Stop();
            }
        }
    }
}
