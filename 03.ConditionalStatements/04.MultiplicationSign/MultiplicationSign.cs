using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number :");
            string inputFirstNumber = Console.ReadLine();
            double firstNumber = double.Parse(inputFirstNumber);

            Console.WriteLine("Enter your second number :");
            string inputSecondNumber = Console.ReadLine();
            double secondNumber = double.Parse(inputSecondNumber);

            Console.WriteLine("Enter your second number :");
            string inputThirdNumber = Console.ReadLine();
            double thirdNumber = double.Parse(inputThirdNumber);

            if (firstNumber < 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber < 0)
                    {
                        Console.WriteLine("Result");
                        Console.WriteLine("-");
                    }
                }
            }

            if (firstNumber > 0)
            {
                if (secondNumber > 0)
                {
                    if (thirdNumber > 0)
                    {
                        Console.WriteLine("Result");
                        Console.WriteLine("+");
                    }
                }
            }

            if (firstNumber < 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber > 0)
                    {
                        Console.WriteLine("Result");
                        Console.WriteLine("-");
                    }
                }
            }

            if (firstNumber == 0)
            {
                if (secondNumber < 0)
                {
                    if (thirdNumber > 0)
                    {
                        Console.WriteLine("Result");
                        Console.WriteLine("0");
                    }
                }
            }

            if (firstNumber < 0)
            {
                if (secondNumber > 0)
                {
                    if (thirdNumber > 0)
                    {
                        Console.WriteLine("Result");
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}
