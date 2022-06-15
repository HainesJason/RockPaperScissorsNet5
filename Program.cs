using System;

namespace RockPaperScissorsNet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter 1 to play the computer or 2 to play a friend:");

                var numberOfPlayers = Console.ReadKey(true);

                //if (numberOfPlayers.Key == ConsoleKey.NumPad1)
                if (numberOfPlayers.Key == ConsoleKey.D1)

                {
                    var validChoice = false;
                    string playersChoice = null;

                    while (!validChoice)
                    {
                        Console.WriteLine("Please enter R to choose rock, P to choose paper or S to choose scissors.");

                        var choice = Console.ReadKey(true);

                        if (choice.Key == ConsoleKey.R)
                            playersChoice = "Rock";
                        else if (choice.Key == ConsoleKey.P)
                            playersChoice = "Paper";
                        else if (choice.Key == ConsoleKey.S)
                            playersChoice = "Scissors";
                        else
                            playersChoice = (string)null;

                        validChoice = playersChoice is not null;
                    }

                    var computersChoice = ComputersChoice();

                    var doesThePlayerWin = DoesThePlayerWin(playersChoice, computersChoice);

                    if (doesThePlayerWin is 0)
                    {
                        Console.WriteLine($"Ah Bad luck! {computersChoice} beats {playersChoice}");
                    }
                    if (doesThePlayerWin is 1)
                    {
                        Console.WriteLine($"Great minds think alike! {computersChoice} draws with {playersChoice}");
                    }
                    if (doesThePlayerWin is 2)
                    {
                        Console.WriteLine($"The mind is greater than the machine! {playersChoice} beats {computersChoice}");
                    }

                    Console.WriteLine("Another game? [y] or [n]");
                    var playAgain = Console.ReadKey(true);

                    if (playAgain.Key == ConsoleKey.Y)
                    {
                        continue;
                    }

                    Console.WriteLine("Until next time");
                }

                break;
            }
        }

        private static int DoesThePlayerWin(string playersChoice, string computersChoice)
        {
            if (playersChoice == "Rock")
            {
                if (computersChoice is "Paper")
                {
                    return 0;
                }
                if (computersChoice is "Rock")
                {
                    return 1;
                }

                return 2;
            }
            if (playersChoice == "Paper")
            {
                if (computersChoice is "Scissors")
                {
                    return 0;
                }
                if (computersChoice is "Paper")
                {
                    return 1;
                }

                return 2;
            }
            else
            {
                if (computersChoice is "Rock")
                {
                    return 0;
                }
                if (computersChoice is "Scissors")
                {
                    return 1;
                }

                return 2;
            }
        }

        private static string ComputersChoice()
        {
            var random = new Random();

            string[] computersChoice = {"Rock", "Paper", "Scissors"};

            var index = random.Next(0, computersChoice.Length);

            return computersChoice[index];
        }
    }
}
