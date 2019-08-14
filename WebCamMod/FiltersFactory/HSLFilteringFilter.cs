using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class HSLFilteringFilter : IFilter
    {
        HSLFiltering hSLFiltering;

        public HSLFilteringFilter()
        {
            hSLFiltering = new HSLFiltering();
            hSLFiltering.Hue = new AForge.IntRange(330, 30);
            hSLFiltering.Luminance = new AForge.Range(0, 1);
            hSLFiltering.Saturation = new AForge.Range(0, 1);
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = hSLFiltering.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "HSL Filtering";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
