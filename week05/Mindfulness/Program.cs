using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("welcome to the Mindfulness Program!");
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
                    break;
                
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
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