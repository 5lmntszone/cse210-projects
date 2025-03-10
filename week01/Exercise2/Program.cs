using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade procentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter;

        if (grade >= 70)
        {
            Console.WriteLine("Congrats!");

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else
            {
                letter = "C";
            }
        }
        else
        {
            Console.WriteLine("Sorry, good luck next time.");

            if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        }

        Console.WriteLine($"Your letter grade is: {letter}.");
    }
}