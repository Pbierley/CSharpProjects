using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, We are going to run some investment calculations!");
            Prompts();
        }
        static void Prompts()
        {
            Console.WriteLine("Hello whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", how much money do you have invested? (its okay if its 0)");
            string input = Console.ReadLine();
            double principal;
            while (!double.TryParse(input, out principal) || principal < 0)
            {
                Console.WriteLine("Please enter a valid number for your investment.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Great! You have $" + principal + " invested.");
            Console.WriteLine("What is the expected annual return rate (in decimal)?");
            string rateInput = Console.ReadLine();
            double annualInterestRate;
            while (!double.TryParse(rateInput, out annualInterestRate) || annualInterestRate < 0 || annualInterestRate > 1)
            {
                Console.WriteLine("Please enter a valid non-negative number for the return rate (between 0 and 1).");
                rateInput = Console.ReadLine();
            }


            Console.WriteLine("How many years are you planning to invest for?");
            string yearsInput = Console.ReadLine();
            int years;
            while (!int.TryParse(yearsInput, out years) || years < 0)
            {
                Console.WriteLine("Please enter a valid non-negative number for the number of years.");
                yearsInput = Console.ReadLine();
            }
            Console.WriteLine("Are you planning on continuing to invest more money? (yes/no)");
            string continueInvesting = Console.ReadLine().ToLower();
            while (continueInvesting != "yes" && continueInvesting != "no")
            {
                Console.WriteLine("Please answer with 'yes' or 'no'. Are you planning on continuing to invest more money?");
                continueInvesting = Console.ReadLine().ToLower();
            }
            if (continueInvesting == "yes")
            {
                Console.WriteLine("How much more do you plan to invest per year?");
                string additionalInput = Console.ReadLine();
                double annualContribution;
                while (!double.TryParse(additionalInput, out annualContribution) || annualContribution < 0)
                {
                    Console.WriteLine("Please enter a valid non-negative number for the additional investment.");
                    additionalInput = Console.ReadLine();
                }


                Console.WriteLine("Thank you! Based on your investment of " + principal + " and an expected annual return rate of " + annualInterestRate * 100+ "%, and with annual contributions of " + annualContribution + " we can calculate your potential returns.");
                //  use compunding interest formula with additional contributions
                double futureValue = principal * Math.Pow(1 + annualInterestRate, years) +
                             annualContribution * ((Math.Pow(1 + annualInterestRate, years) - 1) / annualInterestRate);
                Console.WriteLine("After " + years + " years, your investment will grow to: " + futureValue.ToString("C") + ".");
                Console.WriteLine("Thank you for using our investment calculator, " + name + "!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            else
            {
                double futureValue = principal * Math.Pow(1 + annualInterestRate, 10); // Assuming a default of 10 years if no additional contributions
                Console.WriteLine("Thank you! Based on your investment of " + principal + " and an expected annual return rate of " + annualInterestRate * 100 + "%, we can calculate your potential returns.");
                Console.WriteLine("After " + years + " years, your investment will grow to: " + futureValue.ToString("C") + ".");
                Console.WriteLine("Thank you for using our investment calculator, " + name + "!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}