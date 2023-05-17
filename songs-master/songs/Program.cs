using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Songs
{

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            
            for (int i = 0; i <= numberOfSongs; i++)
            {
                string[] inputData = Console.ReadLine().Split("_");

                string type = inputData[0];
                string name = inputData[1];
                string time = inputData[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                
            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
                foreach ( Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            List<Song> filteredSongs = songs
                .Where(s => s.TypeList == typeList)
                .ToList();
            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }
        }       
    }
}
