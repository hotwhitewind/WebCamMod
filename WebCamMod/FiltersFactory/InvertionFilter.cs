using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class InvertionFilter : IFilter
    {
        private Invert _invert;

        public InvertionFilter()
        {
            _invert = new Invert();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            //инверсия
            var newFrame = _invert.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Invertion filter";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
