using System;

namespace TextExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            foreach (var name in names)
            {
                bool isValid = true;
                if (name.Length > 2 && name.Length < 17)
                {
                    foreach (char ch in name)
                    {
                        if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

        }
    }
}
