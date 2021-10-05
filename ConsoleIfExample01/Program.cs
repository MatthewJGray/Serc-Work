using System;

namespace ConsoleIfExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables


            int intNumber1 = 0;
            const int intSpecifiedValue = 12;
            String strOutput = "";

            //input
            Console.Write("Enter Input (Number) : ");
            intNumber1 = Convert.ToInt32(Console.ReadLine());

            //process
            if (intNumber1 > intSpecifiedValue)
            {
                strOutput = "Number is greater than specified number";
            }
            //output
            Console.WriteLine(strOutput);
        }
    }
}
