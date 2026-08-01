//Question 9 
using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            StreamWriter writer = new StreamWriter("input.txt");
            writer.WriteLine("hello");
            writer.WriteLine("welcome");
            writer.Close();

            StreamReader reader = new StreamReader("input.txt");
            StreamWriter output = new StreamWriter("output.txt");

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                output.WriteLine(line.ToUpper());
            }

            reader.Close();
            output.Close();
            Console.WriteLine("File Processed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program Finsihed.");
        }
    }
}
