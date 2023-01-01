using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs :EventArgs
    {
        public Video Video { get; set; }
    }
   public class VideoEncorder
    {
        //1-define a delegate
        //2- define an event based on delegate
        //3-raise the event

        // public delegate void VideoEncordedEventHandler(object source, VideoEventArgs args);

        //in .net we have inbuilt delegates for event handling.
        //1. EventHandler - publish an event without sending an additional data
        //2. EventHandler<> - generic type

        //so we don't need declare delegate  at line 18
        public event EventHandler<VideoEventArgs> VideoEncoded;//publish an event with sending an additional data
        public event EventHandler VideoEncoding; //publish an event without sending an additional data
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) //.net convention, event publisher method should be protected and virtual and void
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
