/* _____________________________________________________

    Hello World
_______________________________________________________*/

// See https://aka.ms/new-console-template for more information

// ----------------------
// new version:
// ----------------------

// Console.WriteLine("Hello, C# programmers");
// Console.Write("First");
// Console.Write("Second");
// Console.WriteLine("Hello, C# programmers");
// Console.Write("First");
// Console.Write("Second"); 
// we are inside a method/class

// ----------------------
// alternative (passing in arguments):
// ----------------------

// Console.WriteLine(args[0]);
// in terminal: dotnet run <argument to print>

// ----------------------
// old version: 
// Will be used for course to help understanding
// ----------------------

using System;

namespace HelloWorld
{
    internal class Program
    {
        // method: something a class can do
        // Main runs by default
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
