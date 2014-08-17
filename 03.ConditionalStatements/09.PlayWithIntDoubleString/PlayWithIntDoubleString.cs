using System;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type :");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            string inputType = Console.ReadLine();
            int type = int.Parse(inputType);

            if (type == 2)
            {
                Console.WriteLine("Enter a double :");
                string inputDouble = Console.ReadLine();
                double doubleVar = double.Parse(inputDouble);
                Console.WriteLine(doubleVar + 1);
            }
            else if (type == 3)
            {
                Console.WriteLine("Enter a string :");
                string inputString = Console.ReadLine();
                Console.WriteLine("{0}*", inputString);
            }
            else if (type == 1)
            {
                Console.WriteLine("Enter a integer :");
                string inputInt = Console.ReadLine();
                int intVar = int.Parse(inputInt);
                Console.WriteLine(intVar + 1);
            }
        }
    }
}
