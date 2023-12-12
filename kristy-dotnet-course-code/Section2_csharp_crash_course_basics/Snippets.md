# 🚀 Snippets

## Section 2: C# Crash Course - Basics

### Contents:
* [Command Line Control](#command-line-controls)
* [Creating a Console App](#creating-a-console-app)
* [Nuget Package Source](#nuget-package-source)
* [Console Template (old)](#console-template-old)
* [Console Template (new)](#console-template-new)

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

### **<insert>**
