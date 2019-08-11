using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class ColorFilteringFilter : IFilter
    {
        ColorFiltering _colorFiltering;

        public ColorFilteringFilter()
        {
            _colorFiltering = new ColorFiltering();
            _colorFiltering.Blue = new AForge.IntRange(25, 230);
            _colorFiltering.Red = new AForge.IntRange(25, 230);
            _colorFiltering.Green = new AForge.IntRange(25, 230);
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return _colorFiltering.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Color Filtering";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
