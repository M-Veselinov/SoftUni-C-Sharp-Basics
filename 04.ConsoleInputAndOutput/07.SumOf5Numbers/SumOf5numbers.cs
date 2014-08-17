using System;

namespace  SumOf5Numbers
{
    class SumOf5numbers
    {
        static void Main()
        {
            //first number
            string numbersAsString = Console.ReadLine();
            string[] numbers = numbersAsString.Split(' ');
            decimal result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + decimal.Parse(numbers[i]);
            }
            
            Console.SetCursorPosition(numbersAsString.Length + 1, 0);
            Console.Write(result);
            Console.WriteLine();

        }
    }
}
