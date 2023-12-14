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

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
            // Console.WriteLine("VARIABLES");    
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

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
            // Console.WriteLine("DATA STRUCTURES");    
//         // method: something a class can do
//         // Main runs by default
//         static void Main(string[] args)
//         {
 
//             // ----------------------
//             // ARRAYS
//             // ----------------------

//             // array -> immutable length
//             // list -> dynamic length

//             // array of strings
//             string[] myGroceryArray = new string[2];
//             // type structure variable = create string array with length of 2

//             myGroceryArray[0] = "Guacamole";
//             myGroceryArray[1] = "Ice Cream";
//             myGroceryArray[0] = "Guacamole NEW";            

//             Console.WriteLine(myGroceryArray[0]);
//             Console.WriteLine(myGroceryArray[1]);
//             // Console.WriteLine(myGroceryArray[2]); 
//             // ERROR: Outside bounds of array length of 2

//             string[] mySecondGroceryArray = {"Apples", "Eggs"};

//             // mySecondGroceryArray[2] = "";
//             // ERROR: Outside bounds of array length of 2

//             Console.WriteLine(mySecondGroceryArray);
//             Console.WriteLine(mySecondGroceryArray[0]);
//             Console.WriteLine(mySecondGroceryArray[1]);
//             // Console.WriteLine(mySecondGroceryArray[2]);
//             // ERROR: Outside bounds of array length of 2
             
//             // ----------------------
//             // LISTS
//             // ----------------------

//             // don't need to specify length or pass in values

//             List<string> myGroceryList = new List<string>();

//             Console.WriteLine(myGroceryList);
//             // Console.WriteLine(myGroceryList[0]); // ERROR: outside of bounds

//             List<string> mySecondGroceryList = new List<string>() {"milk", "cheese"};

//             Console.WriteLine(mySecondGroceryList);
//             Console.WriteLine(mySecondGroceryList[0]);
//             Console.WriteLine(mySecondGroceryList[1]);

//             // add item to list using Add() method in List class
//             mySecondGroceryList.Add("oranges");
//             Console.WriteLine(mySecondGroceryList[2]);

//             // ----------------------
//             // IENUMERABLE
//             // ----------------------

//         	// we need to enumerate through the collection
//             // ienumerable is faster for looping
//             // If we:
//                 // want to look @ every element = IEnumerable
//                 // want to access a single element & dynamically change it = List


//             // Declare the ienumerable using existing List or Array
//                 // can't allocate elements to ienumerable
//             IEnumerable<string> myGroceryIEnumerable = mySecondGroceryList;
       
//             // Access the first value in myGroceryIEnumerable
//             Console.WriteLine(myGroceryIEnumerable.First());

//             // can't access the index of the IEnumerable (not indexable)
//             //Console.WriteLine(myGroceryIEnumerable[0]); // ERROR: cannot index
            
//             // ----------------------          
//             // Multi-Dimensional ARRAY
//             // ----------------------

//             // set values for 2d array when declaring
//             string[,] myTwoDimensionalArray = new string[,] 
//             {
//                 { "choc", "banana" },
//                 { "pie", "cake" }
//             };

//             // use double index to reference 1st and 2nd dimensions in array
//             Console.WriteLine(myTwoDimensionalArray[0,0]);
//             Console.WriteLine(myTwoDimensionalArray[1,1]);

//             // ----------------------          
//             // Dictionary
//             // ----------------------

//             // key / value pairs
//             // must declare pairs of array (key/value)
//             Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>
//             {
//                 {"Cheese", "Dairy"}
//             };

//             // use key to obtain value
//             Console.WriteLine(myGroceryDictionary["Cheese"]);

//             // map to an array of strings
//             Dictionary<string, string[]> my2DGroceryDictionary = new Dictionary<string, string[]>()
//             {
//                 {"Dairy", new string[]{"Cheese", "Milk", "Yoghurt"}}
//             };

//             // use key & index to obtain value
//             Console.WriteLine(my2DGroceryDictionary["Dairy"][2]);

//             // EXERCISE:
//             // create a dictionary with string keys and decimal values called "itemPrices".
//             // Set the price for "cheese" to 5.99 and the price for  "carrots" to 2.99.

//             Dictionary<string,decimal> itemPrices = new Dictionary<string,decimal>
//             {
//                 {"cheese", 5.99m},
//                 {"carrots", 2.99m}
//             };

