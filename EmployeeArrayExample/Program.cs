using System;

namespace EmployeeArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            String[] strEName = new string[10];
            String[] strJobTitle = new string[10];

            int ArrayCount = 6;// count varriable to hold position of last element

            for (int intLoopCounter = 0; intLoopCounter < ArrayCount; intLoopCounter++)
            {
                //ArrayCount = ArrayCount + 1;
                Console.Write("");
                Console.Write("Record " + intLoopCounter + "Enter Employee Name");
                strEName[intLoopCounter] = Console.ReadLine();

                Console.Write("Record " + intLoopCounter + "Enter  Job Title");
                strJobTitle[intLoopCounter] = Console.ReadLine();
            }
            //display the information
            for (int intLoopCounter = 0; intLoopCounter < ArrayCount; intLoopCounter++)
            {
                Console.Write("Name: " + strEName[intLoopCounter]);
                Console.Write("Job Title: " + strJobTitle[intLoopCounter]);
            }
       
        }
    }
}
