using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class ThresholdFilter : IFilter
    {
        Threshold threshold;

        public ThresholdFilter()
        {
            threshold = new Threshold();
            threshold.ThresholdValue = 70;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            // get grayscale image
            var source1 = Grayscale.CommonAlgorithms.RMY.Apply(source);
            var newFrame = threshold.Apply(source1);
            source.Dispose();
            source1.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Threshold";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
