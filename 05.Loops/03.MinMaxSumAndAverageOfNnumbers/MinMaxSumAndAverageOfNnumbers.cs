using System;

namespace MinMaxSumAndAverageOfNnumbers
{
    class MinMaxSumAndAverageOfNnumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);

            for (int i = 1; i <= number; i++)
            {

                string inputNumbers = Console.ReadLine();
                number = int.Parse(inputNumbers);

                Console.WriteLine(Math.Min(1, 2));
                //if (i == number)
                //{
                  //  Console.WriteLine(number + number);
                //}
                
            }
        }
    }
}
