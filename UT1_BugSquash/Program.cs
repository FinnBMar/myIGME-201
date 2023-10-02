using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            int nY; //missing a semicolon
            int nAnswer;

            Console.WriteLine("This program calculates x ^ y.");
            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumber = Console.ReadLine(); //set sNumber = to the user input
            } while (!int.TryParse(sNumber, out nX));
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nY));// add ! for correct parse, switch nX to nY.

            nAnswer = Power(nX, nY); // compute the exponent of the number using a recursive function

            Console.WriteLine($"{nX}^{nY} = {nAnswer}"); //use proper string interpolation
        }
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 1; // Changed the initial value to 1 (x^0 = 1)

            if (nExponent == 0) // the base case for exponents is 0 (x^0 = 1)
            {
                returnVal = 1; // return the base case
            }
            else
            {
                for (int i = 1; i <= nExponent; i++) // calculate the power using a loop
                {
                    returnVal *= nBase;
                }
            }
            return returnVal; //add return so a value is returned
        }
    }
}
