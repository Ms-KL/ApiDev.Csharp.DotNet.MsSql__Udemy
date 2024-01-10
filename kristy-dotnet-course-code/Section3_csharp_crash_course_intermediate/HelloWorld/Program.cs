/* _____________________________________________________

    Models
_______________________________________________________*/

// using System;

// namespace HelloWorld
// {
    // // -----------------------------------------------------
    // // PUBLIC MODEL CLASS - WRONG
    // // -----------------------------------------------------
    // // Create a Model Class
    // // accessible inside of class

    // public class ComputerLocalModel
    // {
    //     string Motherboard
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PUBLIC FIELD - AGAINST BEST PRACTICE  
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // but turns into publically accessible field

    // public class ComputerPublicModelWithPublicFields
    // {
    //     public string Motherboard; // field
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES - BETTER 
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field

    // public class ComputerPublicModelWithPublicClassPrivateFieldsAndProperties
    // {
    //     private string _motherboard;
    //     private string Motherboard {get; set;}; 
    //         // change & retrieve values of _motherboard field. Motherboard is a property of _motherboard field. Properties: retrieve the field or change the value
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES 
    // // + RETURN VALUES FROM PROPERTIES -  BEST PRACTISE 
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field
    // // return values

    // public class ComputerPublicModelWithPublicClassPrivateFieldsAndPropertiesWithReturn
    // {
    //     private string _motherboard;
    //     private string Motherboard { 
    //         get { return _motherboard; } 
    //         set { _motherboard = value; }
    //         } 
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES 
    // // + RETURN VALUES FROM PROPERTIES + SHORTCUT -  BEST PRACTISE
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field
    // // return values using shortcut alternative  
    // // inherently creates the private field:
    // // private string _motherboard;
    // // uses GET & SET to manipulate _motherboard

    // public class ComputerPublicModelWithPublicClassPrivateFieldsAndPropertiesWithReturnShortcut
    // {
    //     private string Motherboard {get; set;}
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES 
    // // + RETURN VALUES FROM PROPERTIES + SHORTCUT + NON NULLABLE 
    // // -  ISSUES WITH STRING
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field
    // // return values using shortcut alternative  
    // // inherently creates the private field:
    // // private string _motherboard;
    // // uses GET & SET to manipulate _motherboard
    // // Not public field (removing ;)
    // // strings are not nullable -> create issues when instance is created

    // public class ComputerWithNonNullableString
    // {
    //     private string Motherboard { get; set; } // NON NULLABLE ISSUE
    //     public int CPU Cores { get; set; }
    //     public bool HasWifi { get; set; }
    //     public bool HasLTE { get; set; }
    //     public DateTime ReleaseDate { get; set; }
    //     public decimal Price { get; set; }
    //     private string VideoCard { get; set; } // NON NULLABLE ISSUE
    // }
    
    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES 
    // // + RETURN VALUES FROM PROPERTIES + SHORTCUT + NULLABLE 
    // // -  STRING FIX - NOT RECOMMENDED
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field
    // // return values using shortcut alternative  
    // // inherently creates the private field:
    // // private string _motherboard;
    // // uses GET & SET to manipulate _motherboard
    // // Not public field (removing ;)
    // // strings are not nullable -> create issues when instance is created
    // // string? NOT best practise -> use constructor instead

    // public class ComputerWithNullableString
    // {
    //     private string? Motherboard { get; set; } // not recommended
    //     public int CPUCores { get; set; }
    //     public bool HasWifi { get; set; }
    //     public bool HasLTE { get; set; }
    //     public DateTime ReleaseDate { get; set; }
    //     public decimal Price { get; set; }
    //     private string VideoCard { get; set; }

    //     // create constructor to deal with nullable string:
    //     ComputerWithNullableString ()
    //     {
    //         if (VideoCard == null)
    //         {
    //             VideoCard = "";
    //         }
    //     }
    // }

    // // -----------------------------------------------------
    // // PUBLIC MODEL + PRIVATE FIELD + PROPERTIES 
    // // + RETURN VALUES FROM PROPERTIES + SHORTCUT + NULLABLE 
    // // + CONSTRUCTOR + PRIVATE ISSUE -- NOT RECOMMENDED
    // // ----------------------------------------------------- 
    // // Create a Model Class
    // // accessible outside of class
    // // Make fields private
    // // set & get properties for field
    // // return values using shortcut alternative  
    // // inherently creates the private field:
    // // private string _motherboard;
    // // uses GET & SET to manipulate _motherboard
    // // Not public field (removing ;)
    // // strings are not nullable -> create issues when instance is created
    // // constructor used -> variable needs to be public 

    // public class ComputerWithNotPublicAttribute
    // {
    //     private string Motherboard { get; set; } // ERROR: constructor cannot access private data
    //     public int CPUCores { get; set; }
    //     public bool HasWifi { get; set; }
    //     public bool HasLTE { get; set; }
    //     public DateTime ReleaseDate { get; set; }
    //     public decimal Price { get; set; }
    //     private string VideoCard { get; set; }

    //     // Constructor --> needs to be public so when instance is created, constructor can be accessed
    //     ComputerWithNotPublicAttribute() // need to make public
    //     {
    //         // ERROR: cannot access private data
    //         if (Motherboard == null)
    //         {
    //             Motherboard = "";
    //         }
    //         if (VideoCard == null)
    //         {
    //             VideoCard = "";
    //         }
    //     }
    // }


//     // --------------------------
//     // FINAL MODEL using constructor
//     // --------------------------
//     public class Computer
//     {
//         public string Motherboard { get; set; } // accessible in constructor
//         public int CPUCores { get; set; }
//         public bool HasWifi { get; set; }
//         public bool HasLTE { get; set; }
//         public DateTime ReleaseDate { get; set; }
//         public decimal Price { get; set; }
//         public string VideoCard { get; set; } // accessible in constructor

