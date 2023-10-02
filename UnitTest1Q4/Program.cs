using System;
using System.Threading;

class Program
{
    static void Main() //Finn marable Unit 1 test question 4 imiating the 3 questions program works well
    {
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Choose your question (1-3, or any other key to quit):");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int questionNumber) || questionNumber < 1 || questionNumber > 3)
            {
                break;//User entered an invalid choice, or a choice to quit
            }

            string correctAnswer = "";
            string question = "";
            
            switch (questionNumber)//Generate a question and correct answer based on the user's choice
            {
                case 1:
                    question = "What is your favorite color?";
                    correctAnswer = "Black";
                    break;
                case 2:
                    question = "What is the answer to life, the universe and everything?";
                    correctAnswer = "42";
                    break;
                case 3:
                    question = "What is the airspeed velocity of an unladen swallow?";
                    correctAnswer = "What do you mean? African or European swallow?";
                    break;
            }

            Console.WriteLine(question);
            var timer = new Timer(TimesUp, null, 5000, Timeout.Infinite);//Start a timer for 5 seconds
            
            string userAnswer = Console.ReadLine();//Read user input

            timer.Change(Timeout.Infinite, Timeout.Infinite);//Cancel the timer

            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is: {correctAnswer}");
            }
            Console.Write("Play again? (y/n): ");
            string playAgain = Console.ReadLine();

            if (playAgain.ToLower() != "y")
            {
                break;
            }
        }
    }
    static void TimesUp(object state)
    {
        Console.WriteLine("Time's up!");
    }
}