using System;

class Program
{
    delegate double SalaryDelegate(double basicSalary);

    static double BasicSalary(double basicSalary)
    {
        return basicSalary;
    }

    static double HRA(double basicSalary)
    {
        return basicSalary * 0.20;
    }

    static double DA(double basicSalary)
    {
        return basicSalary * 0.10;
    }

    static double Bonus(double basicSalary)
    {
        return basicSalary * 0.15;
    }

    static void Main()
    {
        double basicSalary = 30000;

        SalaryDelegate salary = BasicSalary;
        salary += HRA;
        salary += DA;
        salary += Bonus;

        Console.WriteLine("Salary Components:");

        Delegate[] methods = salary.GetInvocationList();

        double totalSalary = 0;

        foreach (SalaryDelegate method in methods)
        {
            double result = method(basicSalary);

            Console.WriteLine(method.Method.Name + " = " + result);

            totalSalary += result;
        }

        Console.WriteLine("\nTotal Salary = " + totalSalary);
    }
}