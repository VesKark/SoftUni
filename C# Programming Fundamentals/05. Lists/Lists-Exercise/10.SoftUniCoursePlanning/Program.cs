using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string[] separator = new string[] { ", " };
			List<string> scheduele = s.Split(separator, StringSplitOptions.None).ToList();
			string command = Console.ReadLine();

			while (command != "course start")
			{
				string[] currentCommand = command.Split(':');
				string action = currentCommand[0];
				string lesson = currentCommand[1];
				string exercise = lesson + "-Exercise";

				if (action == "Add" && !scheduele.Contains(lesson))
				{
					scheduele.Add(lesson);
				}
				else if (action == "Insert" && !scheduele.Contains(lesson))
				{
					int index = int.Parse(currentCommand[2]);
					scheduele.Insert(index, lesson);
				}
				else if (action == "Remove" && scheduele.Contains(lesson))
				{
					scheduele.Remove(lesson);
					RemoveExercise(scheduele, exercise); //method
				}
				else if (action == "Swap")
				{
					string otherLesson = currentCommand[2];
					string otherExercise = otherLesson + "-Exercise";

					if (scheduele.Contains(lesson) && scheduele.Contains(otherLesson))
					{
						int indexLesson = FindIndex(scheduele, lesson); //method for Index
						int indexOtherLesson = FindIndex(scheduele, otherLesson); //method for Index
						SwapPositions(scheduele, lesson, indexLesson, indexOtherLesson);

						if (scheduele.Contains(exercise))
						{
							int indexExercise = FindIndex(scheduele, exercise); //method for Index
							scheduele.RemoveAt(indexExercise);
							scheduele.Insert(indexOtherLesson + 1, exercise);
						}

						if (scheduele.Contains(otherExercise))
						{
							int indexOtherExercise = FindIndex(scheduele, otherExercise); //method for Index
							scheduele.RemoveAt(indexOtherExercise);
							scheduele.Insert(indexLesson + 1, otherExercise);
						}
					}
				}
				else if (action == "Exercise")
				{
					if (!scheduele.Contains(lesson))
					{
						scheduele.Add(lesson);
						scheduele.Add(exercise);
					}
					else if (scheduele.Contains(lesson) && !scheduele.Contains(exercise))
					{
						int index = FindIndex(scheduele, lesson); //method for Index
						scheduele.Insert(index + 1, exercise);
					}
				}

				command = Console.ReadLine();
			}

			// Output:
			for (int i = 1; i <= scheduele.Count; i++)
			{
				Console.WriteLine("{0}.{1}", i, scheduele[i - 1]);
			}
		}

		static void RemoveExercise(List<string> scheduele, string exercise)
		{
			if (scheduele.Contains(exercise))
			{
				scheduele.Remove(exercise);
			}
		}

		static int FindIndex(List<string> scheduele, string course)
		{
			return scheduele.FindIndex(a => a == course); ;
		}

		static void SwapPositions(List<string> scheduele, string lesson, int firstIndex, int secondIndex)
		{
			string temp = lesson;
			scheduele[firstIndex] = scheduele[secondIndex];
			scheduele[secondIndex] = temp;
		}
	}
}
