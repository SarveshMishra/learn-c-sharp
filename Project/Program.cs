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
        }
    }
}