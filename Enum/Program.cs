using System;
using System.Collections.Generic;
namespace Enum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer { Name = "John", gender = Gender.Male };
            customer[1] = new Customer { Name = "Marry", gender = Gender.Female };
            customer[2] = new Customer { Name = "Unknown Guy", gender = Gender.Unknown };
            foreach (Customer cus in customer)
            {
                System.Console.WriteLine(cus.gender);
            }
        }
    }
    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }
    public class Customer
    {
        public string Name { get; set; }
        public Gender gender { get; set; }
    }
}