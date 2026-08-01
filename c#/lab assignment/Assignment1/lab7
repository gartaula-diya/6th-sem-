//Question 7
using System;
class Temperature
{
    public delegate void Temperaturehandler();
    public event Temperaturehandler HighTemperature;
    public void CheckTemperature(int temp)
    {
        Console.WriteLine("Temperature= " + temp);
        if (temp > 40)
        {
            HighTemperature?.Invoke();
        }
    }

}
class Program
{
    static void Warning()
    {
        Console.WriteLine("Warning high Temperature");
    }

    static void Main()
    {
        Temperature t = new Temperature();
        t.HighTemperature += Warning;

        t.CheckTemperature(35);
        t.CheckTemperature(45);
        t.CheckTemperature(15);
    
    }
}
