using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the number between 0 - 100");

        Random random = new Random();

        int min = 0;

        int max = 100;

        random.Next(min, max + 1);

    }
}