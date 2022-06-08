using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace Problem_2___Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(::|\*\*)(?<word>[A-Z][a-z]{2,})\1");
            string input = Console.ReadLine();
            BigInteger coolnes = 1;
            List<string> coolEmojis = new List<string>();

            foreach (var currCh in input)
            {
                if (char.IsDigit(currCh))
                {
                    coolnes *= int.Parse(currCh.ToString());
                }
            }
            MatchCollection matches = pattern.Matches(input);

            foreach (Match word in matches)
            {
                int emojiSum = 0;
                string emoji = word.Groups["word"].Value;
                foreach (var currCh in emoji)
                {
                    emojiSum += (int)currCh;
                }
                if (emojiSum > coolnes)
                {
                    coolEmojis.Add(word.Value);
                }

            }

            Console.WriteLine($"Cool threshold: {coolnes}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
