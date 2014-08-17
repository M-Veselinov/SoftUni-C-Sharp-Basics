using System;


namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your circle radius :");
            string inputR = Console.ReadLine();
            double r = double.Parse(inputR);

            double n = 3.14;
            double p = 2 * n * r;

            Console.WriteLine("Perimeter of your circle is :");
            Console.WriteLine("{0:F2}",p);

            double a = n * (r * r);
            Console.WriteLine("Area of your circle is :");
            Console.WriteLine("{0:F2}",a);
        }
    }
}
