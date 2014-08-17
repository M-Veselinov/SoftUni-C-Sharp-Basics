using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Your numbers must be as follows:(1 < n < 100)");
            Console.WriteLine("Enter number N :");
            string inputN = Console.ReadLine();
            int n = int.Parse(inputN);
            int m = 1;
            int x = n;
            int y = n;

            for (int i = 1; i <= x; i++)
            {
                m = i;
                Console.WriteLine();

                for (int j = 1; j <= y;j++)
                {
                    Console.Write((j + m) - 1 + " ");
                }
            }
        }

    }
}
