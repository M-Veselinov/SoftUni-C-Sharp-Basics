using System;

namespace PrintADeckOf52cards
{
    class PrintADeckOf52cards
    {
        static void Main()
        {
            string[] suits = new string[4] { "\u2663", "\u2666", "\u2665", "\u2660" };
            string[] cards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.Write(cards[i] + suits[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
