using System;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Enter count of random numbers :");
            string inputN = Console.ReadLine();
            int n = int.Parse(inputN);

            Console.WriteLine("min = :");
            string inputmin = Console.ReadLine();
            int min = int.Parse(inputmin);

            Console.WriteLine("max = :");
            string inputMax = Console.ReadLine();
            int max = int.Parse(inputMax);

            if (min <= max)
            {
                Random random = new Random();
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(random.Next(min, max + 1) + " ");    
                }
                
            }
            }
        }
    }

