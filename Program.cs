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
                //More?
                Console.Write("More values? Y/N: ");
                string yourChoice = Console.ReadLine().ToUpper();
                if (yourChoice.StartsWith("Y"))
                    stillMore = true;
                else
                    stillMore = false;
            } while (stillMore);

            Console.WriteLine("Given loan was {0:F2}.", amountOfLoad);
        }
    }
}
