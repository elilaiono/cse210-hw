using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of number, type 0 when finsihed");
        List <int> numbers;
        numbers = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Please enter a number: ");
            string response = Console.ReadLine();
            userInput = int.Parse(response);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
            else 
            {
                Console.WriteLine($"The sum is {numbers.Sum()}");
                Console.WriteLine($"The average is {numbers.Average()}");
                Console.WriteLine($"The highest number is {numbers.Max()}");
            }
            
        }
            
    }
}