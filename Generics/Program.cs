using System;
using System.Collections.Generic;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // bool equal = Calculator.AreEqual<int>(4, 4);
            bool equal = Calculator.AreEqual<string>("A", "A");
            if (equal)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
    public class Calculator
    {
        // Giving generics will make parameters more dynamically acceptable
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}