using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class FloydSteinbergDitheringFilter : IFilter
    {

        FloydSteinbergDithering floydSteinbergDithering;

        public FloydSteinbergDitheringFilter()
        {
            floydSteinbergDithering = new FloydSteinbergDithering();
            floydSteinbergDithering.ThresholdValue = 50; 
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            source = Grayscale.CommonAlgorithms.RMY.Apply(source);
            return floydSteinbergDithering.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "FloydSteinbergDithering";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
