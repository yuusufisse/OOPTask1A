using System;
using System.Threading;

namespace OOPTask1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-EN");
            bool stillMore = false;
            double amountOfLoad;
            double annualIntrestRate;
            int numberOfYears;
            int numberOfPayments;
            double monthlyIntrestRate;
            double monthlyPayment;
            double totalPaymentPaid;
            double totalIntrestPaid;
            do
            {
                Console.Write("Enter your loan: ");
                string givenValue = Console.ReadLine();
                //Type? 
                while(!Double.TryParse(givenValue, out amountOfLoad) || amountOfLoad < 0)
                {
                    Console.Write("Wrong type or negative value, try again: ");
                    givenValue = Console.ReadLine();
                }

                Console.Write("Enter your annual intrest rate: ");
                givenValue = Console.ReadLine();
                //Type? 
                while (!Double.TryParse(givenValue, out annualIntrestRate) || annualIntrestRate < 0)
                {
                    Console.Write("Wrong type or negative value, try again: ");
                    givenValue = Console.ReadLine();
                }

                Console.Write("Number of years: ");
                givenValue = Console.ReadLine();
                //Type? 
                while (!Int32.TryParse(givenValue, out numberOfYears) || numberOfYears < 0)
                {
                    Console.Write("Wrong type or negative value, try again: ");
                    givenValue = Console.ReadLine();
                }

                monthlyIntrestRate = annualIntrestRate / 12;
                numberOfPayments = numberOfYears * 12;

                //Now we have all the information needed.
                monthlyPayment = monthlyIntrestRate * Math.Pow((1 + monthlyIntrestRate), numberOfPayments) * amountOfLoad / (Math.Pow((1 + monthlyIntrestRate), numberOfPayments) - 1);
                totalPaymentPaid = numberOfPayments * monthlyPayment;
                totalIntrestPaid = totalPaymentPaid - amountOfLoad;

                Console.WriteLine("Given loan was {0:F2}.", amountOfLoad);
                Console.WriteLine("Annual intrest rate was {0:F3}.", annualIntrestRate);
                Console.WriteLine("Number of years was {0}.", numberOfYears);
                Console.WriteLine("Number of monthss was {0}.", numberOfPayments);
                Console.WriteLine("Monthly intrest rate was {0:F4}.", monthlyIntrestRate);
                Console.WriteLine("Monthly payment was {0:F2} euros.", monthlyPayment);
                Console.WriteLine("You will pay in total {0:F2} euros.", totalPaymentPaid);
                Console.WriteLine("You will pay intrest in total {0:F2} euros.", totalIntrestPaid);

                //More?
                Console.Write("More values? Y/N: ");
                string yourChoice = Console.ReadLine().ToUpper();
                if (yourChoice.StartsWith("Y"))
                    stillMore = true;
                else
                    stillMore = false;
            } while (stillMore);
        }
    }
}
