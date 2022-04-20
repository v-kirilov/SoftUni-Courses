using System;

namespace P03.__Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split('\\');
            //string[] lastWord=input[input.Length-1].Split('.');
            //Console.WriteLine($"File name: {lastWord[0]}");
            //Console.WriteLine($"File extension: {lastWord[1]}");

            string fullPath = Console.ReadLine();
            int indexOfLastSlash = fullPath.LastIndexOf('\\');

            string nameAndIndex = fullPath.Substring(indexOfLastSlash+1);
            int indexOfDot = nameAndIndex.LastIndexOf('.');

            string extension = nameAndIndex.Substring(indexOfDot+1);
            string fileName = nameAndIndex.Remove(indexOfDot);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
