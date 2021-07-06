using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            int askingIndex = 0;
            int scoringIndex = 0;
            int score = 0;

            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions =
            {
                "Question 1 must be false.",
                "Are you a Human?",
                "Am you an art?",
                "Question 4 must be true",
                "Whatever, just type true.",
                "One extra false"
            };

            bool[] answers =
            {
                false,
                true,
                false,
                true,
                true,
                false
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Amount of questions and answer do not match");
            }

            foreach (string i in questions)
            {
                Console.WriteLine(i);
                Console.WriteLine("True or False?");
                string input = Console.ReadLine();
                bool isBool = Boolean.TryParse(input, out bool inputBool);
                while(isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses.SetValue(inputBool, askingIndex);
                askingIndex++;
            }

            foreach (bool x in answers)
            {
                bool userResponses = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex += 1}. Input: {userResponses} | Answer: {x}");
                if (userResponses == x)
                {
                    score++;
                }
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");

        }
    }
}