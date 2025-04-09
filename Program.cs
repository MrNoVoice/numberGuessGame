using System;

namespace numberGuessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number guessing game.");
            Console.WriteLine();

            Console.Write("Choose the difficulty (easy, difficult, hard): ");
            var hardness = Console.ReadLine();

            Random random = new Random();

            int randomNumber = 0;

            if (hardness.ToLower() == "easy")
            {
                randomNumber = random.Next(1, 11);
            }
            else if (hardness.ToLower() == "difficult")
            {
                randomNumber = random.Next(1, 21);
            }
            else if (hardness.ToLower() == "hard")
            {
                randomNumber = random.Next(1, 41);
            }
            else
            {
                Console.WriteLine("Invalid difficulty chosen. Exiting game.");
                return;
            }

            Console.WriteLine();

            int userNumber;

            do
            {
                Console.Write("Enter your guess: ");
                userNumber = int.Parse(Console.ReadLine()!);

                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (userNumber == randomNumber)
                {
                    Console.WriteLine("Eyyy! You got it right. GGs");
                }

            } while (userNumber != randomNumber);

            Console.WriteLine();

            Console.WriteLine("Game over! Thanks for playing.");
            Console.ReadLine();
        }
    }
}
