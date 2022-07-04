using System;
using System.Collections.Generic;
namespace Delegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1, EmployeeName = "Sarvesh", Experience = 2 });
            employees.Add(new Employee() { ID = 2, EmployeeName = "John", Experience = 1 });
            // Passing delegate as a lamda expression.
            Employee.PromoteEmployee(employees, emp => emp.Experience > 1);
        }
    }
    // Delegate to use as lamda function
    delegate bool IsPromatable(Employee employee);
    class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employees, IsPromatable isPromatable)
        {
            foreach (Employee employee in employees)
            {
                if (isPromatable(employee))
                {
                    System.Console.WriteLine("Promoting employee " + employee.EmployeeName);
                }
            }
        }
    }
}