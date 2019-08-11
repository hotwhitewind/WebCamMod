using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class DifferenceEdgeDetectorFilter : IFilter
    {
        DifferenceEdgeDetector differenceEdgeDetector;

        public DifferenceEdgeDetectorFilter()
        {
            differenceEdgeDetector = new DifferenceEdgeDetector();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            source = Grayscale.CommonAlgorithms.RMY.Apply(source);
            return differenceEdgeDetector.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "DifferenceEdgeDetector";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
