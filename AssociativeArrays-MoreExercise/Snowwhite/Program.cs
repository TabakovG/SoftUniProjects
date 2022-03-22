using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {

                string[] cmd = command.Split(" <:> ");

                AddUpdateDwarf(dwarfs, cmd);

                command = Console.ReadLine();
            }

            var list = new List<KeyValuePair<string, KeyValuePair<string, int>>>();

            foreach (var dwarf in dwarfs)
            {
                foreach (var item in dwarf.Value)
                {
                    list.Add(new KeyValuePair<string, KeyValuePair<string, int>>(dwarf.Key, new KeyValuePair<string, int>(item.Key, item.Value)));
                }
            }

            foreach (var dw in list
                    .OrderByDescending(x => x.Value.Value)
                    .ThenByDescending(x => list.Where(y => y.Key == x.Key).Count()))
            {
                Console.WriteLine($"({dw.Key}) {dw.Value.Key} <-> {dw.Value.Value}");
            }
        }

        private static void AddUpdateDwarf(Dictionary<string, Dictionary<string, int>> dwarfs, string[] cmd)
        {
            string dwarfName = cmd[0];
            string dwarfHat = cmd[1];
            int dwarfPhis = int.Parse(cmd[2]);

            if (!dwarfs.ContainsKey(dwarfHat))
            {
                dwarfs[dwarfHat] = new Dictionary<string, int>();
            }
            if (!dwarfs[dwarfHat].ContainsKey(dwarfName))
            {
                dwarfs[dwarfHat][dwarfName] = 0;
            }
            if (dwarfs[dwarfHat][dwarfName] < dwarfPhis)
            {
                dwarfs[dwarfHat][dwarfName] = dwarfPhis;
            }

        }

    }
}
