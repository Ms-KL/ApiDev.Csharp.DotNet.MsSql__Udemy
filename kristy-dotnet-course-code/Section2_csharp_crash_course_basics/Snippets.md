# 🚀 Snippets

## Section 2: C# Crash Course - Basics

### Contents:
* [Command Line Control](#command-line-controls)
* [Creating a Console App](#creating-a-console-app)
* [Nuget Package Source](#nuget-package-source)
* [VS Code Shortcuts](#vs-code-shortcuts)
* [Console Template (old)](#console-template-old)
* [Console Template (new)](#console-template-new)
<br>
<br>
**VARIABLES:**
<br>

* [Bytes, Bits, Int, Short, Long](#bytes-bits-int-short-long)
* [Floating Point Numbers](#floating-point-numbers)
* [String](#string)
* [Boolean](#boolean)
* [Static versus Dynamic Variables](#static-versus-dynamic-variables)
* [Check type of variable](#check-type-of-variable)
<br>
<br>
**DATA STRUCTURES:**
<br>

* [Arrays](#)

<br>

---

### **Command Line Controls:**

| Item | Command | Notes | 
|-|-|-|
| Make New Directory | `mkdir <NewDirectoryName>` |
| Create new template | `dotnet new <TemplateType>` | console, webapi, gitignore |
| Name: <br> App, NameSpace, Directory | `-n <App Name>` <br> `--name <App Name>` |
| Specify Output Directory: | `-o <Output Directory>` <br> `--output <Output Directory>` | |
| Specify Language | `-lang "<Language>"` <br>`--language "<language>"` | Visual Basic, C#, F# |
| Open Current Working Directory in VS Code | `code .` |
| <insert> | `ls` <br> `dir` |
| <insert> | `cd <directory>`  |
| <insert> | `dotnet build`|
| <insert> | `dotnet run`|

<br>

*Back to [contents](#contents)*

---

### **Creating a Console App**
* `cd <ROOT_DIRECTORY>`
* `mkdir kristy-dotnet-course-code`
* `cd kristy-dotnet-course-code`
* `dotnet new -n HelloWorld`
    * ! Error -> No templates or subcommands found matching: '-n'.
* `dotnet new console -n HelloWorld`
* `ls`
* `cd HelloWorld`
* `ls`
* `dotnet run`

<br>

*Back to [contents](#contents)*

---

### **Nuget Package Source**

| Item | Command | Notes | 
|-|-|-|
| Check Nuget Source | `dotnet nuget list source`| Note: See [Error Log](../ErrorResolution.md) for known Nuget issues |
| Add Nuget Source | `dotnet nuget add source https://api.nuget.org/v3/index.json -n nuget.org`| If required. Alt: manually change in Visual Studio - Nuget Package Manager|

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
* From the right start with a value of `1` and double for each digit to the left

        0000000[0] = 0
        0000000[1] = 1
        000000[1]0 = 2

* `byte` vs `sbyte`
    ```csharp

        // 1 byte (8 bit) unsigned, negative
        byte myByte = 255;  
        byte mySecondByte = 0; 

        // 1 byte (8 bit) signed, positive
        sbyte mySbyte = 127;  
        sbyte mySecondSbyte = -128; 

    ```

    * `byte`= 1 byte / 8 bit = unsigned

            00000000 = 0 (min value unsigned)
            00000001 = 1
            00000010 = 2
            00000011 = 3
            00000100 = 4
            00000101 = 5
            00000110 = 6
            00000111 = 7
            00001000 = 8
            00010000 = 16     
            00100000 = 32  
            01000000 = 64                      
            10000000 = 128
            11111111 = 255 (max value unsigned)
            
    * `sbyte` = 1 byte / 8 bit = signed

            00000000 = -128 (min value signed)
            11111111 = 127 (max value signed)

* `ushort` vs `myshort`
    ```csharp

        // 2 byte (16 bit) unsigned, negative
        ushort myUshort = 65535;

        // 2 byte (16 bit) signed, positive
        short myShort = -32768;

    ```

    * `ushort` = 2 byte / 16 bit = unsigned

            0000000000000000 = 0
            1111111111111111 = 65535

    * `myshort` = 2 byte / 16 bit = signed

            0000000000000000 = -32768
            1111111111111111 = 32767

* `int` vs `long`
    ```csharp

        // 4 byte (32 bit) signed, negative
        int myInt = 2147483647;
        int mySecondInt = -2147483648;

        // 8 byte (64 bit) signed, negative
        long myLong = -9223372036854775808;

    ```

    * `int` = 4 byte / 32 bit = signed

            00000000000000000000000000000000 
            = -2147483648

            11111111111111111111111111111111 
            = 2147483647

    * `long` = 8 byte / 64 bit = signed

            00000000000000000000000000000000
            00000000000000000000000000000000 
            = -9223372036854775808

            11111111111111111111111111111111
            11111111111111111111111111111111 
            = 9223372036854775807

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
* list -> dynamic length
* array of strings

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