using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class RotateChannelsFilter : IFilter
    {
        private RotateChannels _rotateChannels;

        public RotateChannelsFilter()
        {
            _rotateChannels = new RotateChannels();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return _rotateChannels.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Rotate channels";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
