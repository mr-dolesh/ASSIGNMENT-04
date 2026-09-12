using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASSIGNMENT_04
{
    internal class Program
    {
        delegate void mydelegate(string message);
        static void display(string message)
        {
            Console.WriteLine(message);
        }
        static void Run(string[] args)
        {
            mydelegate obj = new mydelegate(display);
            obj("Hello! This is delegate.");
        }
    }
}
