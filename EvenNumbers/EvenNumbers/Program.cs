using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("evenNumbers(4,13) returns: " + evenNumbers(4, 13));
            Console.WriteLine("evenNumbers(3,10) returns: " + evenNumbers(3, 10));
            Console.WriteLine("evenNumbers(8,21) returns: " + evenNumbers(8, 21));

            Console.WriteLine();
            Console.ReadKey();

        }

        static string evenNumbers(int minNumber, int maxNumber)
        {
            string someString = "";
            for (int i = minNumber; i <= maxNumber; i++)
            {

                if (i % 2 == 0)
                {
                    someString += ", " + i;
                }

            }
            return someString;
        }
    }
}