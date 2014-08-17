using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("How many members of the Fibonacci sequence you want to print ?");
            string countOfNumbers = Console.ReadLine();
            int numbers = int.Parse(countOfNumbers);
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < numbers; i++)
            {
                Console.Write(firstNumber + " ");
                int thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber += thirdNumber;

            }
        }
    }
}
