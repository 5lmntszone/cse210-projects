using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity1 = new Activity("Breathing Activity", "Breathing");
        activity1.DisplayStartingMessage();
        activity1.DisplayEndingMessage();
    }
}