using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
   public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Apply Resize");
        }
    }
}
