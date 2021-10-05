using System;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int myInt = 0;
            int Limit = 45;
            while (myInt <= Limit)//condition
            {
                //code 2 execute
                Console.WriteLine(" " + myInt);
                myInt++;
            }
            Console.WriteLine("Limit reached");
        }
    }
}
