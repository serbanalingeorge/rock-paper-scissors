using System;

namespace RockPaperScissors.Helper
{
    public static class DisplayMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Rock : Paper : Scissors Game!");
        }

        public static void Result()
        {
            Console.WriteLine("\n\nRESULT: {0} " +
                              "\n -1 \t(Player 1 LOST) " +
                              "\n  1 \t(Player 1 WON) " +
                              "\n  0 \t(It is a DRAW) " +
                              "\n -2 \t(Invalid Entries)");
        }

        public static void Matrix()
        {
            Console.WriteLine("                                  P 2/C 2" +
                              "\n                    |Rock(1)| Paper(2)| Scissors(3)|" +
                              "\n  P/C    Rock(1)    |  0    |   -1    |      1     |" +
                              "\n  1/1    Paper(2)   |  1    |    0    |     -1     |" +
                              "\n         Scissors(3)| -1    |    1    |      0     |");
        }

        public static void Games()
        {
            Console.WriteLine("Type:" +
                              " \n(1) for playing against computer," +
                              " \n(2) for playing against other player," +
                              " \n(3) for playing computer against computer!");
        }

        public static void EndGame()
        {
            Console.WriteLine("See you next time!");
        }

        public static void NotValid()
        {
            Console.WriteLine("Not a valid option");
        }

        public static void WantToPlayAgain()
        {
            Console.WriteLine("\nDo you want to play again? y/n");
        }

        public static void FirstPlayerTurn()
        {
            Console.WriteLine("First player's turn:");
        }

        public static void SecondPlayerTurn()
        {
            Console.WriteLine("Second player's turn:");
        }

        public static void Weapon()
        {
            Console.WriteLine("Type: \n(1) for ROCK," +
                              " \n(2) for PAPER," +
                              " \n(3) for SCISSORS!");
        }

        public static void NewLine()
        {
            Console.WriteLine("\n");
        }
    }
}
