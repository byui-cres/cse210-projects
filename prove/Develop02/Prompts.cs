class Prompts
{
    public List<string> promptList = new List<string>() { "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?" };

    private int RandomPromptsIndex()
    {
        Random rnd = new Random();
		int randPromptIndex = rnd.Next(promptList.Count);
		return randPromptIndex;
    }
    public string DisplayPrompts()
    {
        int promptIndex = RandomPromptsIndex();
        string randPrompt = promptList[promptIndex];
        return randPrompt;
    }

}