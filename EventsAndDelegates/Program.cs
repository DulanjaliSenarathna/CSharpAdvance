namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var encorder = new VideoEncorder();//publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            encorder.VideoEncoded += mailService.OnVideoEncorded;
            encorder.VideoEncoded += messageService.OnVideoEncoded;
            encorder.Encode(video);
        }
    }
}
