using System;

namespace ConsoleIfNestedFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double dblPrice = 0;
            String strType = "", strSize = "";

            //input
            Console.WriteLine("Furniture Types: ");
            Console.WriteLine("P - Pine");
            Console.WriteLine("O - Oak");
            Console.WriteLine("M - Mahogany");
            Console.Write("Enter Furniture Type: ");
            strType = Console.ReadLine();

            Console.Write("Enter Size (S - Small or L - Large)");
            strSize = Console.ReadLine();

            //process
            if (strType.ToLower().StartsWith("p"))
            {
                if(strSize.ToLower().StartsWith("s"))
                {
                    dblPrice = 110;
                }
                else if (strSize.ToLower().StartsWith("l"))
                {
                    dblPrice = 135;
                }
                else
                {
                    Console.WriteLine("Invalid size selection");
                    Console.ReadLine();
                    return;
                }
            }
            else if (strType.ToLower().StartsWith("o"))
            {
                if (strSize.ToLower().StartsWith("s"))
                {
                    dblPrice = 225;
                }
                else if (strSize.ToLower().StartsWith("l"))
                {
                    dblPrice = 260;
                }
                else
                {
                    Console.WriteLine("Invalid size selection");
                    Console.ReadLine();
                    return;
                }
            }
            else if (strType.ToLower().StartsWith("m"))
            {
                if (strSize.ToLower().StartsWith("s"))
                {
                    dblPrice = 240;
                }
                else if (strSize.ToLower().StartsWith("l"))
                {
                    dblPrice = 290;
                }
                else
                {
                    Console.WriteLine("Invalid size selection");
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid type selected");
                Console.ReadLine();
                return;
            }
            //output
            Console.WriteLine("Type: " + strType);
            Console.WriteLine("Size: " + strSize);
            Console.WriteLine("Price: " + dblPrice);
        }
    }
}
