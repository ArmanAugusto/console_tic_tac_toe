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
            gameBoard[0, 0] = "00";
            gameBoard[0, 1] = "01";
            gameBoard[0, 2] = "02";
            gameBoard[1, 0] = "10";
            gameBoard[1, 1] = "11";
            gameBoard[1, 2] = "12";
            gameBoard[2, 0] = "20";
            gameBoard[2, 1] = "21";
            gameBoard[2, 2] = "22";
        }

        public void PrintGameBoard()
        {
            Console.WriteLine("\n");
            Console.WriteLine("          |      |      ");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.WriteLine("    ------|------|------");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.WriteLine("    ------|------|------");
            Console.WriteLine("      {0}  |  {1}  |  {2} ", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
            Console.WriteLine("          |      |      ");
            Console.WriteLine("\n");
        }

        public void gameStart()
        {
            Console.WriteLine("\nTic Tac Toe\n");
            Console.Write("Enter the first player's name:  ");
            player1.Name = Console.ReadLine();
            Console.Write("Enter the second player's name:  ");
            player2.Name = Console.ReadLine();

            Console.WriteLine("Player 1's name is {0}", player1.Name);
            Console.WriteLine("Player 2's name is {0}", player2.Name);

            Console.Write("Is {0} going to be X or is {0} going to be O? Enter X or O:  ", player1.Name);
            string mark = Console.ReadLine();
            mark.ToUpper();

            switch (mark)
            {
                case "X":
                    player1.Mark = "X";
                    player2.Mark = "O";
                    Console.WriteLine("{0} is X and {1} is O", player1.Name, player2.Name);
                    break;
                case "O":
                    player1.Mark = "O";
                    player2.Mark = "X";
                    Console.WriteLine("{0} is O and {1} is X", player1.Name, player2.Name);
                    break;
                default:
                    Console.WriteLine("Error:  Invalid entry. I will choose for you.");
                    Console.WriteLine("{0} is X and {1} is O", player1.Name, player2.Name);
                    player1.Mark = "X";
                    player2.Mark = "O";
                    break;
            }
        }
        
    }
}
