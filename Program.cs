
using System;
using System.Diagnostics;
using System.IO.Pipelines;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
    {
        // 1. Questions array
        string[] questions =
        {
            "Eggplants are a type of berry.",
            "The Earth is flat.",
            "C# was developed by Microsoft.",
            "Sharks are mammals.",
            "The Pacific Ocean is larger than the Atlantic Ocean."
        };

        // 2. Answers array
        bool[] answers = { true, false, true, false, true };

        // 3. Responses array
        bool[] responses = new bool[questions.Length];

        // 4. Length check
        if (questions.Length != answers.Length)
        {
            Console.WriteLine("Warning: Questions and answers arrays have different lengths!");
            return;
        }

        // 5. Asking questions
        int askingIndex = 0;

        foreach (string question in questions)
        {
            string input;
            bool isBool;
            bool inputBool;

            // 8. Ask question
            Console.WriteLine(question);
            Console.WriteLine("True or false?");
            input = Console.ReadLine().ToLower();

            // 9. Check if valid
            isBool = (input == "true" || input == "false");

            // 11. Re-prompt if invalid
            while (!isBool)
            {
                Console.WriteLine("Please respond with 'true' or 'false'.");
                input = Console.ReadLine().ToLower();
                isBool = (input == "true" || input == "false");
            }

            // 13. Convert to bool
            inputBool = (input == "true");

            // 14. Store response
            responses[askingIndex] = inputBool;
            askingIndex++;
        }

        // 16. Scoring
        int scoringIndex = 0;
        int score = 0;

        foreach (bool answer in answers)
        {
            bool userResponse = responses[scoringIndex];

            // 19. Show comparison
            Console.WriteLine($"{scoringIndex + 1}. Input: {userResponse} | Answer: {answer}");

            // 20. Increment score if correct
            if (userResponse == answer)
            {
                score++;
            }

            // 21. Increment index
            scoringIndex++;
        }

        // 22. Show final score
        Console.WriteLine($"You got {score} out of {questions.Length} correct!");
    }
}
    }
