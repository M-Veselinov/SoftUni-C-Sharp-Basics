using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double eps = 0.000001;
            double a = 1.000000;
            double b = 1.0000006;
            if (Math.Abs(a - b) < eps) 
            {
                Console.WriteLine("Equal");
            }

            else 
            {
                Console.WriteLine("NotEqual");
            }
        }
    }
}
