using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    public class YouTubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access youtube web server
                //read the data
                //create a list of video objects
                throw new Exception("Oops some low level YouTube error");
            }
            catch (Exception ex)
            {

                throw new YoutubeException("Could not fetch the videos from YouTube", ex);

            }

            return new List<Video>();
        }
    }
}
