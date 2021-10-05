using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String strInput = "";
            int intNumber1 = 0;
            int intNumber2 = 0;
            int intResult = 0;

            //Program
            System.Console.Write("Please enter the first number a number:");
            intNumber1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Please enter the second number a number:");
            intNumber2 = Convert.ToInt32(System.Console.ReadLine());

            intResult = intNumber1 + intNumber2; //Calc result


            System.Console.WriteLine("The sum of " + intNumber1 + " and " + intNumber2 + " is " + intResult);

            //Pause before exiting
            System.Console.WriteLine("Please return to exit: ");
            strInput = System.Console.ReadLine();
        }
    }
}
