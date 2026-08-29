//Question 10 

using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFile(string fileName)
    {
        Console.WriteLine("Downloading " + fileName);

        await Task.Delay(3000);
        Console.WriteLine(fileName + "Downlaoding Complete");
    }
    static async Task Main()
    {
        Task file1 = DownloadFile("File1");
        Task file2 = DownloadFile("File2");

        await Task.WhenAll(file1, file2);

        Console.WriteLine("Both files downloaded successfully");
    }
}
