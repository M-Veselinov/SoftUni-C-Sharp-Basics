using System;


namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            //Value for A
            Console.WriteLine("Enter value for A (0 <= a <= 500) :");
            string inputA = Console.ReadLine();
            int a = int.Parse(inputA);
            if (a >= 0 && a <= 500)
            {
            }
            else
            {
                Console.WriteLine("Your number must be must be appropiate !");
            }
            string hexValue = a.ToString("X");
            int numAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            //Value for B
            Console.WriteLine("Enter value for B :");
            string inputB = Console.ReadLine();
            float b = float.Parse(inputB);
            //Value for C
            Console.WriteLine("Enter value for C :");
            string inputC = Console.ReadLine();
            float c = float.Parse(inputC);
            //Table
            Console.Write("|{0,-10}|",hexValue);
            Console.Write(Convert.ToString(numAgain, 2).PadLeft(10, '0'));
            Console.Write("|{0,10:F2}|",b);
            Console.WriteLine("{0,-10:F3}|", c);

        }
    }
}
