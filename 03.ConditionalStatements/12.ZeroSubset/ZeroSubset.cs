using System;

namespace ZeroSubset
{
    class ZeroSubset
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


                if (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
                {
                    Console.Write(firstNumber);
                    Console.Write("+ {0}", secondNumber);
                    Console.Write("+ {0}", thirdNumber);
                    Console.Write("+ {0}", fourthNumber);
                    Console.Write("+ {0} =", fifthNumber);
                    Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber);
                }
                if (firstNumber + secondNumber == 0)
                {
                    Console.Write(firstNumber);
                    Console.Write("+ {0} =", secondNumber);
                    Console.WriteLine(firstNumber + secondNumber);
                }
                if (firstNumber + secondNumber + thirdNumber == 0)
                {
                    Console.Write(firstNumber);
                    Console.Write("+ {0}", secondNumber);
                    Console.Write("+ {0} =", thirdNumber);
                    Console.WriteLine(firstNumber + secondNumber + thirdNumber);
                }
                if (firstNumber + secondNumber + thirdNumber + fourthNumber == 0)
                {
                    Console.Write(firstNumber);
                    Console.Write("+ {0}", secondNumber);
                    Console.Write("+ {0}", thirdNumber);
                    Console.Write("+ {0} =", fourthNumber);
                    Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);
                }
                if (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0)
                {
                    Console.Write(secondNumber);
                    Console.Write("+ {0}", thirdNumber);
                    Console.Write("+ {0}", fourthNumber);
                    Console.Write("+ {0} =", fifthNumber);
                    Console.WriteLine(secondNumber + thirdNumber + fourthNumber + fifthNumber);
                }
                if (secondNumber + thirdNumber == 0)
                {
                    Console.Write(secondNumber);
                    Console.Write("+ {0} =", thirdNumber);
                    Console.WriteLine(secondNumber + thirdNumber);
                }
                if (secondNumber + thirdNumber + fourthNumber == 0)
                {
                    Console.Write(secondNumber);
                    Console.Write("+ {0}", thirdNumber);
                    Console.Write("+ {0} =",fourthNumber);
                    Console.WriteLine(secondNumber + thirdNumber + fourthNumber);
                }
                if (thirdNumber + fourthNumber == 0)
                {
                    Console.Write(thirdNumber);
                    Console.Write("+ {0} =", fourthNumber);
                    Console.WriteLine(thirdNumber + fourthNumber);
                }
                if (thirdNumber + fourthNumber + fifthNumber == 0)
                {
                    Console.Write(thirdNumber);
                    Console.Write("+ {0}", fourthNumber);
                    Console.Write("+ {0} =",fifthNumber);
                    Console.WriteLine(thirdNumber + fourthNumber + fifthNumber);
                }
                if (fourthNumber + fifthNumber == 0)
                {
                    Console.Write(fourthNumber);
                    Console.Write("+ {0} =", fifthNumber);
                    Console.WriteLine(fourthNumber + fifthNumber);
                }
            }

       }
}

