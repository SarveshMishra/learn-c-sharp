using System;
using System.Collections.Generic;
namespace Dictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating an object from a customer class
            Customer customer1 = new Customer();
            customer1.Name = "Sarvesh";
            customer1.Id = 1;
            // Creating a dictionary which will contain the customer
            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            // adding the customer to the dictionary with key as a customer id
            customerDictionary.Add(customer1.Id, customer1);
            // Iterating through the dictionary with values
            foreach (Customer customer in customerDictionary.Values)
            {
                Console.WriteLine(customer.Name, customer.Id);
            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
    }
}