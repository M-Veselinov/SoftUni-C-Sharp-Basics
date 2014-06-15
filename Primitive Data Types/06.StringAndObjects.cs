
using System;

namespace StringsAndObjects
{
    class StringAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object both = hello + " " + world;
            string third = (string)both;
            Console.WriteLine(third);
            }
        }
    }

