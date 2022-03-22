using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    public class Song 
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }


    }
    class Program
    {
        private static int s;

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < num; i++)
            {
                List<string> songInfo = Console.ReadLine()
                                        .Split("_", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
                string sType = songInfo[0];
                string sName = songInfo[1];
                string sTime = songInfo[2];

                playlist.Add(new Song(sType, sName, sTime));
            }

            string filter = Console.ReadLine();

            if (filter == "all")
            {
                foreach (var item in playlist)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in playlist)
                {
                    if (item.TypeList == filter)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}
