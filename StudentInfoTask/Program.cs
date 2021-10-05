using System;

namespace StudentInfoTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String strInput = "";
            String strName = "";
            String strAddress = "";
            int intAge = 0;
            string strSchool = "";
            string strCourse = "";
            int intNumber1 = 0;
            int intNumber2 = 0;
            int intNumber3= 0;


            //Program

            System.Console.Write("Please enter the your name: ");
            strName = System.Console.ReadLine();

            System.Console.Write("Please enter the your address: ");
            strAddress = System.Console.ReadLine();

            System.Console.Write("Please enter the your age: ");
            intAge = Convert.ToInt32(System.Console.ReadLine());
            //Pause before exiting

            System.Console.WriteLine("Please return to continue: ");
            strInput = System.Console.ReadLine();

            System.Console.Write("Please enter the your name: ");
            strName = System.Console.ReadLine();

            System.Console.Write("Please enter the your course: ");
            strCourse = System.Console.ReadLine();

            System.Console.Write("Please enter the your school: ");
            strSchool = System.Console.ReadLine();
            //Pause before exiting
            System.Console.WriteLine("Please return to continue: ");
            strInput = System.Console.ReadLine();


            System.Console.Write("Please enter the first number:"); 
            intNumber1 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Please enter the second number:");
            intNumber2 = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Please enter the third number:");
            intNumber3 = Convert.ToInt32(System.Console.ReadLine());
            
            System.Console.WriteLine(strName + " of " + strAddress + " is " + intAge + " years old.");
            System.Console.WriteLine(strName + " is studying " + strCourse + " at " + strSchool + ".");
            System.Console.WriteLine("The numbers are " + intNumber1 + ", " + intNumber2 + " and " + intNumber3);
            //Pause before exiting
            System.Console.WriteLine("Please return to exit: ");
            strInput = System.Console.ReadLine();

        }
    }
}
