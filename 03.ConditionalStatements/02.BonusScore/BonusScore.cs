using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Enter your score (must be between 1 and 9) :");
            string inputScore = Console.ReadLine();
            int score = int.Parse(inputScore);
            if (score > 0 && score <= 9)
            {
            }
            else
            {
                Console.WriteLine("Invalid score !");
            }
            //score x10
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Your score multiplied by 10 :");
                Console.WriteLine(score * 10);
            }
            //score x100
            if (score >= 4 && score <= 6)
            {
                Console.WriteLine("Your score multiplied by 100 :");
                Console.WriteLine(score * 100);
            }
            //score x1000
            if (score >= 7 && score <= 9)
            {
                Console.WriteLine("Your score multiplied by 1000 :");
                Console.WriteLine(score * 1000);
            }
        }
    }
}
