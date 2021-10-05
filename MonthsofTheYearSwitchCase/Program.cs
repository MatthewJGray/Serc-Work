using System;

namespace MonthsofTheYearSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            String strPause = "", strMonth = "";
            int intDays = 0;

            //Input
            Console.WriteLine("Please Enter A Month (i.e Jan)");
            strMonth = Console.ReadLine();

            //process
            switch (strMonth)
            {
                case "Feb":
                    intDays = 28;
                    break;
                case "Fep":
                case "Apr":
                case "Jun":
                case "Nov":
                    intDays = 30;
                    break;
                case "Jan":
                case "Mar":
                case "July":
                case "Aug":
                case "Oct":
                case "dec":
                    intDays = 31;
                    break;
            }
            //Output
            Console.WriteLine(strMonth + " has " + intDays + " days!");

            //Pause
            strPause = Console.ReadLine();
        }
    }
}
