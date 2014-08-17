using System;

namespace NumberAsWords
{
    class NumbersAsWords
    {
            public static string NumberToWords(int number)
            {

             if (number == 0)
             {
                return "zero";
             }

             if (number < 0)
             {
                 return "minus " + NumberToWords(Math.Abs(number));
             }

             string words = "";

             if ((number / 100) > 0)
             {
                 return "hundred";
             }
            }
    }

}
        
