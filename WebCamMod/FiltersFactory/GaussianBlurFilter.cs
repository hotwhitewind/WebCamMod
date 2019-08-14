using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class GaussianBlurFilter : IFilter
    {
        GaussianBlur gaussianBlur;

        public GaussianBlurFilter()
        {
            gaussianBlur = new GaussianBlur();
            gaussianBlur.Divisor = 4;
            gaussianBlur.Sigma = 1.6f;
            gaussianBlur.Size = 7;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = gaussianBlur.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "GaussianBlur";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
