using System;

namespace DPM225453_PhanHuuNhan_World01_Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class MediaAdapter : IMediaPlayer
    {
        private AdvancedMediaPlayer advancedPlayer = new AdvancedMediaPlayer();

        public void Play(string audioType, string fileName)
        {
            if (audioType.ToLower() == "vlc")
            {
                advancedPlayer.PlayVlc(fileName);
            }
            else if (audioType.ToLower() == "mp4")
            {
                advancedPlayer.PlayMp4(fileName);
            }
        }
    }
}
