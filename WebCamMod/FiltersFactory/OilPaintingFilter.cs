using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class OilPaintingFilter : IFilter
    {
        OilPainting oilPainting;

        public OilPaintingFilter()
        {
            oilPainting = new OilPainting();
            //oilPainting.BrushSize = 15;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = oilPainting.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "OilPainting";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
