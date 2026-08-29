//Question 6 
using System;
using System.Collections.Generic;
interface IPayable
{
    void Pay();
}
class Invoice : IPayable
{
    public void Pay()
    {
        Console.WriteLine("Invoice Payment Done");
    }
}
class Salary : IPayable
{
    public void Pay()
    {
        Console.WriteLine("Salaary Paid");
    }
}

class Program
{
    static void Main()
    {
        List<IPayable> list = new List<IPayable>();
        list.Add(new Invoice());
        list.Add(new Salary());

        foreach (IPayable item in list)
        {
            item.Pay();
        }
    }
}
