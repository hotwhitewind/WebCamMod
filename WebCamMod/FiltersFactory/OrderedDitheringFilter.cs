using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class OrderedDitheringFilter : IFilter
    {
        OrderedDithering orderedDithering;

        public OrderedDitheringFilter()
        {
            orderedDithering = new OrderedDithering();
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var source1 = Grayscale.CommonAlgorithms.RMY.Apply(source);
            var newFrame = orderedDithering.Apply(source1);
            source.Dispose();
            source1.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "OrderedDithering";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
