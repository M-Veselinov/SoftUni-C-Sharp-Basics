using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater

    {
        static void Main()
        {
            Console.WriteLine("Enter first number :");
            string inputFirstNumber = Console.ReadLine();
            double firstNumber = double.Parse(inputFirstNumber);

            Console.WriteLine("Enter second number :");
            string inputSecondNumber = Console.ReadLine();
            double secondNumber = double.Parse(inputSecondNumber);

            if (firstNumber > secondNumber)
            {
                double greater = secondNumber;
                secondNumber = firstNumber;
                firstNumber = greater;
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0} {1}", firstNumber, secondNumber);
            }
        }
    }
}
