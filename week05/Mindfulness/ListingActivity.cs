public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;


    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nYou may begin in...");
        ShowCountDown(5);

        List<string> userItems = GetListFromUser();

        _count = userItems.Count;
        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (true)
    {
        if (DateTime.Now >= endTime)
        {
            Console.WriteLine("\n⏰ Time’s up!");
            break;
        }

        Console.Write("> ");
        string input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            items.Add(input);
        }
    }

        return items;
    }
}