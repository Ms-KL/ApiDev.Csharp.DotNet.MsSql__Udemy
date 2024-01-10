# 🚀 Snippets

## Section 3: C# Crash Course - Intermediate

Kristy's [HelloWorld Program.cs](./HelloWorld/Program.cs) file

### Contents:

* [Setup Environment](#setup-environment)
* [Change to Console Template](#change-to-console-template-old)
* [Models](#models)
* [Namespace](#namespaces)
* [Database Connection](#database-connection)
* [Using Dapper](#using-dapper)

<br>

[Skip to End](#end)

---

### **VSCode Shortcuts:**

| Item | Command | Notes | 
|-|-|-|
| Bring Up "Fix" Context menu to action squiggly lines | select code +  `ctrl` + `.` | Can fill in missing import / using statement |
| Move line up and down | cursor on line + `alt` + `arrow` | moves code line |



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
* Open Azure Data Studio
    * Connection Type: `Microsoft SQL Server`
    * Input Type: `Parameters`
    * Server: `localhost`
    * Authentication Type: `Windows Authentication` (if logged in as private)
    * Database: `default`
    * Encrypt: `True`
    * Trust Server Certificate: `True`
        * Action Pop-up: `Enable Trust server certificate`
    * Server Group: `default`

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
    * If Database already created and want to re-create when in database:

        ```sql
        -- Change database/branch
        USE master
        GO

        -- Delete
        DROP DATABASE DotNetCourseDatabase

        -- Create
        CREATE DATABASE DotNetCourseDatabase
        GO

        -- Change database
        USE DotNetCourseDatabase
        GO

        -- Create Schema
        CREATE SCHEMA TutorialAppSchema
        GO

        -- Create table
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

        -- Open everything from Computer table/model in schema
        SELECT * FROM TutorialAppSchema.Computer

        ```

<br>

*Back to [contents](#contents)*

---

### **Database Connection**

1. **Run SQL Code in Azure Data Studio** 
    * (code above) to create table & tell C# where the code lives (to be retrievable)

2. **Install Packages:** 
    * Dapper, SQL Client, Entity Framework Core, SQL Server
        ```shell
        cd <HelloWorld project path>

        # -- ADD PACKAGES: --

        dotnet add package Dapper

        dotnet add package microsoft.data.sqlclient
        # access to connections to sql server client / database

        dotnet add package microsoft.entityframeworkcore
        dotnet add package microsoft.entityframeworkcore.sqlserver
        # SQL server access for entity framework

        ```
    
    * **Error**: 
        * A network-related or instance-specific error occurred... ?<br> See [Windows Connection Troubleshooting](https://www.udemy.com/course/net-core-with-ms-sql-beginner-to-expert/learn/lecture/38144014#announcements) or AppVeyor Error [HERE](../ErrorResolution.md/)


    * **What is Dapper & Entity Framework Packages?**
        * *Dapper*
            * Simple way to make queries against database to pull data out or send data back
            * Will start by setting up locally. Then will abstract so it is reusable and global
        * *Entity Framework*
            * Connects directly to an object in the database (eg: table)
                * Access all items on the table
                    * Affect the table data specifically
            * Use C# to write a SQL query

3. **Create and test Database Connection** in VSC
    * `HelloWorld` -> `Program.cs`

    ```csharp
    using System;
    using System.Text.RegularExpressions;

    // import decoupledmodels
    using HelloWorld.Models;

    // Import for IDb Connection to SQL Database
    using System.Data;
    using Microsoft.Data.SqlClient;
    using Dapper;

    namespace HelloWorld
    {
        // models moved to Models.Computer.cs
        public class Program
        {
            public static void Main(string[] args)
            {
                // create connection to database 

                // Mac/Linux:
                // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1;";
                
                // Windows
                string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

                // Create IDB Connection Object to connect to server
                IDbConnection dbConnection = new SqlConnection(connectionString);

                // Create command to test connection
                string sqlCommand = "SELECT GETDATE()";

                // ---------
                // // Test Connection using Connection object, Dapper Query and sqlCommand
                // dbConnection.Query<DateTime>(sqlCommand);
                // // connects to dbConnection and query database using Dapper
                // // Returns a DateTime value using sqlCommand

                // ALT: Single line query:
                // // dbConnection.QuerySingle<DateTime>(sqlCommand);
                // ---------                

                // -- TEST the Connection
                DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
                    // Get the DateTime right now to set the value
                    // Connect to database
                    // Query Database using Dapper
                    // Set the DateTime in the database
                    // Return the value in the database

                // TEST it worked 
                Console.WriteLine(rightNow);

                Console.WriteLine("---------");

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
        
        10/01/2024 12:12:10 PM
        ---------
        True
        z39anvd923
        False
        RTX 26
<br>

*Back to [contents](#contents)*

---

### **Using Dapper**

* thing
* stuff
* code

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