using System;

namespace ASSIGNMENT_04
{
    internal class Program09
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> operation = Add;

            Console.WriteLine("Unicast Func:");
            int result = operation(10, 5);
            Console.WriteLine("Add: " + result);

            Func<int, int, int> operation2 = Add;

            operation2 += Subtract;
            operation2 += Multiply;

            Console.WriteLine("\nMulticast Func:");

            Delegate[] methods = operation2.GetInvocationList();
            foreach (Delegate method in methods)
            {
                int returnValue = (int)method.DynamicInvoke(10, 5);
                Console.WriteLine("Method Name: "+ method.Method.Name + ", Return Value: " + returnValue);
            }
        }
    }
}
