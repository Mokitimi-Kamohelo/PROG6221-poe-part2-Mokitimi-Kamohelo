using System;
using System.Threading;

namespace CyberSecurityChatBot
{
    class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("=================================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("=================================================");

            Console.WriteLine(@"
====================================================
            CYBERSECURITY AWARENESS BOT
====================================================

                 .--------.
                / .------. \
               / /        \ \
               | |        | |
              _| |________| |_
            .' |_|        |_| '.
            '._____ ____ _____.' 
            |     .'____'.     |
            '.__.'.'    '.'.__.'
            '.__  | LOCK |  __.'
            |   '.'.____.'.'   |
            '.____'.____.'____.'

             STAY SAFE ONLINE
");

            Console.ResetColor();
        }

        public static void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
        }
    }
}