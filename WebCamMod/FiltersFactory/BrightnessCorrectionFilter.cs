﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace WebCamMod.FiltersFactory
{
    public class BrightnessCorrectionFilter : IFilter
    {
        BrightnessCorrection brightnessCorrection;

        public BrightnessCorrectionFilter()
        {
            brightnessCorrection = new BrightnessCorrection();
            brightnessCorrection.AdjustValue = 0;
        }

        public Bitmap GetNewFrame(Bitmap source)
        {
            var newFrame = brightnessCorrection.Apply(source);
            source.Dispose();
            return newFrame;
        }

        public bool IsAudio()
        {
            return false;
        }

        public string NameUnique()
        {
            return "Brightness Correction";
        }

        public void PlayAudio(string filePath)
        {
        }

        public void StopAudio()
        {
        }
    }
}
