using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            singHappyBirthday(name);
            Console.WriteLine("How old are you?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 0)
            {
                Console.WriteLine("Invalid age entered. Please enter a valid age.");
                age = Convert.ToInt32(Console.ReadLine());
            }
                Congratulations(name, age);
        }

        static void singHappyBirthday(string name)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("Happy birthday to you!");
        }
        static void Congratulations(string name, int age)
        {
            switch (age)
            {
                case 13:
                    {
                        Console.WriteLine("Happy 13th birthday, " + name + "! You are now a teenager!");
                        return;
                    }
                case 16:
                    {
                        Console.WriteLine("Congratulations! " + name + " You can now apply for a driving license.");
                        return;
                    }
                case 18:
                    {
                        Console.WriteLine("Happy 18th birthday, " + name + "! You are now an adult!");
                        return;
                    }
                case 20:
                    {
                        Console.WriteLine("Happy 20th birthday, " + name + "! You are now in your twenties! One more year to go until you can legally drink alcohol in the US!");
                        return;
                    }
                case 21:
                    {
                        Console.WriteLine("Happy 21st birthday, " + name + "! You can now legally drink alcohol in the US! Get Lit!");
                        return;
                    }
                case 30:
                    {
                        Console.WriteLine("Happy 30th birthday, " + name + "! Welcome to your thirties!");
                        return;
                    }
                case 65:
                    {
                        Console.WriteLine("Happy 65th birthday, " + name + "! You are now eligible for retirement benefits!");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Happy birthday, " + name + "! You are now " + age + " years old!");
                        return;
                    }
            }
        }
    }
}