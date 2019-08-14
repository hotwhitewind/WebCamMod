using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class ContrastCorrectionFilter : IFilter
    {
        ContrastCorrection contrastCorrection;

        public ContrastCorrectionFilter()
        {
            contrastCorrection = new ContrastCorrection();
            contrastCorrection.Factor = 150;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = contrastCorrection.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Contrast Correction";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
