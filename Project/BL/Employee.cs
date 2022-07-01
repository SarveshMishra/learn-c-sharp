using System;
using System.Collections.Generic;
namespace Project.BL
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
        // with new keyword you can hide parent class methods and use
        // children methods.
        public new void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} with{yearlySalary}");
        }
    }
    public class PartTimeEmoployee : Employee
    {
        public float hourlySalary;
    }
}