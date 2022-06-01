using System;
using System.Linq;
using System.Collections.Generic;

namespace P10._Ranking
{
    //public class Student
    //{
    //    public Student(string name, int points)
    //    {
    //        this.Name = name;
    //        this.Points = points;
    //    }
    //    public string Name { get; set; }
    //    public int Points { get; set; }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string passwordForContest = cmdArgs[1];
                contests.Add(contest, passwordForContest);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> students = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end of submissions")
            {
                string[] cmdArgs = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!students.ContainsKey(username))
                    {
                       Dictionary<string, int> studentNewContest = new Dictionary<string, int>()
                        {
                            {contest,points }
                        };
                        students[username] = studentNewContest;
                        students[username]=students[username].OrderByDescending(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);

                        input = Console.ReadLine();

                        continue;
                    }
                    if (!students[username].ContainsKey(contest))
                    {
                        Dictionary<string, int> studentNewContest = new Dictionary<string, int>()
                        {
                            {contest,points }
                        };
                        students[username][contest] = points;

                        students[username]=students[username].OrderByDescending(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);//ТУК СЕ ПОДРЕЖДА РЕЧНИКА

                    }
                    else
                    {
                        if (students[username][contest] > points)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            students[username][contest] += points;
                        }
                    }
                }

                input = Console.ReadLine();
            }


            string topStudent = string.Empty;
            int maxValue = int.MinValue;
            foreach (var item in students)
            {
                foreach (var contest in item.Value)
                {
                    if (contest.Value > maxValue)
                    {
                        topStudent = item.Key;
                        maxValue = contest.Value;
                    }
                }
            }
            int sum = students[topStudent].Values.Sum();


            //string topStudent = students.FirstOrDefault(x => x.Value == students.Values.Max()).Key;
            Console.WriteLine($"Best candidate is {topStudent} with total {sum} points.");
            Console.WriteLine("Ranking: ");
            foreach (var item in students)
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
