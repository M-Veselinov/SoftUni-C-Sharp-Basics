using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long n = long.Parse(input);
            long k = n;
            for (long i = n;n > 0; i++)
            {
                if (n % 2 == 0)
                {
                    Console.Write("0");
                }
                else if (n % 2 != 0)
                {
                    Console.Write("1");
                }
                n = k / 2; 
            }

        }
    }
}
