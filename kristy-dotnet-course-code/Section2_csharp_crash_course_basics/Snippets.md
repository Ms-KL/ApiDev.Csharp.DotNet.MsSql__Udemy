# 🚀 Snippets

## Section 2: C# Crash Course - Basics

### Contents:


**SETUP ENVIRONMENT:**
* [Command Line Control](#command-line-controls)
* [Creating a Console App](#creating-a-console-app)
* [Nuget Package Source](#nuget-package-source)
* [VS Code Shortcuts](#vs-code-shortcuts)
* [Console Template (old)](#console-template-old)
* [Console Template (new)](#console-template-new)

**VARIABLES:**
* [Bytes, Bits, Int, Short, Long](#bytes-bits-int-short-long)
* [Floating Point Numbers](#floating-point-numbers)
* [String](#string)
* [Boolean](#boolean)
* [Static versus Dynamic Variables](#static-versus-dynamic-variables)
* [Check type of variable](#check-type-of-variable)

**DATA STRUCTURES:**
* [Arrays](#arrays)
* [Lists](#lists)
* [IEnumerable](#ienumerable)
* [Multi-Dimensional Array](#multi-dimensional-array)
* [Dictionaries](#dictionaries)

**OPERATORS & CONDITIONALS:**
* [Math Operators](#math-operators)
* [String Operators](#string-operators)
* [Conditionals](#conditionals)

**CONDITIONAL STATEMENTS:**
* [If, Else If, Else](#conditional-statements-if-else-if-else)
* [Switch](#conditional-statements-switch)

<br>

[Skip to End](#end)

---

### **Command Line Controls:**

| Item | Command | Notes | 
|-|-|-|
| Make New Directory | `mkdir <NewDirectoryName>` |
| Create new template | `dotnet new <TemplateType>` | console, webapi, gitignore |
| Name: <br> App, NameSpace, Directory | `-n <App Name>` <br> `--name <App Name>` |
| Create new console app with name | `dotnet new console -n ProjectName` | 
| Specify Output Directory: | `-o <Output Directory>` <br> `--output <Output Directory>` | |
| Specify Language | `-lang "<Language>"` <br>`--language "<language>"` | Visual Basic, C#, F# |
| Open Current Working Directory in VS Code | `code .` |
| Print directory contents | `ls` <br> `dir` |
| Change directory | `cd <directory>`  |
| Build project | `dotnet build`| 
| Run project | `dotnet run`|

<br>

*Back to [contents](#contents)*

---

### **Creating a Console App**

```shell
    cd <ROOT_DIRECTORY>
    mkdir kristy-dotnet-course-code

    dotnet new -n HelloWorld
    # ! Error -> No templates or subcommands found matching: '-n'.

    dotnet new console -n HelloWorld
    ls # check to see if HelloWorld was created
    cd HelloWorld
    
    dotnet build
    dotnet run
```

<br>

*Back to [contents](#contents)*

---

### **Nuget Package Source**

| Item | Command | Notes | 
|-|-|-|
| Check Nuget Source | `dotnet nuget list source`| Note: See [Error Log](../ErrorResolution.md) for known Nuget issues |
| Add Nuget Source | `dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org`| If required. <br>Alt: manually change in Visual Studio - Nuget Package Manager|

---

### **VS Code Shortcuts**

| Item | Command | Notes |
|-|-|-|
| Search for Error | `F8`| Ensure only related directory is open in VSC (same with debugging) |

---

### **Console Template (Old)**

```csharp

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

```

<br>

*Back to [contents](#contents)*

---

### **Console Template (New)**

Iterating against `args` from above structure

```csharp
Console.WriteLine(args[0]);
// note: [0] first element of string in old structure
```

Terminal: 
* passing in argument to print to console
* will print: **thisistheargumentthatwillprint**

```shell
dotnet run thisistheargumentthatwillprint
```

Or ignore `args`

```csharp
// structure is implicit and hidden.
Console.WriteLine("Hello World!");
```

Terminal:
* will print: **Hello World!**
```shell
dotnet run
```

<br>

*Back to [contents](#contents)*

---

### **Bytes, Bits, Int, Short, Long**

* 1 Byte = 8 Bits = `00000000`
* 1 Bit `0` = `0` or `1` (binary)
* `unsigned` = can't be negative
* `signed` = can be negative

<br>

| **type** | `byte` | `sbyte` | `ushort` | `myshort` | `int` | `long` |
| - | - | - | - | - | - | - |
| **pos/neg** | unsigned | signed | unsigned | signed | signed | signed |
| **size** | 1 byte (8 bit) | 1 byte (8 bit) |  2 byte (16 bit) | 2 byte (16 bit) | 4 byte (32 bit) | 4 byte (32 bit) | 4 byte (32 bit) |
| **min** | 0 | -128 | 0 | -32768 | -2147483648 | -9223372036854775808 |
| **max** | 255 | 127 | 65535 | 32767 | 2147483647 | ? |
| **binary** | 00000000 | 00000000 | 00000000 <br> 00000000 | 00000000 <br> 00000000 | 00000000 00000000 <br> 00000000 00000000 | 00000000 00000000 <br> 00000000 00000000 |

<br>

Allocating `byte`: From the right start with a value of `1` and double for each digit to the left:

        0000000[0]      = 0
        0000000[1]      = 1
        000000[1]0      = 2
        000000[11]      = 3
        00000[1]00      = 4
        00000[1]0[1]    = 5
        00000[11]0      = 6      
        00000[111]      = 7      
        0000[1]000      = 8   
        0000[1]00[1]    = 9
        0000[1]0[1]0    = 10
        0000[1]00[1]    = 11   
        000[1]0000      = 16          
        00[1]00000      = 32         
        0[1]000000      = 64                            
        [1]0000000      = 128        
        [11111111]      = 255            

Allocating variables based on size requirements:

```csharp

    // 1 byte (8 bit) unsigned, negative
    byte myByte = 255;  
    byte mySecondByte = 0; 

    // 1 byte (8 bit) signed, positive
    sbyte mySbyte = 127;  
    sbyte mySecondSbyte = -128; 

    // 2 byte (16 bit) unsigned, negative
    ushort myUshort = 65535;

    // 2 byte (16 bit) signed, positive
    short myShort = -32768;

    // 4 byte (32 bit) signed, negative
    int myInt = 2147483647;
    int mySecondInt = -2147483648;

    // 8 byte (64 bit) signed, negative
    long myLong = -9223372036854775808;

```
<br>

*Back to [contents](#contents)*

---
### **Floating Point Numbers**

* `f` = float
* `d` = double
* `m` = decimal <-- most likely to use
* `<no suffix>` = double <-- default

```csharp

    // 4 byte (32 bit) floating point number
    float myFloat = 0.751f; // 
    float mySecondFloat = 0.75f;

    // 8 byte (64 bit) floating point number
    double myDouble = 0.751;
    double mySecondDouble = 0.75d;

    // 16 byte (128 bit) floating point number
    decimal myDecimal = 0.751m;
    decimal mySecondDecimal = 0.75m;

```

Terminal:
* expected answer: `0.001`
```shell
    Console.WriteLine(myFloat - mySecondFloat);
    Console.WriteLine(myDouble - mySecondDouble);
    Console.WriteLine(myDecimal - mySecondDecimal);
```

Result:
* changes based on precision associated with the type and space allocated for that type

        0.0009999871
        0.0010000000000000009
        0.001
<br>

*Back to [contents](#contents)*

---
### **String**

* `string` vs `char`

    ```csharp

        string myString = "Hello World";
        Console.WriteLine(myString);

        char myChar = 'H';
        Console.WriteLine(myChar);

        char myChar2 = "H";
        Console.WriteLine(myChar2); // ERROR: can't use  ""

        char myChar3 = 'He';
        Console.WriteLine(myChar3); // ERROR: > 1 character

    ```

---
### **Boolean**

* `bool` vs `System.Boolean`

    ```csharp

        bool myBool = true;
        Console.WriteLine(myBool);

        bool myBool2 = True; // ERROR: must be lowercase
        Console.WriteLine(myBool2);

        // same as:
        System.Boolean myBool3 = true;
        // bool = alias of System.Boolean
        Console.WriteLine(myBool3);

    ```
<br>

*Back to [contents](#contents)*

---
### **Static versus Dynamic Variables**
* C# is a `statically` typed language
    * variable type is `immutable`
* versus Python `dynamically` typed
    * variable type is `mutable`

---
### **Check type of variable**
* `GetType()`:
    ```csharp
        
        bool myBoolean = true;
        Console.WriteLine(myBoolean.GetType());
        // check variable type

    ```

    Result:
            
            System.Boolean


---
### **Arrays**

* array -> immutable length
* array of strings = `string[] <myArrayName> = new string[<length>]`

    ```csharp
        // array of strings
        string[] myGroceryArray = new string[2];
            
        // type structure variable = create string array with length of 2 
        // Length = Bounds of array

        myGroceryArray[0] = "Guacamole";

        Console.WriteLine(myGroceryArray[0]); // Guacamole
        Console.WriteLine(myGroceryArray[1]); // <blank>
        Console.WriteLine(myGroceryArray[2]); // ERROR: Outside bounds of array

    ```

    Result:

        Guacamole

        Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

* change the values within the array:

    ```csharp
        // array of strings
        string[] myGroceryArray = new string[2];
            
        // type structure variable = create string array with length of 2 
        // Length = Bounds of array

        myGroceryArray[0] = "Guacamole";
        myGroceryArray[1] = "Ice Cream";
        myGroceryArray[0] = "Guacamole NEW";          

        Console.WriteLine(myGroceryArray[0]);
        Console.WriteLine(myGroceryArray[1]); 

    ```

    Result:

        Guacamole NEW
        Ice Cream

* ERROR: Outside the bounds of the array

    ```csharp
        // array of strings
        string[] myGroceryArray = new string[2];

        myGroceryArray[0] = "Guacamole";
        myGroceryArray[1] = "Ice Cream";
        myGroceryArray[0] = "Guacamole NEW";          

        Console.WriteLine(myGroceryArray);
        Console.WriteLine(myGroceryArray[0]);
        Console.WriteLine(myGroceryArray[1]); 
        Console.WriteLine(myGroceryArray[2]); 
        // ERROR: Outside bounds of array 

        string[] mySecondGroceryArray = {"Apples", "Eggs"};

        mySecondGroceryArray[2] = "";
        // ERROR: Outside bounds of array 

        Console.WriteLine(mySecondGroceryArray[0]);
        Console.WriteLine(mySecondGroceryArray[1]);
        Console.WriteLine(mySecondGroceryArray[2]);
        // ERROR: Outside bounds of array

    ```  
    Result:

        System.String[]
        Guacamole NEW
        Ice Cream    
        Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.

        Apples
        Eggs
        Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.    

<br>

*Back to [contents](#contents)*

---
### **Lists**

* list -> dynamic length
* list is the class
* eg: `List<type> myGroceryList = new List<type>();`
    * `List<string> myGroceryList = new List<string>();`
    * list of strings, with length of 0
* don't need to provide a size or pass in values

* Create an empty List of Strings

    ```csharp

        // List is a class
        // Contains methods like .Add()

        // Initialise a list of strings 
        List<string> myGroceryList = new List<string>();

        Console.WriteLine(myGroceryList);
        Console.WriteLine(myGroceryList[0]); 
        // ERROR: Index was out of range.

    ```

    Result:

        System.Collections.Generic.List`1[System.String]
        Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')

* Add items to the List using Add()

    ```csharp

        List<string> mySecondGroceryList = new List<string>() {"milk", "cheese"};

        Console.WriteLine(mySecondGroceryList);
        Console.WriteLine(mySecondGroceryList[0]);
        Console.WriteLine(mySecondGroceryList[1]);

        // add item to list using Add() method in List class
        mySecondGroceryList.Add("oranges");
        Console.WriteLine(mySecondGroceryList[2]);

    ```

    Result:

        System.Collections.Generic.List`1[System.String]
        milk
        cheese
        oranges

<br>

*Back to [contents](#contents)*

---
### **IEnumerable**

* use when needing to enumerate through an existing collection
* `IEnumerable` = faster for looping
* If we:
    * want to look @ every element = `IEnumerable`
    * want to access a single element & dynamically change it = `List`
* Can't allocate elements to an `IEnumerable`
    * must use existing `Array` or `List`

<br>

* Declare the ienumerable using existing List or Array

    ```csharp

        // Declare a list (or array) with elements
        List<string> mySecondGroceryList = new List<string>() {"milk", "cheese"};

        // Declare the ienumerable using List or Array
        IEnumerable<string> myGroceryIEnumerable = mySecondGroceryList;

        // Access the first value in myGroceryIEnumerable
        Console.WriteLine(myGroceryIEnumerable.First());

    ```

    Result:
        
        milk


* Access the index of the `myGroceryIEnumerable`


    ```csharp

        // Declare a list (or array) with elements
        List<string> mySecondGroceryList = new List<string>() {"milk", "cheese"};

        // Declare the ienumerable using List or Array
        IEnumerable<string> myGroceryIEnumerable = mySecondGroceryList;

        // can't access the index of the IEnumerable
        Console.WriteLine(myGroceryIEnumerable[0]); 
        // ERROR: cannot index

    ```

    Result:
        
        error CS0021: Cannot apply indexing with [] to an expression of type 'IEnumerable<string>'

<br>

*Back to [contents](#contents)*

---
### **Multi-Dimensional Array**

* Create multi-dimensional array (and array of arrays)
    ```csharp
        // set values for 2d array when declaring
        string[,] myTwoDimensionalArray = new string[,] 
        {
            { "choc", "banana" },
            { "pie", "cake" }
        };

        // use double index 
        // Reference 1st and 2nd dimensions in array
        Console.WriteLine(myTwoDimensionalArray[0,0]);
        Console.WriteLine(myTwoDimensionalArray[1,1]);
    ```

* Return:

        choc
        cake

<br>

*Back to [contents](#contents)*

---
### **Dictionaries**

* key / value pairs
* must declare pairs of array (key/value)

    ```csharp
        Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>
        {
            {"Cheese", "Dairy"}
        };

        // use key to obtain value
        Console.WriteLine(myGroceryDictionary["Cheese"]);

    ```
    Result:

        Dairy

* map to an array of strings

    ```csharp
        Dictionary<string, string[]> my2DGroceryDictionary = new Dictionary<string, string[]>()
        {
            {"Dairy", new string[]{"Cheese", "Milk", "Yoghurt"}}
        };

        // use key & index to obtain value
        Console.WriteLine(my2DGroceryDictionary["Dairy"][2]);

    ```

    Result:

        Yoghurt

* Exercise:
    * create a dictionary with string keys and decimal values called "itemPrices".
    * Set the price for "cheese" to 5.99 and the price for  "carrots" to 2.99.
    * Solution:
        ```csharp
            Dictionary<string,decimal> itemPrices = new Dictionary<string,decimal>
            {
                {"cheese", 5.99m},
                {"carrots", 2.99m}
            };

            Console.WriteLine(itemPrices["cheese"].GetType());
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);
        ```
    * Result:

            System.Decimal
            5.99
            2.99
<br>

*Back to [contents](#contents)*

---
### **Math Operators**

* ++, +=, -=, +, -, *, /

    ```csharp
        int myInt = 5;
        int mySecondIt = 10;
        Console.WriteLine(myInt);

        // increments variable by 1
        myInt++; 
        Console.WriteLine(myInt);

        // add value (7) to variable
        myInt+= 7;
        Console.WriteLine(myInt);

        // minus value (8) to variable
        myInt-= 8;
        Console.WriteLine(myInt);

        // multiply
        Console.WriteLine(myInt * mySecondIt);

        // divide
        Console.WriteLine(myInt / mySecondIt);

        // minus
        Console.WriteLine(myInt - mySecondIt);

        // add
        Console.WriteLine(myInt + mySecondIt);
    ```
    Result:

        5
        6
        13
        5
        50
        0
        -5
        15
    
* `PEMDAS`: (), Exponents, *, /, +, -   

    ```csharp
        // * and / grouped together - do what comes first
        // + and - grouped together - do what comes first

        Console.WriteLine(5 + 5 * 10);
        // multiply first, addition second
            // 5 * 10 = 50 
            // 50 + 5 = 55

        Console.WriteLine((5 + 5) * 10);
        // parenthses first, then multiplication
            // 5 + 5 = 10
            // 10 * 10 = 100
    ```
    Result:

        55
        100

* `MATH.Method()`: Pow, Sqrt 

    ```csharp
        Console.WriteLine(Math.Pow(5,2));
        // Exponents
            // 5 to the power of 2
            // 5 x 5 = 25
            // 5 squared = 25

        Console.WriteLine(Math.Pow(5,4));
        // Exponents
            // 5 to the power of 4
            // 5 x 5 x 5 x 5 = 625
            // 5 cubed = 625

        Console.WriteLine(Math.Sqrt(25));
        // Exponents
            // Square root of 25 = 5
    ```
    Result:

        25
        625
        5
<br>

*Back to [contents](#contents)*

---
### **String Operators**

* +=, =,

    ```csharp

        string myString = "first part";
        Console.WriteLine(myString);

        myString += ". second part";
        Console.WriteLine(myString);

        myString = myString + ". third part.";
        Console.WriteLine(myString);
    ```
    Result:

        first part
        first part. second part
        first part. second part. third part.

* use escape `\` to ignore next protected character

    ```csharp
        myString = myString + " \"third\\ part.";
        // Use \ to print " from: "third
        // Use \ to print d\ from: "d\\
        Console.WriteLine(myString);

    ```
    Result:

        first part. second part. third part. "third\ part.

* split the string into an array using one character as separator

    ```csharp
        string[] myStringArr = myString.Split(' ');
        // when a space is identified: 
        // split element from the string into the array

        Console.WriteLine(myStringArr[0]);
        Console.WriteLine(myStringArr[1]);   

    ```
    Result:

        first
        part.

* split the string into an array using multiple characters as separator

    ```csharp
        string[] myStringArr2 = myString.Split(". ");
        // when a ". " is identified, 
        // split that element from the string into the array

        Console.WriteLine(myStringArr2[0]);
        Console.WriteLine(myStringArr2[1]);  

    ```
    Result:

        first part
        second part

<br>

*Back to [contents](#contents)*

---
### **Conditionals**

* .Equals(), ==, !=, >= , <=, >, <, &&, ||

    ```csharp
            int myIntNew = 5;
            int mySecondInt = 10;

            Console.WriteLine(myIntNew.Equals(mySecondInt)); // false
            Console.WriteLine(myIntNew.Equals(mySecondInt/2)); // true

            // equal to
            Console.WriteLine(myIntNew == mySecondInt ); // false  
            Console.WriteLine(myIntNew == mySecondInt / 2 ); // true  

            // equal to
            Console.WriteLine(myIntNew != mySecondInt ); // true  
            Console.WriteLine(myIntNew != mySecondInt / 2 ); // false  

            // greater than, less than, equal to
            Console.WriteLine(myIntNew >= mySecondInt); // false          
            Console.WriteLine(myIntNew >= mySecondInt / 2); // true
            Console.WriteLine(myIntNew > mySecondInt); // false
            Console.WriteLine(myIntNew > mySecondInt - 6); // true
            Console.WriteLine(myIntNew <= mySecondInt); // true
            Console.WriteLine(myIntNew < mySecondInt); // true  

            // && = AND   
            Console.WriteLine(5 < 10 && 5 > 10); // false
            // check: 5 less than 10 AND 5 greater than 10

            // || = OR   
            Console.WriteLine(5 < 10 || 5 > 10); // true
            // check: 5 less than 10 OR 5 greater than 10

    ```

<br>

*Back to [contents](#contents)*

---
### **Conditional Statements: If, Else If, Else**

* if (true):
    ```csharp
        // IF (True) STATEMENT
        // Code doesn't run when false

        int myInt = 5;
        int mySecondInt = 10;

        if (myInt > mySecondInt)
        // false: code doesn't run
        {
            myInt += 10;
        }

    ```
    Result:

        <nothing>

 * multiple if:
    ```csharp
        // IF (True) + IF (True) 
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
    ```
    Result:

        not equal      

 * if - else:
    ```csharp
        // IF (True) 
        // ELSE (otherwise) 
        // Same as multiple if statements, but combined
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
    ```
    Result:

        not equal  

 * if - else if:
    ```csharp
        // IF (True) 
        // ELSE IF (alternative condition TRUE) 
        // Run IF when true, when false: 
            // run ELSE IF when true, when false: 
                // do nothing

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
    ```
    Result:

         <nothing>
    
 * if - else if - else:
    ```csharp
        // IF (True) 
        // ELSE IF (alternative condition TRUE) 
        // ELSE (otherwise) 
        // Run IF when true, when false: 
            // run ELSE IF when true, when false: 
             // run ELSE

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
    ```
    Result:

        not equal
        
<br>

*Back to [contents](#contents)*

---
### **Conditional Statements: Switch**

* alternative to if - else if - else
* cleaner option
* good for when comparing to the same thing
* can ONLY compare to CONSTANT values
* eg: compare a given variable to a constant
    * given variable = `myCow`
    * comparison variable = `myCapitalisedCow` <-- CANNOT USE
    * Instead: define a permanent value (eg `"Cow"` instead of variable)

* myCow example using `switch` instead of if - else if - else:
    ```csharp
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
    ```
    Result:

        Default Ran

<br>

*Back to [contents](#contents)*

---
### **Loops**

* manual way of using items in a list/array 
    ```csharp
        using System;
        using System.Data;

        namespace HelloWorld
        {
            internal class Program
            {    
                // method: something a class can do
                // Main runs by default
                static void Main(string[] args)
                {
                    int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35};   
                    DateTime startTime = DateTime.Now;

                    int totalValue = intsToCompress[0] + intsToCompress[1]
                        + intsToCompress[2] + intsToCompress[3] 
                        + intsToCompress[4] + intsToCompress[5]
                        + intsToCompress[6];

                    // Measure how long it takes to perform calculation
                    Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
                    
                    Console.WriteLine(totalValue);
                }
            }
        }
    ```
* Result:

        0.0028033
        147

* **`for`** = set number of times it will run
    * `for(type i = value; condition, increment){actionblock} `
    ```csharp
        using System;
        using System.Data;

        namespace HelloWorld
        {
            internal class Program
            {    
                // method: something a class can do
                // Main runs by default
                static void Main(string[] args)
                {
                    // Instead of manually adding as above, use a for loop
                    // for 
                    // (
                        // starting index variable value, 
                        // run while condition is true, 
                        // increment for index per loop
                    // )

                    int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35};   
                    int totalValue = 0;
                    DateTime startTime = DateTime.Now;

                    for (int i = 0; i < intsToCompress.Length; i++)
                    {
                        totalValue += intsToCompress[i];
                        Console.WriteLine(totalValue);
                    }

                    // Measure how long it takes to perform calculation
                    Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

                    Console.WriteLine(totalValue);
                }
            }
        }
    ```
* Result:

        10
        25
        45
        70
        100
        112
        147
        0.0121354
        147
 
* **`for each`** = will run as long as the length of the array/list
    * `foreach(type valueOfCurrentIndex in ArrayorList){actionblock}`
    ```csharp
        // faster than for loop
        // keeps iteration in the bounds of the list/array

        int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35};   
        int totalValue = 0;
        DateTime startTime = DateTime.Now;

        foreach(int intForCompression in intsToCompress)
        {
            totalValue += intForCompression;
            // for each loop: 
                // add the value of the current item in the array (intForCompression) 
                    // to the totalValue
        }

        // Measure how long it takes to perform calculation
        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

        Console.WriteLine(totalValue);
    ```
    Result:

        0.0124326
        147

* **`while`** = til a conditional statement is false
    * `while(condition){actionblockleadingtofalseresult}`
    ```csharp
        // need a condition to check to see if true in order to make loop run
        int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35};   
        int totalValue = 0;
        int index = 0;

        DateTime startTime = DateTime.Now;


        while(index < intsToCompress.Length)
        {
            totalValue += intsToCompress[index];
            index++;
        }

        // Measure how long it takes to perform calculation
        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);
    ```
    Result:

        0.0126718
        147

* **`do while`** = will run at least once and run as long as a conditional statement is true
    * `do{actionblock}while(condition)`
    ```csharp
        // run code at least once and then until condition is true
        int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35}; 
        int totalValue = 0;
        int index = 0;   
        DateTime startTime = DateTime.Now;       

        do
        {
            totalValue += intsToCompress[index];
            //Console.WriteLine(index);
            //Console.WriteLine(index < intsToCompress.Length);
            index++;

        }while(index < intsToCompress.Length);

        // Measure how long it takes to perform calculation
        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);
    ```
    Result:

        0.0128469
        147

* alternative: use **`.Sum()`**:
    ```csharp
        int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35}; 
        DateTime startTime = DateTime.Now; 

        int totalValue = intsToCompress.Sum();
        // Measure how long it takes to perform calculation

        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);
    ```
    Result:

        0.0208214
        147

* conditional **`foreach`**:
    ```csharp
        int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 12, 35}; 
        int totalValue = 0;
        DateTime startTime = DateTime.Now;         

        foreach(int intForCompression in intsToCompress)
        {
            if (intForCompression > 20)
            {
                totalValue += intForCompression;
                Console.WriteLine(intForCompression);
            }
        }

        // Measure how long it takes to perform calculation
        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
        Console.WriteLine(totalValue);
    ```
    Result:

        25
        30
        35
        0.0246121
        90

* loops exercise using **`if` and `foreach`**:
    ```csharp
        // use a foreach loop to print every even number 
            // in myNumberList to the console

        List<int> myNumberList = new List<int>()
        {
            2, 3, 5, 6, 7, 9, 10, 123, 324, 54
        };

        foreach(int number in myNumberList)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            };
        };
    ```
    Result:

        25
        30
        35
        0.0246121
        90

<br>

*Back to [contents](#contents)*

---
### **Methods, Arguments, Return**

* gives ability to break up / refactor code
* access in multiple files & reuse logic (generalisable)
* pass values to a method (the values are called arguments)
* return values and pass between methods
* Method with an array of integers argument
    ```csharp
    using System;

    namespace HelloWorld
    {
        internal class Program
        { 
            static void Main(string[] args)
            {
                // Create a method and call it by passing in an argument (keep it dynamic)

                int[] intsToCompress2 = new int[] {10, 15, 20, 25, 30, 12, 35};    

                int totalValue = GetSum(intsToCompress2);

                Console.WriteLine(totalValue);

                static int GetSum(int[] intsToCompress)
                // private?
                {

                    int totalValue = 0;

                    foreach(int intForCompression in intsToCompress)
                    {
                        totalValue += intForCompression;
                        Console.WriteLine(totalValue);
                    }

                    return totalValue;
                } 
            }
        }
    }
    ```
    Result:

        10
        25
        45
        70
        100
        112
        147
        147

* Method Exercise: 
    * Write a new method inside of the Exercise class called "`PrintIfOdd`".
    * The new `PrintIfOdd` method should accept a single `int` as an argument
    * The method should check `if` the argument is odd, and run Console.`WriteLine()` to print the number to the console if it is odd.
    * Solution:
    ```csharp

        using System;
        using System.Collections.Generic;

        namespace Coding.Exercise
        {
            public class Exercise
            {
                public void RunExercise()
                {
                    List<int> myNumberList = new List<int>(){
                        2, 3, 5, 6, 7, 9, 10, 123, 324, 54
                    };
                    
                    foreach (int number in myNumberList)
                    {
                        PrintIfOdd(number);
                    }
                    
                }
                //Write Your Code Here
                public void PrintIfOdd(int number)
                {
                    
                    if (number % 2 == 1)
                    {
                        Console.WriteLine(number);
                    }
                }
            

                
                //Expected output:
                //3
                //5
                //7
                //9
                //123
                
            }
        }

    
    ```


<br>

*Back to [contents](#contents)*

---
### **Scope**

* decide where duplicate variable names can be used in different contexts, in the same program
* 
* thing
    ```csharp
        <insert>
    ```
    Result:

        Thing              

#### **End**