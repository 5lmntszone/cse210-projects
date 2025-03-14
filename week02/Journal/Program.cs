using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        PromptGenerator generator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("\nEnter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("\nEnter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}