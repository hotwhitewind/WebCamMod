using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class SepiaFilter : IFilter
    {
        Sepia _sepia;

        public SepiaFilter()
        {
            _sepia = new Sepia();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = _sepia.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Sepia";
        }

        public void PlayAudio(string filePath)
        {            
        }

        public void StopAudio()
        {
        }
    }
}
