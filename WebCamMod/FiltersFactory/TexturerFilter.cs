using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamMod.FiltersFactory
{
    public class TexturerFilter : IFilter
    {
        Texturer texturer;

        public TexturerFilter()
        {
            texturer = new Texturer(new TextileTexture(), 1.0, 0.8);
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return texturer.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Texturer";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
