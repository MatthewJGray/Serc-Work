using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String strSubject = "", strGrade = "", strStudentNo = "", strStudentForename = "", strStudentSurname = "";
            int StudentAssignmentResult = 0, ExamMark = 0;
            double StudentAverageMarks = 0;

            //Inputs
            Console.WriteLine("Please Enter your student number");
            strStudentNo = Console.ReadLine();
            Console.WriteLine("Please Enter your student first name");
            strStudentForename = Console.ReadLine();
            Console.WriteLine("Please Enter your student last name");
            strStudentSurname = Console.ReadLine();
            Console.WriteLine("Please Enter your assignment result");
            StudentAssignmentResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter exam mark");
            ExamMark = Convert.ToInt32(Console.ReadLine());

            //Process
            if (ExamMark >= 75)
            {
                strGrade = "Distinction";
            }
            if (ExamMark >= 60)
            {
                strGrade = "Merit";
            }
            if (ExamMark >= 40)
            {
                strGrade = "Pass";
            }
            else
            {
                strGrade = "Fail";
            }
            //output
            Console.WriteLine("Your exam grade is " + strGrade + "");

            //Arrays
            //String[] strStudentFullName= new string[10];
            //int[] StudentResult = new int[10];
            //int[];

        }
    }
}
