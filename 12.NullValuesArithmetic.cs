using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? x = null;
            double? y = null;
            Console.WriteLine("Variable X:" + x);
            Console.WriteLine("Variable Y:" + y);
            //+5
            Console.WriteLine("X + 5:");
            Console.WriteLine(x+5);
            Console.WriteLine("Y + 4,5:");
            Console.WriteLine(y+5);
            //+ Null
            Console.WriteLine("X + null:");
            Console.WriteLine(x + null);
            Console.WriteLine("Y + null:");
            Console.WriteLine(y + null);

        }
    }
}