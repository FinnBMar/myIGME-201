using System;

namespace PE8.Q8
{
    internal class Program
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
                if (words[i].ToLower() == "yes")
                {
                    words[i] = words[i].Replace("Yes", "No").Replace("yes", "no").Replace("YES", "NO").Replace("yEs", "nO").Replace("yeS", "nO").Replace("yEs", "nO");
                }
                else if (words[i].ToLower() == "no")
                {
                    words[i] = words[i].Replace("No", "Yes").Replace("no", "yes").Replace("NO", "YES").Replace("nO", "yES");
                }
            }

            // Join the modified words back into a single string
            string modifiedUserResponse = string.Join(" ", words);

            Console.WriteLine("Modified string: " + modifiedUserResponse);
        }
    }
}
