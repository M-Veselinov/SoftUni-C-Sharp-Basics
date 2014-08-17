using System;

namespace ConsoleInputOutput
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter value for A :");
            string inputA = Console.ReadLine();
            double a = double.Parse(inputA);
            //Value for B
            Console.WriteLine("Enter value for B :");
            string inputB = Console.ReadLine();
            double b = double.Parse(inputB);
            //Value for C
            Console.WriteLine("Enter value for C :");
            string inputC = Console.ReadLine();
            double c = double.Parse(inputC);
            //Calculating
            double solution = a + b + c; 
            Console.WriteLine("This is the sum of your 3 numbers :");
            Console.WriteLine(solution);

        }
    }
}
