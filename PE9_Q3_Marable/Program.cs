using System;

namespace ConsoleInputImpersonation
{
    class Program
    {
        // Define a delegate for reading input
        delegate string InputDelegate();

        static void Main(string[] args)
        {
            InputDelegate inputMethod = Console.ReadLine;  // Create an instance of the delegate and assign it the Console.ReadLine() function
            Console.WriteLine("Enter your name: ");
            string userInput = inputMethod.Invoke(); // Use the delegate to read user input
            Console.WriteLine($"Hello, {userInput}!");
        }
    }
}