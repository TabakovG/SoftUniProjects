using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList() { "asd", "fijei", "iusdhfi" };
            Console.WriteLine(String.Join(", ", list));
            Console.WriteLine(list.RandomString());
            Console.WriteLine(String.Join(", ", list));


        }
    }
}
