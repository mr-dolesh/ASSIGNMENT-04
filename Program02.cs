using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program02
    {
        delegate int Sum(int a, int b);
        static int add(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public static void Main(string[] args)
        {
            Sum obj = new Sum(add);
            obj(10, 20);
        }
    }
}
