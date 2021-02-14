using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{

    class TicTacToe
    {
        private Player player1 = new Player();
        private Player player2 = new Player();
        private string[,] gameBoard = new string[3, 3];
        private int markCount;

        public string this[int i, int j]
        {
            get { return gameBoard[i, j]; }
            set { gameBoard[i, j] = value; }
        }

        public int MarkCount { get; set; }

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
            MarkCount = 0;
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
            string playerMark = Console.ReadLine();

            switch (playerMark.ToUpper())
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



            while (CheckForWinner(gameBoard, player1, MarkCount) != true && CheckForWinner(gameBoard, player2, MarkCount) != true)
            {
                if (player1.Active == true)
                {
                    PlayerMove(gameBoard, player1, player2);
                }
                else
                {
                    PlayerMove(gameBoard, player2, player1);
                }
            }
        }

        public string[,] PlayerMove(string[,] gameBoard, Player playerA, Player playerB)
        {
            bool isValid;

            PrintGameBoard();

            do
            {
                Console.Write("Choose the location where you want to place your {0}, {1}:  ", playerA.Mark, playerA.Name);

                playerA.Choice = Console.ReadLine();
                Console.WriteLine("\n{0} chose location {1}.", playerA.Name, playerA.Choice);
            
                isValid = true;
                switch (playerA.Choice)
                {
                    case "1":
                        if (gameBoard[0, 0] == "X" || gameBoard[0, 0] == "O")
                        {
                            Console.WriteLine("Location 1 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[0, 0] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "2":
                        if (gameBoard[0, 1] == "X" || gameBoard[0, 1] == "O")
                        {
                            Console.WriteLine("Location 2 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[0, 1] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "3":
                        if (gameBoard[0, 2] == "X" || gameBoard[0, 2] == "O")
                        {
                            Console.WriteLine("Location 3 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[0, 2] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "4":
                        if (gameBoard[1, 0] == "X" || gameBoard[1, 0] == "O")
                        {
                            Console.WriteLine("Location 4 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[1, 0] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "5":
                        if (gameBoard[1, 1] == "X" || gameBoard[1, 1] == "O")
                        {
                            Console.WriteLine("Location 5 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[1, 1] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "6":
                        if (gameBoard[1, 2] == "X" || gameBoard[1, 2] == "O")
                        {
                            Console.WriteLine("Location 6 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[1, 2] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "7":
                        if (gameBoard[2, 0] == "X" || gameBoard[2, 0] == "O")
                        {
                            Console.WriteLine("Location 7 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[2, 0] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "8":
                        if (gameBoard[2, 1] == "X" || gameBoard[2, 1] == "O")
                        {
                            Console.WriteLine("Location 8 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[2, 1] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    case "9":
                        if (gameBoard[2, 2] == "X" || gameBoard[2, 2] == "O")
                        {
                            Console.WriteLine("Location 9 is not available. Please choose another location.");
                            isValid = false;
                            break;
                        }
                        else
                        {
                            gameBoard[2, 2] = playerA.Mark;
                            playerA.Active = false;
                            playerB.Active = true;
                            MarkCount++;
                            break;
                        }
                    default:
                        Console.WriteLine("\nInvalid entry. Try again.\n");
                        isValid = false;
                        break;
                }
            }
            while (isValid != true);

            PrintGameBoard();

            return gameBoard;
        }

        public bool CheckForWinner(string[,] gameBoard, Player player, int moveCount)
        {
            if (gameBoard[0, 0] == player.Mark && gameBoard[0, 1] == player.Mark && gameBoard[0, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[1, 0] == player.Mark && gameBoard[1, 1] == player.Mark && gameBoard[1, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[2, 0] == player.Mark && gameBoard[2, 1] == player.Mark && gameBoard[2, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[0, 0] == player.Mark && gameBoard[1, 0] == player.Mark && gameBoard[2, 0] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[1, 0] == player.Mark && gameBoard[1, 1] == player.Mark && gameBoard[1, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[2, 0] == player.Mark && gameBoard[2, 1] == player.Mark && gameBoard[2, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[0, 0] == player.Mark && gameBoard[1, 1] == player.Mark && gameBoard[2, 2] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (gameBoard[0, 2] == player.Mark && gameBoard[1, 1] == player.Mark && gameBoard[2, 0] == player.Mark && moveCount != 9)
            {
                Console.WriteLine("{0} wins!", player.Name);
                return true;
            }
            else if (moveCount == 9)
            {
                Console.WriteLine("This game ends in a tie.");
                return true;
            }

            else
            {
                return false;
            }
        }
        
    }
}
