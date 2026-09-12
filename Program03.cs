using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program03
    {
        delegate void types();

        static void Method1()
        {
            Console.WriteLine("This is Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("This is Method 2");
        }
        public static void Main() {
            types obj = Method1;
            Console.WriteLine("This is unicast delegate");
            obj();

            types onj = Method1;
            onj += Method2; // onj = onj(Method1) + method2;
            Console.WriteLine("This is Multicast delegate");
            onj();
        }
    }
}
