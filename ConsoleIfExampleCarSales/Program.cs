using System;

namespace ConsoleIfExampleCarSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double dblCommissionRate = 0, dblcommissionValue = 0;
            int intValueofCarSales = 0;

            //input
            Console.Write("Enter the value of the car: ");
            intValueofCarSales = Convert.ToInt32(Console.ReadLine());
            //Process
            if (intValueofCarSales < 10000)
            {
                dblCommissionRate = 1.5;
            }
            else if (intValueofCarSales <= 20000)
            {
                dblCommissionRate = 2.5;
            }
            else if (intValueofCarSales <= 40000)
                dblCommissionRate = 5;
            else
            {
                dblCommissionRate = 7.5;            
            }
            //calculate commission value
            dblcommissionValue = dblCommissionRate / 100 * intValueofCarSales;

            //output
            Console.WriteLine("Commission Rate: " + dblCommissionRate);
            Console.WriteLine("Commission Value: " + dblcommissionValue);

        }
    }
}
