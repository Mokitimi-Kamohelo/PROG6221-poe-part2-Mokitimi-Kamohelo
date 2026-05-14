using System;

namespace CyberSecurityChatBot
{
    class ChatBot
    {
        private string userName;

        public void Start()
        {
            Console.Clear();

            AudioPlayer.PlayGreeting();
            UIHelper.DisplayLogo();

            AskUserName();

            UIHelper.Divider();
            UIHelper.TypingEffect($"Welcome {userName}! Ask me anything about cybersecurity.");
            UIHelper.Divider();

            ChatLoop();
        }

        private void AskUserName()
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please type something.");
                    continue;
                }

                string response = ResponseSystem.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Yellow;
                UIHelper.TypingEffect("Bot: " + response);
                Console.ResetColor();
            }
        }
    }
}