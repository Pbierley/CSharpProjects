
using System;
namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2.0;
            double a = Math.Pow(x, 3);
            Console.WriteLine("2 cubed is " + a);

            double b = Math.Abs(-3.5);
            Console.WriteLine("The absolute value of -3.5 is " + b);
            b = Math.Round(b);
            Console.WriteLine("The rounded value of b is " + b);
            double g = Math.Max(x,a);
            Console.WriteLine("The maximum of x and a is " + g);
            Console.ReadKey();
        }
    }
}