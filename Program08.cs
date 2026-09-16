using System;

namespace ASSIGNMENT_04
{
    class Program08
    {
        static void MethodOne()
        {
            Console.WriteLine("Method One executed");
        }
        static void MethodTwo()
        {
            Console.WriteLine("Method Two executed");
        }
        static void MethodThree()
        {
            Console.WriteLine("Method Three executed");
        }
        static void Main(string[] args)
        {
            Action obj = MethodOne;

            Console.WriteLine("Unicast Action:");
            obj();

            Action obj2 = MethodOne;
            obj2 += MethodTwo;
            obj2 += MethodThree;

            Console.WriteLine("\nMulticast Action:");
            obj2();
        }

    }
}
