﻿using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncorded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService : Sending an email.."+ e.Video.Title);
        }
    }
}
