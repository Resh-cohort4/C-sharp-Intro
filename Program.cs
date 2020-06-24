using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two slashes mark the beginning of a single-line comment.
          
            string myName = "RESHMA";
            /* We begin multi - line comments with a forward - slash and 
            asterisk..

            We end multi line comments  with a  
            asterisk forward - slash and.*/

            Console.WriteLine("Hello, " + myName);
            
            Console.WriteLine("Press enter your name");
              // We are assigning string value to a variable.
            string userName = Console.ReadLine();
            //show the user we collected the name
            Console.WriteLine(" You have entered: " +userName);
            //instead of traditional concatenation using the addition operator..
            //Wecan use string interpolation placeholders) to embed values in 
            //a string!
            Console.WriteLine("Hey {0}, You are looking great today!" , userName);
        }
    }
}

