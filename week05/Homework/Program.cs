using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assgn1 = new Assignment("Kasia", "Cats");
        Console.WriteLine(assgn1.GetSummary());

        MathAssignment assgn2 = new MathAssignment("Jakub", "Cars", "7.3", "8-19");
        Console.WriteLine(assgn2.GetSummary());
        Console.WriteLine(assgn2.GetHomeworkList());

        WritingAssignment assgn3 = new WritingAssignment("Agata", "War", "The Causes of World War II by Mary Waters");
        Console.WriteLine(assgn3.GetSummary());
        Console.WriteLine(assgn3.GetWritingInformation());
    }
}