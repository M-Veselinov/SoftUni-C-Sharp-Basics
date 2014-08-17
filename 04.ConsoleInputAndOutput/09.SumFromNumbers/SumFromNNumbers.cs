namespace SumFromNNumbers
   // Write a program that enters a number n and after that enters more n numbers
    //and calculates and prints their sum. Note that you may need to use a for-loop. Examples:
{
    using System;
    public static class SumFromNNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter how many numbers you want to sum :");
            string countOfNumbersAsString = Console.ReadLine();
            int countOfNumbers = int.Parse(countOfNumbersAsString);
            Console.WriteLine("Enter your numbers :");
            double result = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                string input = Console.ReadLine();
                double number = double.Parse(input);
                result+=number;
            }
            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(result);
        }
    }
}