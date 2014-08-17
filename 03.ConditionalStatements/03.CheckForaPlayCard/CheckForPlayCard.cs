using System;


namespace CheckForaPlayCard
{
    class CheckForPlayCard
    {
        static void Main()
        {
            Console.WriteLine("Enter you play card sign :");
            string inputSign = Console.ReadLine();

            switch (inputSign)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A": Console.WriteLine("Yes,it is vali card sign"); break;




                default: Console.WriteLine("No"); break;
            }

        }
    }
}   

