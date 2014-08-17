using System;

namespace NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber 
    {
        static void Main()
        {
            Console.WriteLine("Start");
            string inputStart = Console.ReadLine();
            int start = int.Parse(inputStart);

            Console.WriteLine("End");
            string inputEnd = Console.ReadLine();
            int end = int.Parse(inputEnd);
            
            for (int i = 0; i <= end; i++)
                {
                    if (i >= start)
                    {
                        if (i % 5 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
        }
  }

