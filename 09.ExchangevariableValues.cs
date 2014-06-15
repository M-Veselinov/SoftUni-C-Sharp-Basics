using System;

namespace ExchangeVariableValues
{
    class ExchangevariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            b = a;
            a = b+5;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
