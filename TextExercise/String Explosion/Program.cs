using System;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int additionalPower = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    int power = int.Parse(text[i + 1].ToString()) + additionalPower;
                    for (int j = 1; j <= power; j++)
                    {
                        if (i + j < text.Length)
                        {
                            if (text[i + j] != '>')
                            {
                                text = text.Remove(i + j, 1);
                                j--;
                                power--;
                            }
                            else
                            {
                                additionalPower = power;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(text);


        }
    }
}
