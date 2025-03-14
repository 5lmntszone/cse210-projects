public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best thing that happened to me today?",
        "What is one thing I learned today?",
        "How did I make progress toward my goals today?",
        "What am I grateful for today?"
    };

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No questions available.";
        }
        else
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            string selectedPrompt = _prompts[index];

            _prompts.RemoveAt(index);
            return selectedPrompt;
        }
    }
}