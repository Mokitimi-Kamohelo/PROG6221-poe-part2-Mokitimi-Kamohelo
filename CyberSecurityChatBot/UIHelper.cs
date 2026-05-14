using System;
using System.Threading;

namespace CyberSecurityChatBot
{
    class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("====================================================");
            Console.WriteLine("           CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("====================================================");

            Console.WriteLine(@"

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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Chatbot!");
            Console.ResetColor();

            Divider();
        }

        public static void TypingEffect(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DisplayBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("BOT: ");

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }

            Console.WriteLine();
            Console.ResetColor();

            Divider();
        }

        public static void DisplayUserMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("YOU: " + message);
            Console.ResetColor();
        }

        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("----------------------------------------------------");
            Console.ResetColor();
        }

        public static void DisplaySentimentResponse(string sentiment)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            switch (sentiment.ToLower())
            {
                case "worried":
                    TypingEffect("I understand your concern. Cybersecurity can feel overwhelming, but I'm here to help you stay safe.");
                    break;

                case "frustrated":
                    TypingEffect("No worries. Let me explain things more clearly and simply.");
                    break;

                case "curious":
                    TypingEffect("That's great! Learning about cybersecurity is an important step toward staying safe online.");
                    break;

                default:
                    TypingEffect("Let's continue learning about cybersecurity together.");
                    break;
            }

            Console.ResetColor();

            Divider();
        }

        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + message);
            Console.ResetColor();

            Divider();
        }

        public static void DisplayGoodbye()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            TypingEffect("Thank you for using the Cybersecurity Awareness Bot.");
            TypingEffect("Remember to stay safe online!");

            Console.ResetColor();

            Divider();
        }

        public static void DisplayHelpMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("AVAILABLE TOPICS:");
            Console.WriteLine("• password");
            Console.WriteLine("• phishing");
            Console.WriteLine("• scam");
            Console.WriteLine("• privacy");
            Console.WriteLine("• hacking");

            Console.WriteLine();
            Console.WriteLine("You can also say:");
            Console.WriteLine("• tell me more");
            Console.WriteLine("• another tip");
            Console.WriteLine("• explain more");

            Console.ResetColor();

            Divider();
        }
    }
}