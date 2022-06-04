using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string inputDate1 = Console.ReadLine();
            string inputDate2 = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            int result = dateModifier.GetDifference(inputDate1, inputDate2);
            Console.WriteLine(Math.Abs(result));
        }

    }
}
