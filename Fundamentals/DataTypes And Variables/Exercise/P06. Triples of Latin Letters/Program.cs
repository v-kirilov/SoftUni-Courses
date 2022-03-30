using System;

namespace P6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int first = 97;

            for (int i = 0; i < input; i++)
            {
                int second = 97;


                for (int j = 0; j < input; j++)
                {
                    int third = 97;

                    for (int k = 0; k < input; k++)
                    {
                        Console.WriteLine($"{(char)(first)}{(char)(second)}{(char)(third)}");
                        third++;
                    }
                    second++;
                }
                first++;
            }
        }
    }
}
