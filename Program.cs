using System;

namespace OOPTask1A
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillMore = false;
            do
            {
                Console.Write("Enter your loan: ");
                string givenValue = Console.ReadLine();
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
