using System;

namespace DPM225453_PhanHuuNhan_World01_Adapter
{
    /// <summary>
    /// The 'Client/Target' class
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                Console.WriteLine("Playing mp3 file: " + fileName);
            }
            else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
            {
                mediaAdapter = new MediaAdapter();
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
