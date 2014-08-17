using System;
          //"\u2663", "\u2666", "\u2665", "\u2660"
namespace PrintADeck_2
{
    class PrinAdeck
    {
        static void Main()
        {
            
            string spade = "\u2663 ";
            string diamond = "\u2666 ";
            string heart = "\u2665 ";
            string club = "\u2660 ";

            for (int i = 0; i < 13; i++)
            {
                    switch (i)
                    {
                        case 1: Console.Write(2 + spade);
                                Console.Write(2 + diamond);
                                Console.Write(2 + heart);
                                Console.Write(2 + club); break;
                        case 2: Console.Write(3 + spade);
                                Console.Write(3 + diamond);
                                Console.Write(3 + heart);
                                Console.Write(3 + club); break;
                        case 3: Console.Write(4 + spade);
                                Console.Write(4 + diamond);
                                Console.Write(4 + heart);
                                Console.Write(4 + club); break;
                        case 4: Console.Write(5 + spade);
                                Console.Write(5 + diamond);
                                Console.Write(5 + heart);
                                Console.Write(5 + club); break;
                        case 5: Console.Write(6 + spade);
                                Console.Write(6 + diamond);
                                Console.Write(6 + heart);
                                Console.Write(6 + club); break;
                        case 6: Console.Write(7 + spade);
                                Console.Write(7 + diamond);
                                Console.Write(7 + heart);
                                Console.Write(7 + club); break;
                        case 7: Console.Write(8 + spade);
                                Console.Write(8 + diamond);
                                Console.Write(8 + heart);
                                Console.Write(8 + club); break;
                        case 8: Console.Write(9 + spade);
                                Console.Write(9 + diamond);
                                Console.Write(9 + heart);
                                Console.Write(9 + club); break;
                        case 9: Console.Write(10 + spade);
                                Console.Write(10 + diamond);
                                Console.Write(10 + heart);
                                Console.Write(10 + club); break;
                        case 10: Console.Write("J" + spade);
                                Console.Write("J" + diamond);
                                Console.Write("J" + heart);
                                Console.Write("J" + club); break;
                        case 11: Console.Write("Q" + spade);
                                Console.Write("Q" + diamond);
                                Console.Write("Q" + heart);
                                Console.Write("Q" + club); break;
                        case 12: Console.Write("K" + spade);
                                Console.Write("K" + diamond);
                                Console.Write("K" + heart);
                                Console.Write("K" + club); break;
                        case 13: Console.Write("A" + spade);
                                Console.Write("A" + diamond);
                                Console.Write("A" + heart);
                                Console.Write("A" + club); break;

                        default:
                            break;
                    }
                Console.WriteLine();
            }

        }
    }
}
