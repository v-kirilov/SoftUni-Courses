using System;
using System.Collections.Generic;
using System.Linq;

namespace P10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessonsList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] changesArray = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = changesArray[0];
                switch (action)
                {
                    case "Add":
                        string newLesson = changesArray[1];
                        if (lessonsList.Contains(newLesson) == false)
                        {
                            lessonsList.Add(newLesson);
                        }
                        break;
                    case "Insert":
                        newLesson = changesArray[1];
                        int index = int.Parse(changesArray[2]);

                        if (lessonsList.Contains(newLesson) == false)
                        {
                            lessonsList.Insert(index, newLesson);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Remove":
                        newLesson = changesArray[1];

                        if (lessonsList.Contains(newLesson) == true)
                        {

                            int indexRemove = lessonsList.IndexOf(newLesson);
                            bool isNextExercise = IsNextExercise(lessonsList, newLesson);
                            if (isNextExercise == true)
                            {
                                lessonsList.RemoveAt(indexRemove);
                                lessonsList.RemoveAt(indexRemove);
                            }
                            else
                            {
                                lessonsList.Remove(newLesson);
                            }
                        }
                        break;
                    case "Swap":
                        string swapLessonOne = changesArray[1];
                        string swapLessonTwo = changesArray[2];

                        if (lessonsList.Contains(swapLessonOne) == true && lessonsList.Contains(swapLessonTwo) == true)
                        {
                            int indexOne = lessonsList.IndexOf(swapLessonOne);
                            int indexTwo = lessonsList.IndexOf(swapLessonTwo);

                            bool isLessOne = IsNextExercise(lessonsList, swapLessonOne);
                            bool isLessTwo = IsNextExercise(lessonsList, swapLessonTwo);

                            if (isLessOne == false && isLessTwo == false)
                            {
                                lessonsList[indexOne] = swapLessonTwo;
                                lessonsList[indexTwo] = swapLessonOne;
                            }
                            else if (isLessOne == true && isLessTwo == false)
                            {
                                string temp = swapLessonTwo;

                                lessonsList[indexTwo] = swapLessonOne;
                                string tempEx = lessonsList[indexOne + 1];
                                lessonsList.Insert(indexTwo + 1, tempEx);
                                lessonsList.RemoveAt(indexOne);
                                lessonsList[indexOne] = temp;
                            }
                            else if (isLessOne == false && isLessTwo == true)
                            {
                                string temp = swapLessonOne;  //take lab

                                lessonsList[indexOne] = swapLessonTwo;  //firstLab = second Lab
                                string tempEx = lessonsList[indexTwo + 1]; //take second Exercise
                                lessonsList.Insert(indexOne + 1, tempEx);  //Insert second Exercise
                                lessonsList.RemoveAt(indexTwo + 1);       //remove secondLab
                                lessonsList[indexTwo + 1] = temp;             //swap the remaining
                            }
                            else if (isLessOne == true && isLessTwo == true)
                            {
                                string exerOne = lessonsList[indexOne + 1];
                                string exerTwo = lessonsList[indexTwo + 1];
                                string tempFirst = lessonsList[indexTwo];
                                string tempSecond = lessonsList[indexTwo+1];

                                lessonsList[indexTwo] = swapLessonOne;
                                lessonsList[indexTwo+1] = swapLessonTwo;

                                lessonsList[indexOne] = tempFirst;
                                lessonsList[indexOne+1] = tempSecond;

                            }

                        }
                        break;
                    case "Exercise":
                        string exercise = changesArray[1];
                        string additionalLesson = exercise;
                        exercise += "-Exercise";

                        if (lessonsList.Contains(additionalLesson) == true)
                        {
                            int indexOfLesson = lessonsList.IndexOf(additionalLesson);
                            lessonsList.Insert(indexOfLesson + 1, exercise);
                        }
                        else
                        {
                            lessonsList.Add(additionalLesson);
                            lessonsList.Add(exercise);
                        }

                        break;

                }

            }

            for (int i = 1; i <= lessonsList.Count; i++)
            {
                Console.WriteLine($"{i}.{lessonsList[i - 1]}");
            }
        }

        static bool IsNextExercise(List<string> input, string lesson)
        {
            bool isNextEx = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (lesson == input[i] && i < input.Count - 1)
                {
                    string[] checkNext = input[i + 1].Split("-").ToArray();
                    if (checkNext.Length > 1)
                    {
                        isNextEx = true;

                    }
                }

            }

            return isNextEx;
        }
    }
}
