using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class SaturationCorrectionFilter : IFilter
    {
        SaturationCorrection saturationCorrection;

        public SaturationCorrectionFilter()
        {
            saturationCorrection = new SaturationCorrection();
            saturationCorrection.AdjustValue = 0.3f;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = saturationCorrection.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Saturation Correction";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
