using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            int oddProduct = 1;
            int evenProduct = 1;

            for (int index = 0; index < array.Length; index++)
            {
                int number = int.Parse(array[index]);

                if (index % 2 == 0)
                {
                    evenProduct *= number;
                }

                else
                {
                    oddProduct *= number;
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("product = " + evenProduct);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd product = " + oddProduct);
                Console.WriteLine("Even product = " + evenProduct);
            }
        }
    }
}
