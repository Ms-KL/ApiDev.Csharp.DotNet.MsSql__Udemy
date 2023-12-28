﻿/* _____________________________________________________

    Models
_______________________________________________________*/

using System;

namespace HelloWorld
{
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


    // --------------------------
    // FINAL MODEL
    // --------------------------
    public class Computer
    {
        public string Motherboard { get; set; } // accessible in constructor
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; } // accessible in constructor

        // Constructor
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

/* _____________________________________________________

    Thing
_______________________________________________________*/