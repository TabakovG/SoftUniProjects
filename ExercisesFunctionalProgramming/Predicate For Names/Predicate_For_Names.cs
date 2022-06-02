using System;
using System.Linq;

namespace Predicate_For_Names
{
    internal class Predicate_For_Names
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            Predicate<string> lengthCondition = x => x.Length <= num;
            

            Console.WriteLine(string.Join(Environment.NewLine, Array.FindAll(names, lengthCondition)));

        }
    }
}
