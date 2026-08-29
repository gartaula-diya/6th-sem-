//Question 8 
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            5,12,18,7,24,10,30,15
        };
        var result = numbers
            .Where(x => x % 2 == 0 && x > 10)
            .OrderByDescending(x => x);
        Console.WriteLine("Filtered Numbers:");
        foreach (int n in result)
        {
            Console.WriteLine(n);   
        }
    }
}

