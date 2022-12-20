using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] songs = Console.ReadLine().Split(", ");
        Queue<string> queueSongs = new Queue<string>(songs);

        while (queueSongs.Count > 0)
        {
            string command = Console.ReadLine();

            if (command == "Play")
            {
                queueSongs.Dequeue();
            }
            else if (command == "Show")
            {
                Console.WriteLine(string.Join(", ", queueSongs));
            }
            else
            {
                string songName = command.Substring(4);

                if (queueSongs.Contains(songName))
                {
                    Console.WriteLine($"{songName} is already contained!");
                }
                else
                {
                    queueSongs.Enqueue(songName);
                }
            }
        }

        Console.WriteLine("No more songs!");
    }
}