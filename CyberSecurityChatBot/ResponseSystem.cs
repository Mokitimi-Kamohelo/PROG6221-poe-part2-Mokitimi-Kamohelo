using System;
using System.Collections.Generic;

namespace CyberSecurityChatbot
{
    public class ResponseSystem
    {
        private Dictionary<string, List<string>> keywordResponses;
        private Random random;

        public ResponseSystem()
        {
            random = new Random();

            keywordResponses = new Dictionary<string, List<string>>();

            keywordResponses["password"] = new List<string>()
            {
                "Use strong passwords with numbers and symbols.",
                "Avoid using your birthday in passwords.",
                "Use different passwords for different accounts."
            };

            keywordResponses["privacy"] = new List<string>()
            {
                "Review your privacy settings regularly.",
                "Avoid sharing personal information online.",
                "Enable two-factor authentication for better privacy."
            };

            keywordResponses["scam"] = new List<string>()
            {
                "Never click suspicious links.",
                "Scammers often pretend to be trusted organisations.",
                "Always verify emails before responding."
            };

            keywordResponses["phishing"] = new List<string>()
            {
                "Be careful of emails asking for personal information.",
                "Phishing emails often create fake urgency.",
                "Do not open suspicious attachments."
            };

            keywordResponses["hacking"] = new List<string>()
            {
                "Keep your software updated.",
                "Use antivirus software to reduce risks.",
                "Avoid downloading files from unknown websitess."
            };
        }

        public bool HasKeyword(string input)
        {
            input = input.ToLower();

            foreach (string keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    return true;
                }
            }

            return false;
        }

        public string GetKeyword(string input)
        {
            input = input.ToLower();

            foreach (string keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    return keyword;
                }
            }

            return "";
        }

        public string GetResponse(string keyword)
        {
            if (keywordResponses.ContainsKey(keyword))
            {
                List<string> responses = keywordResponses[keyword];

                int index = random.Next(responses.Count);

                return responses[index];
            }

            return "I am not sure about that topic.";
        }
    }
}