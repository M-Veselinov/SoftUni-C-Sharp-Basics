using System;

namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            DateTime beerTime = DateTime.Parse(Console.ReadLine());
            string designator = beerTime.ToString("tt");

            if (beerTime.Hour < 12)
            {
                if (designator == "AM")
                {


                    if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
                    {
                        Console.WriteLine("Non-beer time");
                    }
                    else
                    {
                        Console.WriteLine("Beer time");
                    }
                }
            }
            else
            {
                if (beerTime.Hour - 12 >= 1)
                {
                    Console.WriteLine("Beer time");
                }
                else
                {
                    Console.WriteLine("Non-beer time");
                }
            }

        }
    }
}
