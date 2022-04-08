using System;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double newGrade = double.Parse(Console.ReadLine());
            string gradeIs = GradeType(newGrade);

            Console.WriteLine(gradeIs);

        }

        static string GradeType(double grade)
        {
            string corGrade;

            if (grade>=2 && grade<=2.99 )
            {
                corGrade = "Fail";
            }
            else if (grade >=3 && grade <=3.49)
            {
                corGrade = "Poor";
            }
            else if (grade >= 3.5 && grade <= 4.49)
            {
                corGrade = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                corGrade = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6)
            {
                corGrade = "Excellent";
            }else
            {
                corGrade = "Invalid grade";

            }
            return $"{corGrade}";

        }
    }
}
