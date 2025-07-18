using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first side (A):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the first side (B):");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"The length of the hypotenuse (C) is: " + c);
        }
    }
}