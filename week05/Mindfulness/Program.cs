using System;

class Program
{
    static void Main(string[] args)
    {
        // I've added a log of how many times activities were performed.
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflecting Activity", 0 },
            { "Listing Activity", 0 }
        };

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityLog["Breathing Activity"]++;
                    break;
                
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    activityLog["Reflecting Activity"]++;
                    break;
                
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityLog["Listing Activity"]++;
                    break;
                
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    Console.WriteLine("\nHere’s how many times you did each activity:");
    
                    foreach (var entry in activityLog)
                    {
                        Console.WriteLine($"- {entry.Key}: {entry.Value} time(s)");
                    }
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    Thread.Sleep(2000);
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}