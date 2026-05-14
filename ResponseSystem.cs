using System;

namespace CyberSecurityChatBot
{
    class ResponseSystem
    {
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm doing fantastic and ready to help you stay safe online!";

            if (input.Contains("purpose"))
                return "My purpose is to teach you about cybersecurity awareness.";

            if (input.Contains("what can i ask"))
                return "You can ask about password safety, phishing scams, or safe browsing.";

            if (input.Contains("password"))
                return "Make use of strong passwords with a mix of letters, numbers, and symbols. Never reuse passwords.";

            if (input.Contains("phishing"))
                return "Phishing attacks trick you into revealing personal information through fake emails or websites.";

            if (input.Contains("safe browsing"))
                return "Always check website URLs, avoid suspicious downloads, and keep your browser updated.";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}