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
            //n! / (k! * (n-k)!)
            int factN = 1;
            int factK = 1;
            int factBoth = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                }

                for (int j = 1; j <= k; j++)
                {
                    factK *= j;
                }

                for (int h = 1; h <= (n-k); h++)
                {
                    factBoth *= h;
                }

                int combinations = factN / (factK * factBoth);
                Console.WriteLine(combinations);
            }

            else
            {
                Console.WriteLine("Invalid number !");
            }
        }
    }
}
