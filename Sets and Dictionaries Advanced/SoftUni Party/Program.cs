using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string guest = Console.ReadLine();

            while (guest != "END" && guest != "PARTY")
            {
                if (char.IsDigit(guest[0]))
                {
                    vip.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }
                guest = Console.ReadLine();
            }
            if (guest == "PARTY")
            {
                while (guest != "END")
                {

                    if (char.IsDigit(guest[0]))
                    {
                        vip.Remove(guest);
                    }
                    else
                    {
                        regularGuests.Remove(guest);
                    }
                    guest = Console.ReadLine();
                }
            }
            Console.WriteLine(vip.Count + regularGuests.Count);
            if (vip.Count > 0)
            {
                Console.WriteLine(String.Join("\n", vip));
            }
            if (regularGuests.Count > 0)
            {
                Console.WriteLine(String.Join("\n", regularGuests));
            }

        }
    }
}
