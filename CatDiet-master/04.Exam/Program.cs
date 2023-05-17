using System;

namespace _04.Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());
            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            double totalGrade = 0;
            for (int i = 1; i <= student; i++)
            {
                double gradeStudent = double.Parse(Console.ReadLine());

                totalGrade += gradeStudent;

                if (gradeStudent >= 5)
                {
                    count5++;
                }
                else if (gradeStudent >= 4 && gradeStudent <= 4.99)
                {
                    count4++;
                }
                else if (gradeStudent >= 3 && gradeStudent <= 3.99)
                {
                    count3++;
                }
                else if (gradeStudent < 3)
                {
                    count2++;
                }
            }

            double topStudents = (count5 / (student * 1.0)) * 100;
            double between45 = (count4 / (student * 1.0)) * 100;
            double between3 = (count3 / (student * 1.0)) * 100;
            double between2 = (count2 / (student * 1.0)) * 100;
            double sumGrade = totalGrade / student;

            Console.WriteLine($"Top students: {topStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between45:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3:F2}%");
            Console.WriteLine($"Fail: {between2:F2}%");
            Console.WriteLine($"Average: {sumGrade:F2}");
        }
    }
}
 
        
    

