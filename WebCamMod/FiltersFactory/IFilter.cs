using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;


namespace WebCamMod.FiltersFactory
{
    public interface IFilter
    {
        void StopAudio();
        void PlayAudio(string filePath);
        bool IsAudio();
        Bitmap GetNewFrame(Bitmap source);
        string NameUnique();
    }
}
