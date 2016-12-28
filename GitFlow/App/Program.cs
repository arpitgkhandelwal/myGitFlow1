using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine();
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}!!", name);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
