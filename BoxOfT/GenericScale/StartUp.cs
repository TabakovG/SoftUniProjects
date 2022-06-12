using System;

namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            var elements = new EqualityScale<int>(2,4);

            Console.WriteLine( elements.AreEqual());

            var elements2 = new EqualityScale<int>(4, 4);

            Console.WriteLine(elements2.AreEqual());
        }
    }
}