//             Console.WriteLine(itemPrices["cheese"].GetType());
//             Console.WriteLine(itemPrices["cheese"]);
//             Console.WriteLine(itemPrices["carrots"]);

//         }
//     }
// }

/* _____________________________________________________

    Operators & Conditionals
_______________________________________________________*/

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
            // Console.WriteLine("OPERATORS & CONDITIONALS");
//         // method: something a class can do
//         // Main runs by default
//         static void Main(string[] args)
//         {
 
//             // ----------------------------------
//             // MATH OPERATORS
//             // ++, +=, -=, +, -, *, /
//             // ----------------------------------

//             int myInt = 5;
//             int mySecondIt = 10;
//             Console.WriteLine(myInt);

//             // increments variable by 1
//             myInt++; 
//             Console.WriteLine(myInt);

//             // add value (7) to variable
//             myInt+= 7;
//             Console.WriteLine(myInt);

//             // minus value (8) to variable
//             myInt-= 8;
//             Console.WriteLine(myInt);

//             // multiply
//             Console.WriteLine(myInt * mySecondIt);

//             // divide
//             Console.WriteLine(myInt / mySecondIt);

//             // minus
//             Console.WriteLine(myInt - mySecondIt);

//             // add
//             Console.WriteLine(myInt + mySecondIt);

//             // ----------------------------------
//             // PEMDAS 
//             // (), Exponents, *, /, +, -   
//             // ----------------------------------

//             // if * and / grouped together (do whatever comes first)
//             // if + and - grouped together (do whatever comes first)

//             Console.WriteLine(5 + 5 * 10);
//             // multiply first, addition second
//                 // 5 * 10 = 50 
//                 // 50 + 5 = 55

//             Console.WriteLine((5 + 5) * 10);
//             // parenthses first, then multiplication
//                 // 5 + 5 = 10
//                 // 10 * 10 = 100

//             // ----------------------------------
//             // MATH.Method() 
//             // Pow, Sqrt  
//             // ----------------------------------

//             Console.WriteLine(Math.Pow(5,2));
//             // Exponents
//                 // 5 to the power of 2
//                 // 5 x 5 = 25
//                 // 5 squared = 25

//             Console.WriteLine(Math.Pow(5,4));
//             // Exponents
//                 // 5 to the power of 4
//                 // 5 x 5 x 5 x 5 = 625
//                 // 5 cubed = 625

//             Console.WriteLine(Math.Sqrt(25));
//             // Exponents
//                 // Square root of 25 = 5

//             // ----------------------
//             // STRING OPERATORS
//             // ----------------------

//             string myString = "first part";
//             Console.WriteLine(myString);

//             myString += ". second part";
//             Console.WriteLine(myString);

//             myString = myString + ". third part.";
//             Console.WriteLine(myString);

//             // use escape \ to ignore next protected character
//             myString = myString + " \"third\\ part.";
//             // Use \ to print " from: "third
//             // Use \ to print d\ from: "d\\
//             Console.WriteLine(myString);

//             // split the string into an array
//             string[] myStringArr = myString.Split(' ');
//             // when a space is identified, split that element from the string into the array
//             Console.WriteLine(myStringArr[0]);
//             Console.WriteLine(myStringArr[1]);            

//             // split the string into an array
//             string[] myStringArr2 = myString.Split(". ");
//             // when a ". " is identified, split that element from the string into the array
//             Console.WriteLine(myStringArr2[0]);
//             Console.WriteLine(myStringArr2[1]);

//             // ----------------------
//             // CONDITIONALS
//             // ----------------------

//             int myIntNew = 5;
//             int mySecondInt = 10;

//             Console.WriteLine(myIntNew.Equals(mySecondInt)); // false
//             Console.WriteLine(myIntNew.Equals(mySecondInt/2)); // true

//             // equal to
//             Console.WriteLine(myIntNew == mySecondInt ); // false  
//             Console.WriteLine(myIntNew == mySecondInt / 2 ); // true  

//             // equal to
//             Console.WriteLine(myIntNew != mySecondInt ); // true  
//             Console.WriteLine(myIntNew != mySecondInt / 2 ); // false  

