using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessor
    {
        //delegate is a pointer that point to the PhotoFilterHandler(Photo photo) signature methods
        public void Process(string path, Action<Photo> photoFilterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            photoFilterHandler(photo);

            photo.Save();
        }
    }
}
