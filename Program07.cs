using System;

class Program07
{
    delegate void MyDelegate();

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

    public static void Main(string[] args)
    {
        MyDelegate d = MethodOne;
        d += MethodTwo;
        d += MethodThree;

        Delegate[] methods = d.GetInvocationList();

        Console.WriteLine("Methods stored in delegate:");

        foreach (MyDelegate method in methods)
        {
            Console.WriteLine("Method Name: " + method.Method.Name);

            method();
        }
    }
}