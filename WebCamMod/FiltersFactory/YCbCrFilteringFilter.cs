using AForge;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class YCbCrFilteringFilter : IFilter
    {
        YCbCrFiltering yCbCrFiltering;

        public YCbCrFilteringFilter()
        {
            yCbCrFiltering = new YCbCrFiltering(new Range(0.2f, 0.9f), new Range(-0.3f, 0.3f), new Range(-0.3f, 0.3f));
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = yCbCrFiltering.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "YCbCr Filtering";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
