using System;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {

                input[i] = (char)((int)input[i] + 3);
            }
            Console.WriteLine(String.Join("", input));
        }
    }
}
