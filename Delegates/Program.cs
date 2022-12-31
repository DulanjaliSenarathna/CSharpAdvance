using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> photoFilterHandler = filters.ApplyBrightness;
            photoFilterHandler += filters.ApplyContrast;
            photoFilterHandler += RemoveRedEyeFilter;
            processor.Process("photo.jpg", photoFilterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye");
        }
    }
}
