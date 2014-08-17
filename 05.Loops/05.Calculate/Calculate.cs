using System;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter number N :");
            string inputN = Console.ReadLine();
            double n = double.Parse(inputN);

            Console.WriteLine("Enter number X :");
            string inputX = Console.ReadLine();
            double x = double.Parse(inputX);
            double factorialN = 1;
            double xPowerN = 1;
            double sumOfXandN = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                xPowerN *= x;
                sumOfXandN += (factorialN / xPowerN);
                
            }
            Console.WriteLine("{0:F5} ", sumOfXandN);
        }
    }
}
