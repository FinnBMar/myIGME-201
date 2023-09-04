using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            int i = 0; //this was a syntax error of a missing semicolon

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            for (i = 2; i < 12; ++i) //this was a logic error as the code works but would print the numbers 1-9. If we change the 10 to 12 it prints 1-10. We also have to change the starting value to 2 so the later calculation does not end up dividing by zero which would be a runtime error. This also means we change a later line explained below.
            {
                // declare string to hold all numbers
                string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = "); //syntax error, I added parenthesis around the "i - 1" so that the line is read properly.

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                Console.WriteLine((float)i / ((float)i - 1)); //runtime error where i was an integer but needed to be a float to be divided correctly.

                // concatenate each number to allNumbers
                //allNumbers += i + " ";
                allNumbers += (i - 1) + " "; //syntax error I added parethesis and a -1 so that the initial i value of 2 is changed to a 1 in the allNumbers string so that it reports properly as 1-10.

                // increment the counter
                //i = i + 1;
                //I am removing this line of code because the loop already increments the counter in line 24, so this line will mess up the code. logic error because it still functions but does not do what we want the program to do.

                Console.WriteLine("These numbers have been processed: " + allNumbers);
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //I added this line above the bracket so that the variable "allNumbers" is contained within the loop and functions properly. runtime error because the variable doesn't exist otherwise.
        }
    }
}
