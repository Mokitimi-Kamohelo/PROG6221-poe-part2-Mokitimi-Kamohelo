namespace CyberSecurityChatbot
{
    public class MemoryManager
    {
        public string UserName { get; set; }
        public string FavouriteTopic { get; set; }
        public string LastTopic { get; set; }

        public MemoryManager()
        {
            UserName = "";
            FavouriteTopic = "";
            LastTopic = "";
        }
    }
}