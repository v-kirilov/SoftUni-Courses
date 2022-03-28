using System;

namespace _7._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
            //char inputChar = (char)Console.Read();

            //int number = Convert.ToInt32(inputChar);

            //if (number>=65 && number<=90)
            //{
            //    Console.WriteLine("upper-case");
            //}else
            //{
            //    Console.WriteLine("lower-case");
            //}

            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();

            //string full = a + b + c;

            //Console.WriteLine(full);

        }
    }
}
