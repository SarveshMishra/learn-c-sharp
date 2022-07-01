using System;
using System.Collections.Generic;
namespace Project.BL
{
    public class Customer
    {
        // Properties
        private string? firstName { get; set; }
        private string? lastName { get; set; }
        // Constructor shortcut ctor
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        // Method
        public string CustomerFullName()
        {
            return $"Full Name is {this.firstName} {this.lastName}";
        }
        //DeStructor for clean up operation and automatically called
        // by the c#
        ~Customer()
        {
            // Do some clean up operation.
        }
    }
}