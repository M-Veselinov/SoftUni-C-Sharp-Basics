using System;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string fname = "Ivan";
            string lname = "Petrov";
            byte age = 45;
            string gender = "Male";
            long id = 8306112507;
            ulong number = 2756000027569999;

            Console.WriteLine("First Name:");
            Console.WriteLine(fname);
            Console.WriteLine("Last Name:");
            Console.WriteLine(lname);
            Console.WriteLine("Age:");
            Console.WriteLine(age);
            Console.WriteLine("Gender:");
            Console.WriteLine(gender);
            Console.WriteLine("Personal ID number:");
            Console.WriteLine(id);
            Console.WriteLine("Unique employee number:");
            Console.WriteLine(number);

        }
    }
}
