using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program04
    {
        delegate int calculator(int a, int b);

        static int add(int a, int b)
        {
            return a + b;
        }
        static int subtract(int a, int b)
        {
            return a - b;
        }
        static int multiply(int a, int b)
        {
            return a * b;
        }
        static int divide(int a, int b)
        {
            return a / b;
        }
        public static void Main(string[] args)
        {
            calculator obj = new calculator(add);
            Console.WriteLine("Addition: " + obj(10, 5));
            obj = new calculator(subtract);
            Console.WriteLine("Subtraction: " + obj(10, 5));
            obj = new calculator(multiply);
            Console.WriteLine("Multiplication: " + obj(10, 5));
            obj = new calculator(divide);
            Console.WriteLine("Division: " + obj(10, 5));
        }

    }
}
