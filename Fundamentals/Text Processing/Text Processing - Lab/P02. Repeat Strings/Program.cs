using System;
using System.Text;

namespace P02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            StringBuilder str = new StringBuilder();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    str.Append(item);
                }
            }
            Console.WriteLine(str);

        }
    }
}
