using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();
        }
    }
}
