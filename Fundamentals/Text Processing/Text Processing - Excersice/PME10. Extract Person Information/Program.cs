using System;

namespace PME10._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string example = Console.ReadLine();
                int nameStart = example.IndexOf('@');
                int nameEnd = example.IndexOf('|');
                string name = example.Substring(nameStart+1, nameEnd - nameStart-1);


                int ageStart = example.IndexOf('#');
                int ageEnd = example.IndexOf('*');
                string age = example.Substring(ageStart+1, ageEnd - ageStart-1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
