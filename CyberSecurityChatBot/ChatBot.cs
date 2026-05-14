using System;
using CyberSecurityChatBot;

namespace CyberSecurityChatbot
{
    class ChatBot
    {
        private ResponseSystem responseSystem;
        private MemoryManager memory;
        private SentimentAnalyzer sentimentAnalyzer;

        public ChatBot()
        {
            responseSystem = new ResponseSystem();
            memory = new MemoryManager();
            sentimentAnalyzer = new SentimentAnalyzer();
        }

        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                return "Please enter a message.";
            }

            userInput = userInput.ToLower();

            // STORE NAME
            if (userInput.StartsWith("my name is"))
            {
                string name = userInput.Replace("my name is", "").Trim();

                memory.UserName = name;

                return "Nice to meet you, " + name + "!";
            }

            // STORE FAVOURITE TOPIC
            if (userInput.Contains("i'm interested in"))
            {
                string[] words = userInput.Split(' ');

                string topic = words[words.Length - 1];

                memory.FavouriteTopic = topic;
                memory.LastTopic = topic;

                return "Great! I'll remember that you're interested in " + topic + ".";
            }

            // SENTIMENT DETECTION
            string sentiment = sentimentAnalyzer.DetectSentiment(userInput);

            if (sentiment == "worried")
            {
                if (responseSystem.HasKeyword(userInput))
                {
                    string keyword = responseSystem.GetKeyword(userInput);

                    memory.LastTopic = keyword;

                    return "It's understandable to feel worried. "
                        + responseSystem.GetResponse(keyword);
                }

                return "It's okay to feel worried about cybersecurity. Staying informed helps keep you safe.";
            }

            if (sentiment == "frustrated")
            {
                return "No problem. Let me explain things more simply.";
            }

            if (sentiment == "curious")
            {
                return "Curiosity is great when learning about cybersecurity!";
            }

            // FOLLOW-UP QUESTIONS
            if (userInput.Contains("tell me more") ||
                userInput.Contains("another tip") ||
                userInput.Contains("explain more"))
            {
                if (!string.IsNullOrEmpty(memory.LastTopic))
                {
                    return responseSystem.GetResponse(memory.LastTopic);
                }

                return "Can you tell me which cybersecurity topic you want to know more about?";
            }

            // KEYWORD RECOGNITION
            if (responseSystem.HasKeyword(userInput))
            {
                string keyword = responseSystem.GetKeyword(userInput);

                memory.LastTopic = keyword;

                return responseSystem.GetResponse(keyword);
            }

            // PERSONALISED RESPONSE
            if (userInput.Contains("favourite topic"))
            {
                if (!string.IsNullOrEmpty(memory.FavouriteTopic))
                {
                    return "Your favourite cybersecurity topic is "
                        + memory.FavouriteTopic + ".";
                }

                return "You haven't shared your favourite topic yet.";
            }

            // GREETING
            if (userInput.Contains("hello") ||
                userInput.Contains("hi"))
            {
                if (!string.IsNullOrEmpty(memory.UserName))
                {
                    return "Hello again, " + memory.UserName + "!";
                }

                return "Hello! How can I help you with cybersecurity today?";
            }

            // DEFAULT RESPONSE
            return "I'm not sure I understand. Can you try rephrasing?";
        }

        internal void Start()
        {
            throw new NotImplementedException();
        }
    }
}