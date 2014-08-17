using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main()
        {
            Console.Write("Enter number:");
            string inputNumber = Console.ReadLine();
            int number = int.Parse(inputNumber);
            //Console.Write("{0:F5}",number);
            Console.WriteLine("All numbers in the interval 1 ... Your number :");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
