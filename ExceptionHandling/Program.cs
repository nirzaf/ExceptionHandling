using System;

namespace ExceptionHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("My-YouTube-Channel");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}