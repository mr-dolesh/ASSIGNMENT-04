using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program10
    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsPositive(int number)
        {
            return number > 0;
        }
        static bool IsGreaterThan100(int number)
        {
            return number > 100;
        }
        static void Main(string[] args)
        {
            int number = 150;
            Predicate<int> check = IsEven;

            check += IsPositive;
            check += IsGreaterThan100;

            Delegate[] methods = check.GetInvocationList();
            Console.WriteLine("Checking number: " + number);
            Console.WriteLine();

            foreach(Delegate method in methods)
            {
                bool result = (bool)method.DynamicInvoke(number);
                Console.WriteLine("Method Name: " + method.Method.Name + ", Result: " + result);
            }
        }
    }
}
