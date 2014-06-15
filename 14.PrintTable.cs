using System;


namespace PrintTheASCIITable
{
    class PrintTable
    {
        static void Main()
        {


            for (byte symbol = 0; symbol < 255; symbol++)
            {
                Console.WriteLine((char)symbol);
            }
        }
    }
}
