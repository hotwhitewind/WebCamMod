using AForge;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class LevelsLinearFilter : IFilter
    {
        LevelsLinear levelsLinear;

        public LevelsLinearFilter()
        {
            levelsLinear = new LevelsLinear();
            levelsLinear.InRed = new IntRange(30, 230);
            levelsLinear.InGreen = new IntRange(50, 240);
            levelsLinear.InBlue = new IntRange(10, 210);
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return levelsLinear.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "LevelsLinear";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
