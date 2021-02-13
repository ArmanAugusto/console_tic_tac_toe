using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{

    class TicTacToe
    {
        Player player1 = new Player();
        Player player2 = new Player();
        private string[,] gameBoard = new string[3, 3];

        public string this[int i, int j]
        {
            get { return gameBoard[i, j]; }
            set { gameBoard[i, j] = value; }
        }

        public TicTacToe()
        {
            gameBoard[0, 0] = "1";
            gameBoard[0, 1] = "2";
            gameBoard[0, 2] = "3";
            gameBoard[1, 0] = "4";
            gameBoard[1, 1] = "5";
            gameBoard[1, 2] = "6";
            gameBoard[2, 0] = "7";
            gameBoard[2, 1] = "8";
            gameBoard[2, 2] = "9";
        }

        public void PrintGameBoard()
        {
            Console.WriteLine("\n");
            Console.WriteLine("         |     |     ");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.WriteLine("    -----|-----|-----");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.WriteLine("    -----|-----|-----");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
            Console.WriteLine("         |     |     ");
            Console.WriteLine("\n");
        }

        public void gameActive()
        {
            Console.WriteLine("\nTic Tac Toe\n");
            Console.Write("Enter the first player's name:  ");
            player1.Name = Console.ReadLine();
            Console.Write("Enter the second player's name:  ");
            player2.Name = Console.ReadLine();

            Console.WriteLine("\nPlayer 1's name is {0}.", player1.Name);
            Console.WriteLine("Player 2's name is {0}.\n", player2.Name);

            Console.Write("Is {0} going to be X or is {0} going to be O? Enter X or O:  ", player1.Name);
            string mark = Console.ReadLine();
            mark.ToUpper();

            switch (mark.ToUpper())
            {
                case "X":
                    player1.Mark = "X";
                    player2.Mark = "O";
                    Console.WriteLine("\n{0} is X and {1} is O.\n", player1.Name, player2.Name);
                    break;
                case "O":
                    player1.Mark = "O";
                    player2.Mark = "X";
                    Console.WriteLine("\n{0} is O and {1} is X.\n", player1.Name, player2.Name);
                    break;
                default:
                    Console.WriteLine("Error:  Invalid entry. I will choose for you.");
                    Console.WriteLine("\n{0} is X and {1} is O.\n", player1.Name, player2.Name);
                    player1.Mark = "X";
                    player2.Mark = "O";
                    break;
            }

            Console.WriteLine("{0} will go first.", player1.Name);
            player1.Active = true;

            if (player1.Active == true)
            {
                PlayerMove(gameBoard, player1);
            }
            else
            {
                PlayerMove(gameBoard, player2);
            }
            Console.WriteLine(CheckForWinner(gameBoard));

        }

        public string[,] PlayerMove(string[,] gameBoard, Player player)
        {
            PrintGameBoard();

            Console.WriteLine("\nChoose where you want to place your {0}, {1}:", player.Mark, player.Name);

            player1.Choice = Console.ReadLine();
            Console.WriteLine("{0} chose {1}.", player.Name, player.Choice);

            switch (player.Choice)
            {
                case "1":
                    gameBoard[0, 0] = player.Mark;
                    break;
                case "2":
                    gameBoard[0, 1] = player.Mark;
                    break;
                case "3":
                    gameBoard[0, 2] = player.Mark;
                    break;
                case "4":
                    gameBoard[1, 0] = player.Mark;
                    break;
                case "5":
                    gameBoard[1, 1] = player.Mark;
                    break;
                case "6":
                    gameBoard[1, 2] = player.Mark;
                    break;
                case "7":
                    gameBoard[2, 0] = player.Mark;
                    break;
                case "8":
                    gameBoard[2, 1] = player.Mark;
                    break;
                case "9":
                    gameBoard[2, 2] = player.Mark;
                    break;
                default:
                    Console.WriteLine("Invalid entry. Try again.");
                    break;
            }

            PrintGameBoard();

            return gameBoard;
        }

        public bool CheckForWinner(string[,] gameBoard)
        {
            if (gameBoard[0, 0] == player1.Mark && gameBoard[0, 1] == player1.Mark && gameBoard[0, 2] == player1.Mark)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
