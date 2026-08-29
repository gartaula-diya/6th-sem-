using System;

//Question 2 
class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area of Shape");
       
    }
   
    }
class Circle : Shape
{
    public override void Area()
    {
        double radius = 5;
        double area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle =" + area);
    }
}
class Rectangle : Shape
{
    public override void Area()
    {
        int length = 6;
        int width = 5;
        Console.WriteLine("Area of Rectangle =" + (length * width));
    }

}

class Program
{
    static void Main()
    {
      
        Shape s;

       s = new Circle();
        s.Area();

        s = new Rectangle();
        s.Area();
    }
}
