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
            } while (stillMore);
        }
    }
}
