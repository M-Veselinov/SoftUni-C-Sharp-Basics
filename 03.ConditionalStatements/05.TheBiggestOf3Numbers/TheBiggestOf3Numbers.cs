using System;

namespace TheBiggestOf3Numbers

{

    class TheBiggestOf3Numbers
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

            if (firstNumber > secondNumber && firstNumber  > thirdNumber)
            {
                Console.WriteLine("Biggest number is :");
                Console.WriteLine(firstNumber);
            }
            else
            {
                if (secondNumber > firstNumber && secondNumber > thirdNumber)
                {
                    Console.WriteLine("Biggest number is :");
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    if (thirdNumber > firstNumber && thirdNumber > secondNumber)
                    {
                        Console.WriteLine("Biggest number is :");
                        Console.WriteLine(thirdNumber);
                    }
                }
            }
        }
    }
}
