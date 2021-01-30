using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{

    class TicTacToe
    {
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
            Console.WriteLine("      |      |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", gameBoard[0, 0], gameBoard[0, 1], gameBoard[0, 2]);
            Console.WriteLine("------|------|------");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", gameBoard[1, 0], gameBoard[1, 1], gameBoard[1, 2]);
            Console.WriteLine("------|------|------");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", gameBoard[2, 0], gameBoard[2, 1], gameBoard[2, 2]);
            Console.WriteLine("      |      |      ");
        }

        
    }
}
