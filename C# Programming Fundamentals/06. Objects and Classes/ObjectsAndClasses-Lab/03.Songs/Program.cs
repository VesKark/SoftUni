using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List <Song> allSongs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] inputSong = Console.ReadLine().Split('_');

                Song currSong = new Song(inputSong[0], inputSong[1], inputSong[2]);
                allSongs.Add(currSong);
            }

            string sortByType = Console.ReadLine();

            foreach (Song song in allSongs)
            {
                if (sortByType == "all")
                {
                    Console.WriteLine(song.SongName);
                }
                else if (song.Playlist == sortByType)
                {
                    Console.WriteLine(song.SongName);
                }
            }
        }
    }

    class Song
    { 
        public string Playlist { get; set; }
        public string SongName { get; set; }
        public string SongTime { get; set; }
        public Song(string playlist, string name, string time)
        {
            Playlist = playlist;
            SongName = name;
            SongTime = time;
        }
    }
}
