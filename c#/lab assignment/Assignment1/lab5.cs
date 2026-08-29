//Question 5 
using System;

abstract class Employee
{
    public abstract void CalculateSalary();
}

class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Manager Salary = 70,000");
    }
}

class Clerk : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Clerk Salary = 30,000");
    }
}

class Program
{
    static void Main()
    {
        Employee e;
        e = new Manager();
        e.CalculateSalary();
        e=new Clerk();
        e.CalculateSalary();
    }
}
