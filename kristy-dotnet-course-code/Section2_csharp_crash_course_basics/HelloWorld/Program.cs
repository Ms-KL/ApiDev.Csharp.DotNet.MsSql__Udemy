﻿/* _____________________________________________________

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

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
//         // method: something a class can do
//         // Main runs by default
//         static void Main(string[] args)
//         {
 
//             // ----------------------
//             // BYTE, SBYTE
//             // ----------------------

//             // 1 byte (8 bit) unsigned, where unsigned means it can't be negative
//             byte myByte = 255;  
//             byte mySecondByte = 0; 
 
//             // 1 byte (8 bit) signed, where signed means it can be negative
//             sbyte mySbyte = 127;  
//             sbyte mySecondSbyte = -128; 

//             // ----------------------
//             // USHORT, SHORT
//             // ----------------------            

//             // 2 byte (16 bit) unsigned, where signed means it can be negative
//             ushort myUshort = 65535;
 
//             // 2 byte (16 bit) signed, where signed means it can be negative
//             short myShort = -32768;

//             // ----------------------
//             // INT, LONG
//             // ----------------------            
 
//             // 4 byte (32 bit) signed, where signed means it can be negative
//             int myInt = 2147483647;
//             int mySecondInt = -2147483648;
 
//             // 8 byte (64 bit) signed, where signed means it can be negative
//             long myLong = -9223372036854775808;

//             // ----------------------
//             // FLOAT, DOUBLE, DECIMAL
//             // ----------------------  
 
//             // 4 byte (32 bit) floating point number
//             float myFloat = 0.751f;
//             float mySecondFloat = 0.75f;
 
//             // 8 byte (64 bit) floating point number
//             double myDouble = 0.751;
//             double mySecondDouble = 0.75d;
 
//             // 16 byte (128 bit) floating point number
//             decimal myDecimal = 0.751m;
//             decimal mySecondDecimal = 0.75m;

//             // ----------------------
//             // TEST PRECISION
//             // ----------------------              
 
//             Console.WriteLine(myFloat - mySecondFloat);
//             Console.WriteLine(myDouble - mySecondDouble);
//             Console.WriteLine(myDecimal - mySecondDecimal);
 
//             // ----------------------
//             // STRING, CHAR
//             // ---------------------- 
            
//             string myString = "Hello World";
//             Console.WriteLine(myString);

//             char myChar = 'H';
//             Console.WriteLine(myChar);

//             // char myChar2 = "H";
//             // Console.WriteLine(myChar2); // ERROR: can't use  ""

//             // char myChar3 = 'He';
//             // Console.WriteLine(myChar3); // ERROR: > 1 character

//             string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
//             Console.WriteLine(myStringWithSymbols);
 
//             // ----------------------
//             // BOOL, SYSTEM.BOOLEAN
//             // ---------------------- 

//             bool myBool = true;
//             Console.WriteLine(myBool);

//             // bool myBool2 = True; // ERROR: must be lowercase
//             // Console.WriteLine(myBool2);

//             // same as:
//             System.Boolean myBool3 = true; // bool = alias of System.Boolean
//             Console.WriteLine(myBool3);

//             // ----------------------
//             // GETTYPE()
//             // ---------------------- 

//             bool myBoolean = true;
//             Console.WriteLine(myBoolean.GetType());
//             // check variable type

//         }
//     }
// }

/* _____________________________________________________

    Data Structures
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
            // ARRAYS
            // ----------------------

            // array -> immutable length
            // list -> dynamic length

            // array of strings
            string[] myGroceryArray = new string[2];
            // type structure variable = create string array with length of 2

            myGroceryArray[0] = "Guacamole";
            myGroceryArray[1] = "Ice Cream";
            myGroceryArray[0] = "Guacamole NEW";            

            Console.WriteLine(myGroceryArray[0]);
            Console.WriteLine(myGroceryArray[1]);
            // Console.WriteLine(myGroceryArray[2]); 
            // ERROR: Outside bounds of array length of 2

            string[] mySecondGroceryArray = {"Apples", "Eggs"};

            // mySecondGroceryArray[2] = "";
            // ERROR: Outside bounds of array length of 2

            Console.WriteLine(mySecondGroceryArray);
            Console.WriteLine(mySecondGroceryArray[0]);
            Console.WriteLine(mySecondGroceryArray[1]);
            // Console.WriteLine(mySecondGroceryArray[2]);
            // ERROR: Outside bounds of array length of 2
             
            // ----------------------
            // LISTS
            // ----------------------

            // don't need to specify length or pass in values

            List<string> myGroceryList = new List<string>();

            Console.WriteLine(myGroceryList);
            // Console.WriteLine(myGroceryList[0]); // ERROR: outside of bounds

            List<string> mySecondGroceryList = new List<string>() {"milk", "cheese"};

            Console.WriteLine(mySecondGroceryList);
            Console.WriteLine(mySecondGroceryList[0]);
            Console.WriteLine(mySecondGroceryList[1]);

            // add item to list using Add() method in List class
            mySecondGroceryList.Add("oranges");
            Console.WriteLine(mySecondGroceryList[2]);

            // ----------------------
            // IENUMERABLE
            // ----------------------

        	// we need to enumerate through the collection
            // ienumerable is faster for looping
            // If we:
                // want to look @ every element = IEnumerable
                // want to access a single element & dynamically change it = List


            // Declare the ienumerable using existing List or Array
                // can't allocate elements to ienumerable
            IEnumerable<string> myGroceryIEnumerable = mySecondGroceryList;
       
            // Access the first value in myGroceryIEnumerable
            Console.WriteLine(myGroceryIEnumerable.First());

            // can't access the index of the IEnumerable (not indexable)
            //Console.WriteLine(myGroceryIEnumerable[0]); // ERROR: cannot index
            
            // ----------------------          
            // Multi-Dimensional ARRAY
            // ----------------------

            // set values for 2d array when declaring
            string[,] myTwoDimensionalArray = new string[,] 
            {
                { "choc", "banana" },
                { "pie", "cake" }
            };

            // use double index to reference 1st and 2nd dimensions in array
            Console.WriteLine(myTwoDimensionalArray[0,0]);
            Console.WriteLine(myTwoDimensionalArray[1,1]);

        }
    }
}

