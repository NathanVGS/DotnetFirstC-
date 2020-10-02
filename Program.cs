using System;
using System.IO;

namespace Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create file with name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Write content to the file: ");
            string content = Console.ReadLine();
            File.WriteAllText("files/" + fileName, content);
            string input = Console.ReadLine();
            
            string outputFile = File.ReadAllText(input);
            Console.WriteLine(outputFile);
        } 
    }
}
