using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Marable
{
    internal class Program //Finn Marable, Random number program that gives you 8 guesses to guess a random number from 1-100. No known errors *shades*
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);
            Console.WriteLine(randomNumber); //displays the answer for testing purposes
            int counter = 0; //initialize turn counter

            while (counter < 8) //loop for running the questions for 8 tries.
            {
                Console.WriteLine("Turn #" + (counter + 1) + " What is your guess?"); //initial question and conversion for answer comparison
                string answer = Console.ReadLine();
                int answerNum; //initializes the final answer variable that will be compared since it is an int type
                if (Int32.TryParse(answer, out answerNum)) //This line checks that the given user input is an integer type and if so carries on with the loop, otherwise it falls to the error message and loops back without incrementing.
                {
                    if ((answerNum > -1) && (answerNum < 101)) //making sure the integer value is within range, otherwise it goes to the error message below
                    {
                        if (answerNum == randomNumber)
                        {
                            Console.WriteLine("Correct! You won in " + (counter + 1) + " turns."); // correct answer response, loop break
                            break;
                        }
                        else
                        {
                            if (answerNum < randomNumber)
                            {
                                Console.WriteLine("Too Low!"); //too low response and increment
                                counter += 1;
                            }
                            else
                            {
                                if (answerNum > randomNumber) //too high response and increment 
                                {
                                    Console.WriteLine("Too High!");
                                    counter += 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid answer!");//invalid answer message for if you type an integer answer that is out of the range
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer!");//invalid answer message for if you type a non-integer answer
                }
            }
            if (counter > 9) //Final response if you run out of guesses
            {
                Console.WriteLine("Out of guesses! Correct answer was " + randomNumber);
            }
        }
    }
}
