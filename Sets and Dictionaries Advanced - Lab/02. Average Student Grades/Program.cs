using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var averageGrades = new Dictionary<string, List<decimal>>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentAndGrade = Console.ReadLine().Split();
                string studentName = studentAndGrade[0];
                decimal grade = decimal.Parse(studentAndGrade[1]);

                if (!averageGrades.ContainsKey(studentName))
                {
                    averageGrades[studentName] = new List<decimal>();
                    averageGrades[studentName].Add(grade);
                }

                else
                {
                    averageGrades[studentName].Add(grade);
                }
            }

            foreach (var student in averageGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }

            
        }
    }
}
