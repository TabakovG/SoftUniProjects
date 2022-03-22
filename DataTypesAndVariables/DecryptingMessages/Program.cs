using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nLines = int.Parse(Console.ReadLine());
            string decriptedM = "";

            for (int i = 0; i < nLines; i++)
            {
                char input = char.Parse(Console.ReadLine());
                decriptedM += ((char)(input + key)).ToString();

            }
            Console.WriteLine(decriptedM);

        }
    }
}
