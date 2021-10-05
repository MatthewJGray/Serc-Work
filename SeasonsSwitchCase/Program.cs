using System;

namespace SeasonsSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string strMonth = "";

            //input
            Console.Write("Enter Month: ");
            strMonth = Console.ReadLine();
            //switch case
            switch (strMonth)
            {
                //winter
                case "December":
                case "Janunary":
                case "Febuary":
                    Console.WriteLine("Winter");
                    break;
                //spring
                case "March":
                case "April":
                case "May":
                    Console.WriteLine("Spring");
                    break;
                //Summer
                case "June":
                case "July":
                case "August":
                    Console.WriteLine("Summer");
                    break;
                //Autumn
                case "September":
                case "October":
                case "November":
                    Console.WriteLine("Autumn");
                    break;
            }
            Console.ReadLine();
        }
    }
}
