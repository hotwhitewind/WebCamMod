using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class HueModifierFilter : IFilter
    {
        HueModifier _hueModifier;

        public HueModifierFilter()
        {
            _hueModifier = new HueModifier();
            _hueModifier.Hue = 50;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            return _hueModifier.Apply(source);
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Hue Modifier";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
