using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class SharpenFilter : IFilter
    {
        Sharpen sharpen;

        public SharpenFilter()
        {
            sharpen = new Sharpen();
            sharpen.Threshold = 10;
            //sharpen.Divisor = 3;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return sharpen.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Sharpen";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
