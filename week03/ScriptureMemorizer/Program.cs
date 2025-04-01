using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 2, 25, 26);
        string scriptureText = "Adam fell that men might be; and men are, that they might have joy. And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall.";
        Scripture scripture = new Scripture(reference, scriptureText);
        bool userQuit = false;

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                userQuit = true;
                break;
            }

            scripture.HideRandomWords(3);
        }

        if (!userQuit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are now hidden. Program complete.");
        }
    }
}