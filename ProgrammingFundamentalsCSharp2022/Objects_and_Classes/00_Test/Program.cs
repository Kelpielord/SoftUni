using System;
using System.Collections.Generic;

namespace _00_Test
{
    internal class Program
    {
        class Song
        {
            public string TypeList { get; set; }

            public string SongName { get; set; }

            public string SongTime { get; set; }
        }
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = tokens[0];
                string songName = tokens[1];
                string songTime = tokens[2];

                Song newSong = new Song()
                {
                    SongName = songName,
                    TypeList = typeList,
                    SongTime = songTime
                };
                songs.Add(newSong);
            }

            string songTypeListCommand = Console.ReadLine();
            if (songTypeListCommand == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.SongName);
                }
            }
            else
            {
                List<Song> orderedSongs = songs.FindAll(song => song.TypeList == songTypeListCommand);
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.SongName);
                }
            }
        }
    }
}
