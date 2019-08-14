using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class DilatationFilter : IFilter
    {
        Dilatation dilatation;

        public DilatationFilter()
        {
            dilatation = new Dilatation();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = dilatation.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Dilatation";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
