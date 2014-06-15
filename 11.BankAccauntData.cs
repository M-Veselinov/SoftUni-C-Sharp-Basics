using System;

namespace BankAccountData
{
    class BankAccount
    {
        static void Main()
        {
            string name = "Ivan Petrov Todorov";
            double balance = 235.65;
            string bank = "FiBank";
            long firstnumber = 371449635398431;
            long secondnumber = 343434343434343;
            long thirdnumber = 371144371144376;

            Console.WriteLine("Name:");
            Console.WriteLine(name);
            Console.WriteLine("Balance:");
            Console.WriteLine(balance + "BGN");
            Console.WriteLine("Bank Name:");
            Console.WriteLine(bank);
            Console.WriteLine("Credit Card Numbers:");
            Console.WriteLine(firstnumber);
            Console.WriteLine(secondnumber);
            Console.WriteLine(thirdnumber);

        }
    }
}
