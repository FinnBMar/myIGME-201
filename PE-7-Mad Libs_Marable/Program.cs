using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Madlibs
{
    class Program //Finn Marable, Mad Libs program that allows you to choose between 6 different madlib stories and fill them out with custom user answers. Reports the filled in story afterwards. No known errors but 1 non-functionality which is that a non yes/no answer doesn't restart the program like requested, instead the user would have to manually restart it.
    {
        static void Main(string[] args)
        {
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;

            string finalStory = "";

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            // prompt the user for which Mad Lib they want to play (nChoice)
            bool play = false;
            Console.WriteLine("Hi there! Would you like to play madlibs? (yes/no)");
            string playRequest = Console.ReadLine();
            while (play == false) //game won't start until the user says yes
            {
                if (playRequest == "yes")
                {
                    play = true;
                }
                else if (playRequest == "Yes")
                {
                    play = true;
                }
                else if (playRequest == "no")
                {
                    Console.WriteLine("Well then why are you even here? Goodbye.");
                    Environment.Exit(0); //end program if they say no
                }
                else
                {
                    Console.WriteLine("Not a valid answer, please write either yes or no.");
                    return; //they have to restart if they don't enter yes or no
                }
            }
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine(); //get the user name and story they'd like to use.
            Console.WriteLine("Hello " + userName + ", please choose which number story you would like between 1 and 6.");
            string chosenStory = Console.ReadLine();
            nChoice = Convert.ToInt32(chosenStory);
            // split the Mad Lib into separate words
            string[] words = madLibs[(nChoice-1)].Split(' ');

            foreach (string word in words)
            {
                // if word is a placeholder
                if (word[0] == '{')
                {
                    string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", "");
                    // prompt the user for the replacement
                    Console.Write("Input a {0}: ", replaceWord);
                    // and append the user response to the result string
                    finalStory += (" " + Console.ReadLine());
                }
                // else append word to the result string
                else
                {
                    finalStory += (" " + word);
                }
            }
            Console.WriteLine(finalStory);
        }
    }
}
