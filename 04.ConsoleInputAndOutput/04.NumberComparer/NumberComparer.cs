using System;


namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter your first number :");
            string inputA = Console.ReadLine();
            double a = double.Parse(inputA);

            Console.WriteLine("Enter your second number :");
            string inputB = Console.ReadLine();
            double b = double.Parse(inputB);

            Console.WriteLine("The bigger number is :");
            Console.WriteLine(Math.Max(a,b));

        }
    }
}
