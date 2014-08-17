using System;
using BinaryToDecimal;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] != '0')
                {
                    result += (long)Math.Pow(2, i);
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
