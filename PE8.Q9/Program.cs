using System;

namespace PE8.Q8
{
    internal class Program //Finn Marable this is PE8 Q.8 and it takes a given string and adds double quotation marks around each word in the string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string userResponse = Console.ReadLine();
            userResponse = userResponse.Trim();

            // Split the userResponse into an array of words
            string[] words = userResponse.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = $"\"\"{words[i]}\"\"";
            }

            // Join the modified words back into a single string
            string modifiedUserResponse = string.Join(" ", words);

            Console.WriteLine("Modified string: " + modifiedUserResponse);
        }
    }
}