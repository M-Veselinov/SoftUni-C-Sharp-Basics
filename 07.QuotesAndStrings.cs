using System;

namespace QuotesAndStrings
{
    class QuotesAndStrings
    {
        static void Main()
        {
            string first = "The \"use\" of quotations causes difficulties.";
            string second = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(first + "\n" + second);
        }
    }
}
