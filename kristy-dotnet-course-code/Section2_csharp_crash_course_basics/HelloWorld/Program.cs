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

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
//         // method: something a class can do
//         // Main runs by default
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

/* _____________________________________________________

    Variables
_______________________________________________________*/

using System;

namespace HelloWorld
{
    internal class Program
    {
        // method: something a class can do
        // Main runs by default
        static void Main(string[] args)
        {
 
            // ----------------------
            // BYTE, SBYTE
            // ----------------------

            // // 1 byte (8 bit) unsigned, where unsigned means it can't be negative
            // byte myByte = 255;  
            // byte mySecondByte = 0; 
 
            // // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;  
            // sbyte mySecondSbyte = -128; 

            // ----------------------
            // USHORT, SHORT
            // ----------------------            

            // // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            // // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;

            // ----------------------
            // INT, LONG
            // ----------------------            
 
            // // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            // // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;

            // ----------------------
            // FLOAT, DOUBLE, DECIMAL
            // ----------------------  
 
            // // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;
 
            // // 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;
 
            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;

            // ----------------------
            // TEST PRECISION
            // ----------------------              
 
            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);
 
            // ----------------------
            // STRING, CHAR
            // ---------------------- 
            
            // string myString = "Hello World";
            // Console.WriteLine(myString);

            // char myChar = 'H';
            // Console.WriteLine(myChar);

            // char myChar2 = "H";
            // Console.WriteLine(myChar2); // ERROR: can't use  ""

            // char myChar3 = 'He';
            // Console.WriteLine(myChar3); // ERROR: > 1 character

            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // Console.WriteLine(myStringWithSymbols);
 
            // ----------------------
            // BOOL, SYSTEM.BOOLEAN
            // ---------------------- 

            // bool myBool = true;
            // Console.WriteLine(myBool);

            // bool myBool2 = True; // ERROR: must be lowercase
            // Console.WriteLine(myBool2);

            // // same as:
            // System.Boolean myBool3 = true;
            // // bool = alias of System.Boolean
            // Console.WriteLine(myBool3);

            // ----------------------
            // GETTYPE()
            // ---------------------- 
            bool myBoolean = true;
            Console.WriteLine(myBoolean.GetType());
            // check variable type

        }
    }
}
