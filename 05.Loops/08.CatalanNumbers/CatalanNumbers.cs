using System;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.WriteLine("Your numbers must be as follows:(1 < n < 100)");
            Console.WriteLine("Enter number N :");
            string inputN = Console.ReadLine();
            double n = double.Parse(inputN);
            double doubleN = 2 * n;
            double factDoubleN = 1;
            double factN = 1;
            if (1 < n && n < 100)
            {
                for (double i = 1; i <= doubleN; i++)
                {
                    factDoubleN *= i;
                }

                for (double j = 1; j <= n; j++)
                {
                    factN *= j;
                }

                double factNmultiplied = factN * factN;
                double binomialCoefficient = factDoubleN / factNmultiplied;
                double result = (1 / (n + 1)) * binomialCoefficient;

                Console.WriteLine("N th Catalan number is :");
                Console.WriteLine(result);
                
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
