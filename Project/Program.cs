using System;
using System.Collections.Generic;
using Project.BL;
namespace Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            Logic test = new Logic();
            Console.WriteLine(test.Hello("Sarvesh"));
            Customer customer = new Customer("Sarvesh", "Mishra");
            Console.WriteLine(customer.CustomerFullName());
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Sarvesh";
            FTE.lastName = "Mishra";
            FTE.email = "sarvesh.m@carwale.com";
            FTE.yearlySalary = 15000000000;
            FTE.PrintFullName(); // Print children method by hiding parent method.
            // ((Employee).FTE.PrintFullName()); // Print full name from parent method because it is type casting with parent method
        }
    }
}