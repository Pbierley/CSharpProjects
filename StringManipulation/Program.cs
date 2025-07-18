using System;

namespace StringAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            Console.WriteLine(" Hi " + name + " Please enter your phone number using - to seperate area code:");
            String phoneNumber = Console.ReadLine();
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine("phoneNumber:" + phoneNumber);
        }
    }
}