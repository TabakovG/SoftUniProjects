using System;
using System.Collections.Generic;

internal class UniqueUsernames
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        int num = int.Parse(Console.ReadLine());


        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            set.Add(input);
        }
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}

