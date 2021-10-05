using System;

namespace Customer_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFirstname;
            string strLastname;
            string strAddress;
            string strPhone;
            string strEmail;

            System.Console.Write("Enter Firstame: ");
            strFirstname = System.Console.ReadLine();

            System.Console.Write("Enter Lastname: ");
            strLastname = System.Console.ReadLine();

            System.Console.Write("Enter Address: ");
            strAddress = System.Console.ReadLine();

            System.Console.Write("Enter Phone: ");
            strPhone = System.Console.ReadLine();
            System.Console.Write("Enter Email:");
            strEmail = System.Console.ReadLine();
            System.Console.WriteLine("Press Return to view customer details");
            System.Console.WriteLine("\n\n   CUSTOMER DETAILS   ");
            System.Console.WriteLine("Firstname:   " + strFirstname);
            System.Console.WriteLine("Lastname :   " + strLastname);
            System.Console.WriteLine("Address  :   " + strAddress);
            System.Console.WriteLine("Phone    :   " + strPhone);
            System.Console.WriteLine("Email    :   " + strEmail);

        }
    }
}
