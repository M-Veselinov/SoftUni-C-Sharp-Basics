using System;

namespace SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number :");
            string inputFirstNumber = Console.ReadLine();
            double firstNumber = double.Parse(inputFirstNumber);

            Console.WriteLine("Enter your second number :");
            string inputSecondNumber = Console.ReadLine();
            double secondNumber = double.Parse(inputSecondNumber);

            Console.WriteLine("Enter your third number :");
            string inputThirdNumber = Console.ReadLine();
            double thirdNumber = double.Parse(inputThirdNumber);

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }

            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
                
            }

            else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                if (secondNumber >= firstNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                }
                
            }
        }
    }
}
