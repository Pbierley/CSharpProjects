using System;

namespace MyApplication
{


    class Program
    {
        static void Main(string[] args)
        {
             Random random = new Random();

            int randomNum = random.Next(1, 101);
            Console.WriteLine("Welcome to the number guessing application!");
            Console.WriteLine("Please guess a number between 1 and 100:");
            int guess;
            Boolean guessValid = false;
            while (!guessValid)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNum)
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    guessValid = true;
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low.");
                    Console.WriteLine("Please try again:");
                }
                else
                {
                    Console.WriteLine("Your guess is too high.");
                    Console.WriteLine("Please try again:");
                }
            }


        }
    }
}