using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class GrayScaleFilter : IFilter
    {
        public Bitmap GetNewFrame(Bitmap source)
        {
            //есть несколько алгоритмов преобразования 
            //Grayscale.CommonAlgorithms.RMY
            //Grayscale.CommonAlgorithms.BT709
            //Grayscale.CommonAlgorithms.Y
            //параметры 
            //Grayscale.CommonAlgorithms.BT709.BlueCoefficient
            //Grayscale.CommonAlgorithms.BT709.GreenCoefficient
            //Grayscale.CommonAlgorithms.BT709.RedCoefficient

            var newFrame = Grayscale.CommonAlgorithms.BT709.Apply(source);
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Grayscale";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
