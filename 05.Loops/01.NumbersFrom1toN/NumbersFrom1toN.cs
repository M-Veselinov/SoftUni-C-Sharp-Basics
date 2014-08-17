using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);

            Console.WriteLine("Numbers from 1 to your number :");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
