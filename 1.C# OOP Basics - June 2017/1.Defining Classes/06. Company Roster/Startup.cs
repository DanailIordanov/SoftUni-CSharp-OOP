using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var company = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var employeeInfo = Console.ReadLine().Split().ToArray();
            var currentEmployee = new Employee(
                employeeInfo[0],
                decimal.Parse(employeeInfo[1]),
                employeeInfo[2],
                employeeInfo[3]
                );

            if (employeeInfo.Length > 4)
            {
                if (employeeInfo[4].Contains("@"))
                {
                    currentEmployee.Email = employeeInfo[4];
                }
                else
                {
                    currentEmployee.Age = int.Parse(employeeInfo[4]);
                }
            }
            if (employeeInfo.Length > 5)
            {
                currentEmployee.Age = int.Parse(employeeInfo[5]);
            }

            company.Add(currentEmployee);
        }

        var result = company
            .GroupBy(c => c.Department)
            .Select(c => new
            {
                Department = c.Key,
                AverageSalary = c.Average(dep => dep.Salary),
                Employees = c.OrderByDescending(e => e.Salary)
            })
            .OrderByDescending(x => x.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");
        foreach (var employee in result.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
        }

    }
}