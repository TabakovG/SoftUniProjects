using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();

            stack.AddRange(new string[] { "aasd", "asdasdasd", "blasldkasld"} );
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