//         // Constructor
//         public Computer() // can access Motheboard & VideoCard
//         {
//             if (Motherboard == null)
//             {
//                 Motherboard = "";
//             }

//             if (VideoCard == null)
//             {
//                 VideoCard = "";
//             }
//         }
//     }

//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // create first instance of Computer model
//             Computer myComputer = new Computer()
//             {
//                 Motherboard = "z39anvd923",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.87m,
//                 VideoCard = "RTX 26"
//             };

//             Console.WriteLine(myComputer.HasWifi);

//             // change values
//             myComputer.HasWifi = false;

//             Console.WriteLine(myComputer.Motherboard);
//             Console.WriteLine(myComputer.HasWifi);
//             Console.WriteLine(myComputer.VideoCard);

//         }
//     }
// }

//     // --------------------------
//     // FINAL MODEL using default
//     // --------------------------
//     public class Computer
//     {
//         // private string _motherboard; // (creates automatically)
//         public string Motherboard { get; set; } = "";
//         public int CPUCores { get; set; }
//         public bool HasWifi { get; set; }
//         public bool HasLTE { get; set; }
//         public DateTime ReleaseDate { get; set; }
//         public decimal Price { get; set; }
//         public string VideoCard { get; set; } = "";
//     }

//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // create first instance of Computer model
//             Computer myComputer = new Computer()
//             {
//                 Motherboard = "z39anvd923",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.87m,
//                 VideoCard = "RTX 26"
//             };

//             Console.WriteLine(myComputer.HasWifi);

//             // change values
//             myComputer.HasWifi = false;

//             Console.WriteLine(myComputer.Motherboard);
//             Console.WriteLine(myComputer.HasWifi);
//             Console.WriteLine(myComputer.VideoCard);

//         }
//     }
// }

/* _____________________________________________________

    Namespaces
_______________________________________________________*/

// // separates the models into its own file
// // access models within this file by importing

// using System;
// using System.Text.RegularExpressions;

// // import decoupledmodels
// using HelloWorld.Models;

// namespace HelloWorld
// {
//     // models moved to Models.Computer.cs

//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // create first instance of Computer model
//             Computer myComputer = new Computer()
//             {
//                 Motherboard = "z39anvd923",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.87m,
//                 VideoCard = "RTX 26"
//             };

//             Console.WriteLine(myComputer.HasWifi);

//             // change values
//             myComputer.HasWifi = false;

//             Console.WriteLine(myComputer.Motherboard);
//             Console.WriteLine(myComputer.HasWifi);
//             Console.WriteLine(myComputer.VideoCard);

//         }
//     }
// }

/* _____________________________________________________

    Create Connections
_______________________________________________________*/

// using System;

// using System.Text.RegularExpressions;

// // import decoupledmodels
// using HelloWorld.Models;

// // Import for IDb Connection to SQL Database
// using System.Data;
// using Microsoft.Data.SqlClient;
// using Dapper;

// namespace HelloWorld
// {
//     // models moved to Models.Computer.cs
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             // create connection to database 

//             // Mac/Linux:
//             // string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=sa;Password=SQLConnect1;";
            
//             // Windows
//             string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

//             // Create IDB Connection Object to connect to server
//             IDbConnection dbConnection = new SqlConnection(connectionString);

//             // Create command to test connection
//             string sqlCommand = "SELECT GETDATE()";

//             // ---------  
//             // Test Connection using Connection object, Dapper Query and sqlCommand
//             // dbConnection.Query<DateTime>(sqlCommand);
//                 // connects to dbConnection and query database using Dapper
//                 // Returns a DateTime value using sqlCommand

//             // ALT: Single line query:
//             // dbConnection.QuerySingle<DateTime>(sqlCommand);
//             // ---------             

//             // TEST the Connection
//             DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand);
//                 // Get the DateTime right now to set the value
//                 // Connect to database
//                 // Query Database using Dapper
//                 // Set the DateTime in the database
//                 // Return the value in the database

//             // TEST it worked 
//             Console.WriteLine(rightNow);

//             Console.WriteLine("---------");

//             // create first instance of Computer model
//             Computer myComputer = new Computer()
//             {
//                 Motherboard = "z39anvd923",
//                 HasWifi = true,
//                 HasLTE = false,
//                 ReleaseDate = DateTime.Now,
//                 Price = 943.87m,
//                 VideoCard = "RTX 26"
//             };

//             Console.WriteLine(myComputer.HasWifi);

//             // change values
//             myComputer.HasWifi = false;

//             Console.WriteLine(myComputer.Motherboard);
//             Console.WriteLine(myComputer.HasWifi);
//             Console.WriteLine(myComputer.VideoCard);

//         }
//     }
// }

/* _____________________________________________________

    Dapper
_______________________________________________________*/

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
            string connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";

            // Create IDB Connection Object to connect to server
            IDbConnection dbConnection = new SqlConnection(connectionString);

            // __________________________________________________________
            // // Create command to test connection
            // string sqlCommand = "SELECT GETDATE()";
            // DateTime rightNow = dbConnection.QuerySingle<DateTime>(sqlCommand); 
            // Console.WriteLine(rightNow);
            //     // Create sqlCommand to getdate
            //     // Get the DateTime right now to set the value
            //     // Connect to database
            //     // Query a Single Line in the Database using Dapper
            //     // Set the DateTime in the database using sqlCommand
            //     // Return the Dateto,e value in the database
            // __________________________________________________________

            // ALTERNATIVE:
            DateTime rightNow = dbConnection.QuerySingle<DateTime>("SELECT GETDATE()");
            Console.WriteLine(rightNow.ToString());

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