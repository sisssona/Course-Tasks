using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double packageOfFlourPrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApronPrice = double.Parse(Console.ReadLine());
            double freePackages = 0;
            double numberOfFlourPackages = students * 1;

            if (numberOfFlourPackages >= 5)
            {
                freePackages = students / 5;
            }

            double studentSet = singleApronPrice * Math.Ceiling(students * 1.2) + singleEggPrice * 10 * (students) +
                packageOfFlourPrice * (students - freePackages);

            if (studentSet <= budget)
            {
                Console.WriteLine($"Items purchased for {studentSet:f2}$.");
            }
           else if (studentSet > budget)
            {
                double neededMoney = studentSet - budget;
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
        }
    }
}