//             // greater than, less than, equal to
//             Console.WriteLine(myIntNew >= mySecondInt); // false          
//             Console.WriteLine(myIntNew >= mySecondInt / 2); // true
//             Console.WriteLine(myIntNew > mySecondInt); // false
//             Console.WriteLine(myIntNew > mySecondInt - 6); // true
//             Console.WriteLine(myIntNew <= mySecondInt); // true
//             Console.WriteLine(myIntNew < mySecondInt); // true  

//             // && = AND   
//             Console.WriteLine(5 < 10 && 5 > 10); // false
//             // check: 5 less than 10 AND 5 greater than 10

//             // || = OR   
//             Console.WriteLine(5 < 10 || 5 > 10); // true
//             // check: 5 less than 10 OR 5 greater than 10

//         }
//     }
// }

/* _____________________________________________________
    
    Conditional Statements
_______________________________________________________*/

using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONDITIONAL STATEMENTS");

            // ----------------------
            // If, Else If, Else
            // ----------------------
            
            // IF (True) STATEMENT
            // Code doesn't run when false

            int myInt = 5;
            int mySecondInt = 10;

            if (myInt > mySecondInt)
            {
                myInt += 10;
            }

            Console.WriteLine(myInt);
            
            Console.WriteLine("---");

            // IF (True) + IF (True) STATEMENT
            // Code doesn't run when false

            string myCow = "cow";
            string myCapitalisedCow = "Cow";

            if ( myCow == myCapitalisedCow)
            {
                Console.WriteLine("equal");
            }

            if ( myCow != myCapitalisedCow)
            {
                Console.WriteLine("not equal");
            }

            Console.WriteLine("---");

            // IF (True) ELSE (otherwise) STATEMENT
            // Run If code when true, otherwise run else code

            string myCow2 = "cow";
            string myCapitalisedCow2 = "Cow";

            if ( myCow2 == myCapitalisedCow2)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }  

            Console.WriteLine("---");

            // IF (True) ELSE IF (alternative condition TRUE) STATEMENT
            // Run IF when true, when false: run ELSE IF when true, when false: do nothing

            string myCow3 = "cow";
            string myCapitalisedCow3 = "bow";

            if ( myCow3 == myCapitalisedCow3)
            {
                Console.WriteLine("equal");
            }
            else if (myCow3 == myCapitalisedCow3.ToLower())
            {
                Console.WriteLine("Equal without case sensitivity");
            }   

            Console.WriteLine("---");

            // IF (True) ELSE IF (alternative condition TRUE) ELSE (otherwise) STATEMENT
            // Run IF when true, when false: run ELSE IF when true, when false: run ELSE

            string myCow4 = "cow";
            string myCapitalisedCow4 = "banana";

            if ( myCow4 == myCapitalisedCow4)
            {
                Console.WriteLine("equal");
            }
            else if (myCow4 == myCapitalisedCow4.ToLower())
            {
                Console.WriteLine("Equal without case sensitivity");
            }   
            else
            {
                Console.WriteLine("not equal");
            }   

            Console.WriteLine("---");

            // ----------------------------------
            // Switch Statements
            // (alternative to If, Else If, Else)
            // ----------------------------------

            // similar to If - Else if - Else
            // cleaner
            // good for when comparing to the same thing
            // can ONLY compare to CONSTANT values
            // eg: compare a given variable to a constant
            //     given variable = myCow
            //     comparison variable = myCapitalisedCow <-- CANNOT USE
            //     Instead: define a permanent value (eg "Cow" instead of variable)
            
            string myCow5 = "Pie";

            switch (myCow5)
            {
                // when myCow == "cow"
                // same as IF
                case "cow":
                    Console.WriteLine("Lowercase");
                    break; // exit switch if true
                // when myCow == "Cow"
                // same as ELSE IF
                case "Cow":
                    Console.WriteLine("Uppercase");
                    break; // exit switch if true
                // when above cases are not true, run default
                // same as ELSE
                default:
                    Console.WriteLine("Default Ran");
                    break; // exit switch
            };

            Console.WriteLine("---");

        }
    }
}








// Template

/* _____________________________________________________

    Thing
_______________________________________________________*/

// using System;

// namespace HelloWorld
// {
//     internal class Program
//     {
            // Console.WriteLine("TITLE OF SECTION");    
//         // method: something a class can do
//         // Main runs by default
//         static void Main(string[] args)
//         {
 
//             // ----------------------
//             // THING
//             // ----------------------

//         }
//     }
// }

