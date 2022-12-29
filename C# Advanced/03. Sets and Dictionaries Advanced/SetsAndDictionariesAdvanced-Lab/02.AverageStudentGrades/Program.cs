using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int inputGrades = int.Parse(Console.ReadLine());
        var studentsAndGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < inputGrades; i++)
        {
            string[] currInput = Console.ReadLine().Split();
            string studentName = currInput[0];
            double studentGrade = double.Parse(currInput[1]);

            if (!studentsAndGrades.ContainsKey(studentName))
            {
                studentsAndGrades[studentName] = new List<double>();
            }

            studentsAndGrades[studentName].Add(studentGrade);
        }

        // print students and their grades:
        foreach (var student in studentsAndGrades)
        {
            string allGrades = string.Join(" ", student.Value.Select(n => n.ToString("F2")));
            Console.WriteLine($"{student.Key} -> {allGrades} (avg: {student.Value.Average():0.00})");
        }
    }
}