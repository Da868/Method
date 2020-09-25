// Author: Montarious Starks
// Date:   09/24/2020
// Comments: This program is to shwo the fact people are able to have the information

using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;

namespace Method
{
    class Program
    {
        static void Main (string[] args)
        {      
            // Creation of the string to the message
            string name = Message();
           
            // Variabe created to Display the input
            DisplayOutput(name);
           
        }

        public static string Message()
        {
            // Question asked to the user
            Console.WriteLine("Please Enter Your Name");
            return Console.ReadLine();
            
        }


          public static void DisplayOutput(string name)
        {
            // Answer given back to the user with imput
            Console.WriteLine(" Hello " + name + "" + " - Go Bucs");
            // Required to exit the program
            Console.WriteLine("Press any key to exit the program.....");
            Console.ReadLine();
            
        }
    }

}
