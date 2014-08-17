using System;

namespace NumbersNotDivisibleBy3and7
{
    class NumbersNotDivisibleBy3and7
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);

            Console.WriteLine("Numbers from 1 to your number that are not divisible by 3 and 7 :");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    
                }
                else
                {
                    Console.Write(i + " ");
                }
                 
            }

        }
    }
}
