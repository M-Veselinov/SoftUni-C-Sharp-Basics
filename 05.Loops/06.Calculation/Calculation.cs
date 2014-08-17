using System;

namespace Calculation
{
    class Calculation
    {
        static void Main()
        {
            Console.WriteLine("Your numbers must be as follows:(1 < k < n < 100)");
            Console.WriteLine("Enter number N :");
            string inputN = Console.ReadLine();
            int n = int.Parse(inputN);

            Console.WriteLine("Enter number K :");
            string inputK = Console.ReadLine();
            int k = int.Parse(inputK);

            int factorialSum = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = n; i > k; i--)
                {
                    factorialSum *= i;
                }
                
                Console.WriteLine("The sum of N! / K! :"+factorialSum);
            }
            else
            {
                Console.WriteLine("You must enter valid numbers !");
            }
        }
    }
}
