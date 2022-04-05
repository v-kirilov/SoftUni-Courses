using System;

namespace P02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            Console.WriteLine(VowelsCount(input));
        }

        static int VowelsCount(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char vowel = input[i];
                
                if (vowel =='a'||vowel == 'e' || vowel == 'o' || vowel == 'u' || vowel == 'i')
                {
                    count++;
                }


            }
            return count;
        }
    }
}
