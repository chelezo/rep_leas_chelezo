using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ArrayHello = new char[] { 'H', 'e', 'l', 'l', 'o' };
            for (int i = ArrayHello.Length - 1; i >= 0; i--)
                Console.Write(ArrayHello[i]);
        }
    }
}
