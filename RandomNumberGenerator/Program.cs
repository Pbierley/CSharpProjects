
using System;
namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            
            Console.WriteLine("Welcome to the Dice Roller!");
            Console.WriteLine("Please enter the number of sides on the die (default is 6):");
            string input = Console.ReadLine();
            if(Int32.TryParse(input, out int sidesInput) == false)
            {
                input = "6";
                Console.WriteLine("Invalid input, defaulting to 6 sides.");
            }
            int sides = Int32.Parse(input);
            sides++;
            Console.WriteLine("Please enter how many dice you want to roll (default is 1):");
            string diceCount = Console.ReadLine();
            if(Int32.TryParse(diceCount, out int result) == false)
            {
                diceCount = "1"; 
                Console.WriteLine("Invalid input, defaulting to 1 die.");
            }
            int diceCountInt = Int32.Parse(diceCount);
            Console.WriteLine("Press any key to roll the dice...");
            for(int i = 1; i - 1 < diceCountInt ; i++)
            {
                int num = random.Next(1, sides); 
                Console.WriteLine("Dice #"+ i + " was " + num);
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}