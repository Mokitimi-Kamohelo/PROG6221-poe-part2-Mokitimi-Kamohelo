using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatBot
{
    class AudioPlayer
    {
        public static void PlayGreeting()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Chatbot welcome audio.wav");

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            else
            {
                Console.WriteLine("Voice greeting file not found.");
            }
        }
    }
}