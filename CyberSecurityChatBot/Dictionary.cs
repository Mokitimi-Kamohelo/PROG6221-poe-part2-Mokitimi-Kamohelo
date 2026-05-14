Dictionary<string, List<string>> keywordResponses =
    new Dictionary<string, List<string>>();

keywordResponses["password"] = new List<string>()
{
    "Use strong passwords with symbols and numbers.",
    "Avoid using your birthday in passwords.",
    "Use different passwords for different accounts."
};

keywordResponses["privacy"] = new List<string>()
{
    "Review your privacy settings regularly.",
    "Avoid sharing personal information online.",
    "Use two-factor authentication for extra protection."
};

keywordResponses["scam"] = new List<string>()
{
    "Never click suspicious links.",
    "Scammers often pretend to be trusted organisations.",
    "Verify emails before sharing information."
};

Random rand = new Random();

List<string> responses = keywordResponses["password"];

string response = responses[rand.Next(responses.Count)];