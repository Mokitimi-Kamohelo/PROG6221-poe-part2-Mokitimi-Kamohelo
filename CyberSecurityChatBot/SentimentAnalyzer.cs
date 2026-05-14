using System;

namespace CyberSecurityChatbot
{
    public class SentimentAnalyzer
    {
        public string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") ||
                input.Contains("scared") ||
                input.Contains("nervous"))
            {
                return "worried";
            }

            if (input.Contains("curious") ||
                input.Contains("interested"))
            {
                return "curious";
            }

            if (input.Contains("frustrated") ||
                input.Contains("confused"))
            {
                return "frustrated";
            }

            return "neutral";
        }
    }
}