using System;


namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            //Requirments
            Console.WriteLine("Company name :");
            string inputName = Console.ReadLine();

            Console.WriteLine("Company address :");
            string inputAddress = Console.ReadLine();

            Console.WriteLine("Phone nubmer :");
            string inputPhone = Console.ReadLine();
            double phoneNumber = double.Parse(inputPhone);

            Console.WriteLine("Enter your fax number :");
            string inputFax = Console.ReadLine();

            Console.WriteLine("Enter your web site name :");
            string inputSiteName = Console.ReadLine();

            Console.WriteLine("Enter Manager First Name :");
            string Fname = Console.ReadLine();

            Console.WriteLine("Enter Manager Last Name :");
            string Lname = Console.ReadLine();

            Console.WriteLine("Enter Manager Age :");
            string inputage = Console.ReadLine();
            int age = int.Parse(inputage);

            Console.WriteLine("Enter manager phone number :");
            string inputMphone = Console.ReadLine();
            double managerPhone = double.Parse(inputMphone);

            //Information

            Console.WriteLine("Here is your information :");
            Console.WriteLine(inputName);
            Console.WriteLine("Address: {0}",inputAddress);
            Console.WriteLine("Phone number: {0}",phoneNumber);
            if (inputFax != null)
            {
                Console.WriteLine("(No fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", inputFax);
            }
            Console.WriteLine("Web site: {0}",inputSiteName);
            Console.Write("Manager:{0} {1} (age:\n {2},tel. {3})",Fname ,Lname ,age ,managerPhone);
        }
    }
}
