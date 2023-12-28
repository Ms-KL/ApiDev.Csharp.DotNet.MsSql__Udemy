# 🚀 Snippets

## Section 3: C# Crash Course - Intermediate

Kristy's [HelloWorld Program.cs](./HelloWorld/Program.cs) file

### Contents:

* [Setup Environment](#setup-environment)
* [Change to Console Template](#change-to-console-template-old)
* [Models](#models)
* [Namespace](#namespaces)
* [Database Connection](#database-connection)

<br>

[Skip to End](#end)

---

### **Setup Environment**

```shell
    cd <ROOT_DIRECTORY>
    mkdir Section3_csharp_crash_course_intermediate
    cd Section3_csharp_crash_course_intermediate
    New-Item -ItemType File -Name snippets.md
    New-Item -ItemType File -Name README.md

    dotnet new console -n HelloWorld
    ls # check to see if HelloWorld was created
    code . # opens VS Code in that directory

    cd HelloWorld
    dotnet build
    dotnet run
```

---

### **Change to Console Template (Old)**

```csharp

using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
        }
    }
}

```

<br>

*Back to [contents](#contents)*

---

### **Models**

* Way to map data from one place to another (Source Mapping):
    * Database to Application
    * Section to Section within Application
    * Application to Application
    * Map to JSON to present back to users
* Class in C# that will match the field names / property in database for a SQL query
* for not-ideal models, see the [HelloWorld Program.cs](./HelloWorld/Program.cs)
* Ideal model using constructor
    ```csharp
    using System;

    namespace HelloWorld
    {
        public class Computer
        {
            public string Motherboard { get; set; }
            public int CPUCores { get; set; }
            public bool HasWifi { get; set; }
            public bool HasLTE { get; set; }
            public DateTime ReleaseDate { get; set; }
            public decimal Price { get; set; }
            public string VideoCard { get; set; } 

            // Constructor nullable
            // public matching public variables = accessible
            public Computer() // can access Motheboard & VideoCard
            {
                if (Motherboard == null)
                {
                    Motherboard = "";
                }

                if (VideoCard == null)
                {
                    VideoCard = "";
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                // create first instance of Computer model
                Computer myComputer = new Computer()
                {
                    Motherboard = "z39anvd923",
                    HasWifi = true,
                    HasLTE = false,
                    ReleaseDate = DateTime.Now,
                    Price = 943.87m,
                    VideoCard = "RTX 26"
                };

                Console.WriteLine(myComputer.HasWifi);

                // change values
                myComputer.HasWifi = false;

                Console.WriteLine(myComputer.Motherboard);
                Console.WriteLine(myComputer.HasWifi);
                Console.WriteLine(myComputer.VideoCard);

            }
        } 

    }
    ```
    Return:

        True
        z39anvd923
        False
        RTX 26

* Ideal model using default instead of constructor
    ```csharp
    using System;

    namespace HelloWorld
    {
        public class Computer
        {
            public string Motherboard { get; set; } = "";
            public int CPUCores { get; set; }
            public bool HasWifi { get; set; }
            public bool HasLTE { get; set; }
            public DateTime ReleaseDate { get; set; }
            public decimal Price { get; set; }
            public string VideoCard { get; set; } = "";
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                // create first instance of Computer model
                Computer myComputer = new Computer()
                {
                    Motherboard = "z39anvd923",
                    HasWifi = true,
                    HasLTE = false,
                    ReleaseDate = DateTime.Now,
                    Price = 943.87m,
                    VideoCard = "RTX 26"
                };

                Console.WriteLine(myComputer.HasWifi);

                // change values
                myComputer.HasWifi = false;

                Console.WriteLine(myComputer.Motherboard);
                Console.WriteLine(myComputer.HasWifi);
                Console.WriteLine(myComputer.VideoCard);

            }
        } 
    }

<br>

*Back to [contents](#contents)*

---

### **Namespaces**

* A way to organise code
* Tells C# where the code lives (to be retrievable)
* **EXAMPLE:** Decoupling model that was in the Program.cs file:
    1. Create a folder in `HelloWorld` named `Models` = `mkdir Models`
    2. Create a file in `Models` named `Computer`.cs = `New-Item -ItemType File -Name Computer.cs`
    3. Extract Model code from `Program.cs` to `Computer.cs`:
        * `Program.cs`:
        ```csharp
            using System;
            using System.Text.RegularExpressions;

            // import decoupledmodels
            using HelloWorld.Models;

            namespace HelloWorld
            {
                // models moved to Models.Computer.cs
                internal class Program
                {
                    static void Main(string[] args)
                    {
                        // create first instance of Computer model
                        Computer myComputer = new Computer()
                        {
                            Motherboard = "z39anvd923",
                            HasWifi = true,
                            HasLTE = false,
                            ReleaseDate = DateTime.Now,
                            Price = 943.87m,
                            VideoCard = "RTX 26"
                        };

                        Console.WriteLine(myComputer.HasWifi);
                        // change values
                        myComputer.HasWifi = false;
                        Console.WriteLine(myComputer.Motherboard);
                        Console.WriteLine(myComputer.HasWifi);
                        Console.WriteLine(myComputer.VideoCard);
                    }
                }
            }
        ```
        * `Computer.cs`:
        ```csharp
            namespace HelloWorld.Models{

                public class Computer
                {
                    // private string _motherboard; (creates automatically)
                    public string Motherboard { get; set; }
                    public int CPUCores { get; set; }
                    public bool HasWifi { get; set; }
                    public bool HasLTE { get; set; }
                    public DateTime ReleaseDate { get; set; }
                    public decimal Price { get; set; }
                    public string VideoCard { get; set; }

                    // Constructor
                    // can access Motherboard & VideoCard
                    public Computer() 
                    {
                        if (Motherboard == null)
                        {
                            Motherboard = "";
                        }
                        if (VideoCard == null)
                        {
                            VideoCard = "";
                        }
                    }
                }

            }        
        ```       

<br>

*Back to [contents](#contents)*

---

### **Computer SQL Script**

* Create an SQL table to mimic the Computer model
* SQL code to copy paste into Azure Data Studio to set up the new table

    ```sql
        CREATE DATABASE DotNetCourseDatabase
        GO
        
        USE DotNetCourseDatabase
        GO
        
        CREATE SCHEMA TutorialAppSchema
        GO
        
        CREATE TABLE TutorialAppSchema.Computer(
            ComputerId INT IDENTITY(1,1) PRIMARY KEY,
            Motherboard NVARCHAR(50),
            CPUCores INT,
            HasWifi BIT,
            HasLTE BIT,
            ReleaseDate DATE,
            Price DECIMAL(18,4),
            VideoCard NVARCHAR(50)
    );
    ```

<br>

*Back to [contents](#contents)*

---

### **Database Connection**

* 2 Packages:
    * Dapper
        * Simple way to make queries against database to pull data out or send data back
        * Will start by setting up locally. Then will abstract so it is reusable and global
    * Entity Framework
        * Connects directly to an object in the database (eg: table)
            * Access all items on the table
                * Affect the table data specifically
        * Use C# to write a SQL query
* Tells C# where the code lives (to be retrievable)
* Note: Mac/Linux users see ["30. MacOS and Linux Users"](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/35282578#announcements)
* **Error**: A network-related or instance-specific error occurred... ?<br> See [Windows Connection Troubleshooting](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/38144014#announcements)

    ```shell
        stuff
    ```

    ```csharp
        stuff
    ```
    Return:
    
        Thing

<br>

*Back to [contents](#contents)*

---

### **Config File**

* `AppSettings.JSON` file
* File with static data to use throughout application
* Create onnection string to connect to file (instead of username and password)
* Able to have multiple JSON files with different data, but same variables for comparing

```shell
    stuff
```

```csharp
    stuff
```

Return:
    Thing

<br>

*Back to [contents](#contents)*

---

#### **End**

*Back to [contents](#contents)*<br>
*Next Unit: [Section 4: SQL Seed](#)*