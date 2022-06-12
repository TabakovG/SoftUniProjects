using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            /*string[] personAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var strTuple = new Tuple<string, string>(
                personAddress[0] + " " + personAddress[1],
                personAddress[2]);
            Console.WriteLine(strTuple);

            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var strIntTuple = new Tuple<string, int>(
                input2[0], int.Parse(input2[1]));
            Console.WriteLine(strIntTuple);

            string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var intDoubleTuple = new Tuple<int, double>(
                int.Parse(input3[0]), double.Parse(input3[1]));
            Console.WriteLine(intDoubleTuple);*/

            List<string> personAddress = 
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var personName = personAddress[0] + " " + personAddress[1];
            var address = personAddress[2];
            personAddress.RemoveAt(0);
            personAddress.RemoveAt(0);
            personAddress.RemoveAt(0);
            var town = string.Join(" ", personAddress);
            var strThreeuple = new Threeuple<string, string, string>(
                personName,
                address,
                town);
            Console.WriteLine(strThreeuple);

            string[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var strIntThreeuple = new Threeuple<string, int, bool>(
                input2[0], 
                int.Parse(input2[1]),
                input2[2] == "drunk" ? true: false);
            Console.WriteLine(strIntThreeuple);

            string[] input3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var strDoubleThreeuple = new Threeuple<string, double, string>(
                input3[0],
                double.Parse(input3[1]),
                input3[2]);
            Console.WriteLine(strDoubleThreeuple);
        }
    }
}
