using System;

namespace LabArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());
            if (input > 0 && input < 8)
            {
                Console.WriteLine(days[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
