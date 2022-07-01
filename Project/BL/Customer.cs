using System;
using System.Collections.Generic;
namespace Project.BL
{
    public class Customer
    {
        private string? firstName { get; set; }
        private string? lastName { get; set; }
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string CustomerFullName()
        {
            return $"Full Name is {this.firstName} {this.lastName}";
        }
    }
}