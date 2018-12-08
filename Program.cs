using System;
using stringModifierClassLibrary;

namespace libraryRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ChangeMyString.MakeAllUpperCase("Hello World!"));
            Console.WriteLine(ChangeMyString.MakeReverse("Hello World!"));
        }
    }
}
