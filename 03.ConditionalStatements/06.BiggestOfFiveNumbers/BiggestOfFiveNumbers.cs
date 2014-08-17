using System;

namespace BiggestOfFiveNumbers
{
    class BiggestOfFiveNumbers
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
            
            Console.WriteLine("Enter your fourth number :");
            string inputFourthNumber = Console.ReadLine();
            double fourthNumber = double.Parse(inputFourthNumber);

            Console.WriteLine("Enter your fifth number :");
            string inputFifthNumber = Console.ReadLine();
            double fifthNumber = double.Parse(inputFifthNumber);

            if (firstNumber >= secondNumber && firstNumber >= thirdNumber && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
            {
                Console.WriteLine("Result");
                Console.WriteLine(firstNumber);
            }
            
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
            {
                Console.WriteLine("Result");
                Console.WriteLine(firstNumber);
            }

            else if (thirdNumber >= secondNumber && thirdNumber >= firstNumber && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
            {
                Console.WriteLine("Result");
                Console.WriteLine(thirdNumber);
            }

            else if (fourthNumber >= secondNumber && fourthNumber >= thirdNumber && fourthNumber >= firstNumber && fourthNumber >= fifthNumber)
            {
                Console.WriteLine("Result");
                Console.WriteLine(fourthNumber);
            }

            else if (fifthNumber >= secondNumber && fifthNumber >= thirdNumber && fifthNumber >= fourthNumber && fifthNumber >= firstNumber)
            {
                Console.WriteLine("Result");
                Console.WriteLine(fifthNumber);
            }
        }
    }
}
