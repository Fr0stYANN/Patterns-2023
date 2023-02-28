using System;
using System.Numerics;
using Lab01;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player player1 = new Player("X", "Player 1");
            Player player2 = new Player("O", "Player 2");

            bool isGameOver = false;

            Player currentPlayer = player1;

            while (!isGameOver)
            {
                Console.Clear();

                Console.WriteLine($"{player1.Name}: {player1.Symbol}");
                Console.WriteLine($"{player2.Name}: {player2.Symbol}");

                board.Display();

                player1.PrintScore();
                player2.PrintScore();

                bool validated = false;

                Console.WriteLine($"{currentPlayer.Name}, enter a number (1-9):");

                int choosenCell = -1;

                while (!validated)
                {
                    var cell = Console.ReadLine();

                    (var validationResult, var value) = TicTacToeInputValidator.Validate(cell, board.grid);

                    choosenCell = value;

                    if (validationResult)
                        validated = true;
                    else
                        continue;
                }

                bool isMoveSuccessful = board.MakeMove(choosenCell - 1, currentPlayer.Symbol);

                if (board.CheckForWin())
                {
                    Console.Clear();

                    Console.WriteLine($"{player1.Name}: {player1.Symbol}");
                    Console.WriteLine($"{player2.Name}: {player2.Symbol}");

                    board.Display();

                    Console.WriteLine($"{currentPlayer.Name} wins!");

                    Console.WriteLine("Do you want to continue game, press y if yes, n if not?");

                    var result = Convert.ToString(Console.ReadLine());

                    if (result == "y")
                    {
                        currentPlayer.Score++;

                        var tmp = player1.Symbol;
                        player1.Symbol = player2.Symbol;
                        player2.Symbol = tmp;

                        currentPlayer = player2.Symbol == "X" ? player2 : player1;

                        board.InitializeBoard();

                        continue;
                    }

                    isGameOver = true;
                }
                else if (board.CheckForTie())
                {
                    Console.Clear();
                    board.Display();
                    Console.WriteLine("The game is a tie.");
                    isGameOver = true;
                }
                else if (isMoveSuccessful)
                {
                    currentPlayer = (currentPlayer == player1) ? player2 : player1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

    

