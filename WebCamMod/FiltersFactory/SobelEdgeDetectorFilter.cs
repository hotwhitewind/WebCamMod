using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class SobelEdgeDetectorFilter : IFilter
    {
        SobelEdgeDetector sobelEdgeDetector;

        public SobelEdgeDetectorFilter()
        {
            sobelEdgeDetector = new SobelEdgeDetector();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var source1 = Grayscale.CommonAlgorithms.RMY.Apply(source);
            var newFrame = sobelEdgeDetector.Apply(source1);
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
            return "SobelEdgeDetector";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
