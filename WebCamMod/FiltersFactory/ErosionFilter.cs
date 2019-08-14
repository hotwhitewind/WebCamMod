using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class ErosionFilter : IFilter
    {
        Erosion erosion;

        public ErosionFilter()
        {
            erosion = new Erosion();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = erosion.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Erosion";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
