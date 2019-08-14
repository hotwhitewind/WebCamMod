using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class YCbCrLinearFilter : IFilter
    {
        YCbCrLinear yCbCrLinear;

        public YCbCrLinearFilter()
        {
            yCbCrLinear = new YCbCrLinear();
            yCbCrLinear.InCb = new AForge.Range(-0.3f, 0.3f);
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = yCbCrLinear.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "YCbCr Linear";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
