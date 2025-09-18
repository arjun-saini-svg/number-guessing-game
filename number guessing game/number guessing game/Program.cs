using System;

class Program
{
    static void Main(string[] args)
    {

        bool playagain = true;

        int guesses = 0;

        while (playagain)
        {
            Console.WriteLine("Guess the number between 0 - 100");

            int guess = Convert.ToInt32(Console.ReadLine());

            int min = 0;

            int max = 100;

            Random random = new Random();

            int randomNumber = random.Next(min, max + 1);

            if (guess == randomNumber)
            {
                Console.WriteLine("You have guesses the number!");
                Console.WriteLine($"guesses you took: {guesses}");
            } else if (guess > randomNumber)
            {
                Console.WriteLine("The number you guessed is too high");
            } else if (guess < randomNumber)
            {
                Console.WriteLine("The number you used too low");
            }

            guesses++;

            Console.WriteLine("Wanna play again?: ");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y" || answer == "YES" || answer == "TRUE")
            {
                playagain = true;
            }
            else
            {
                playagain = false;
            }
        }



    }
}