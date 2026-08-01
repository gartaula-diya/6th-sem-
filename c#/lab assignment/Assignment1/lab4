//Question 4 
using System;
using System.Collections.Generic;

class Stack<T>
{
    private List<T> items = new List<T>();
    public void Push(T item)
    {
        items.Add(item);
    }
    public T Pop()
    {
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public T Peek()
    {
        return items[items.Count - 1];

    }
}
    class Program
    {
        static void Main()
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(20);
        intStack.Push(30);

            Console.WriteLine(intStack.Peek());
            Console.WriteLine(intStack.Pop());

            Stack<string> StringStack = new Stack<string>();
            StringStack.Push("Apple");
            StringStack.Push("Mango");
            StringStack.Push("Orange");

            Console.WriteLine(StringStack.Peek());
            Console.WriteLine(StringStack.Pop());
        }
    }
    
