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
            source = Grayscale.CommonAlgorithms.RMY.Apply(source);
            return orderedDithering.Apply(source);
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
