using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
             letter = "A";
        }
        else if (grade >= 80)
        {
             letter = "B";
        }
        else if (grade >= 70)
        {
             letter = "C";
        }
        else if (grade >= 60)
        {
             letter = "D";
        }
        else 
        {
             letter = "F";
        }

        Console.WriteLine($"You recieved a/an {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed the class!! Well done!");
        }
        else 
        {
            Console.WriteLine("You let down your ancestors who came to America seeking a better life for their posterity. YOU FAILED!!!");
        }
    }
}