using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class JitterFilter : IFilter
    {
        Jitter jitter;

        public JitterFilter()
        {
            jitter = new Jitter();
            jitter.Radius = 6;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = jitter.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Jitter";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
