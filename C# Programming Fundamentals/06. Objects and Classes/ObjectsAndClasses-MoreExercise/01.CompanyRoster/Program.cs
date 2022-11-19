using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> allEmployees = new List<Employee>();

            // input employees:
            for (int i = 0; i < countOfEmployees; i++)
            {
                string[] inputEmployee = Console.ReadLine().Split();
                string name = inputEmployee[0];
                double salary = double.Parse(inputEmployee[1]);
                string department = inputEmployee[2];

                Employee currEmployee = new Employee(name, salary, department);
                allEmployees.Add(currEmployee);
            }

            allEmployees = allEmployees.OrderBy(x => x.Department).ToList();

            // find Department with highest average salary:
            double highestAverageSalary = 0;
            string bestDepartment = string.Empty;

            for (int i = 0; i < countOfEmployees - 1; i++)
            {
                double sumSalary = allEmployees[i].Salary;
                int employeesCount = 1;

                while ((i < countOfEmployees - 1) && (allEmployees[i].Department == allEmployees[i + 1].Department))
                {
                    employeesCount++;
                    sumSalary += allEmployees[i + 1].Salary;
                    i++;
                }

                double averageSalary = sumSalary / employeesCount;

                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    bestDepartment = allEmployees[i].Department;
                }
            }

            List<Employee> bestDepartmentEmployees = allEmployees
                .Where(d => d.Department == bestDepartment)
                .OrderByDescending(s => s.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (Employee employee in bestDepartmentEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
