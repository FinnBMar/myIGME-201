using System;

namespace MathRoundImpersonation
{
    class Program
    {
        // Define a delegate that matches the signature of Math.Round
        delegate double RoundDelegate(double value, int decimals);

        static void Main(string[] args)
        {
            RoundDelegate roundFunc = Math.Round;// Using a delegate to impersonate Math.Round

            double numToRound = 3.14159;
            int decimalPlaces = 2;

            double roundedValue = roundFunc(numToRound, decimalPlaces);
            Console.WriteLine($"Using Delegate: {roundedValue}");

            RoundDelegate roundAbbreviated = (value, decimals) => Math.Round(value, decimals);// Additional implementation using abbreviated notation
            double roundedAbbreviated = roundAbbreviated(numToRound, decimalPlaces);
            Console.WriteLine($"Using Abbreviated Notation: {roundedAbbreviated}");

            RoundDelegate roundAnonymous = delegate (double value, int decimals)// Additional implementation using anonymous method
            {
                return Math.Round(value, decimals);
            };
            double roundedAnonymous = roundAnonymous(numToRound, decimalPlaces);
            Console.WriteLine($"Using Anonymous Method: {roundedAnonymous}");

            RoundDelegate roundLambda = (value, decimals) => Math.Round(value, decimals);// Additional implementation using lambda expression
            double roundedLambda = roundLambda(numToRound, decimalPlaces);
            Console.WriteLine($"Using Lambda Expression: {roundedLambda}");

            Func<double, int, double> roundGeneric = Math.Round;// Additional implementation using generic template type
            double roundedGeneric = roundGeneric(numToRound, decimalPlaces);
            Console.WriteLine($"Using Generic Template Type: {roundedGeneric}");

            Console.ReadLine();
        }
    }
}