using System;

namespace DPM225453_PhanHuuNhan_World01_Adapter
{
    /// <summary>
    /// Adapter Design Pattern - MyWorld01 Example (Music Player)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            AudioPlayer player = new AudioPlayer();

            player.Play("mp3", "song1.mp3");
            player.Play("mp4", "movie.mp4");
            player.Play("vlc", "clip.vlc");
            player.Play("avi", "video.avi");

            Console.ReadKey();
        }
    }
}
