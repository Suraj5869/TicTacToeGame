using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;

namespace TicTacToe.Presentation
{
    internal class Board
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public static void ShowBoard()
        {
            AppUI.PrintBoard(board);
        }

        public static int CheckWin()
        {
            //Check for first row
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }
            //Check for second row
            if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }
            //Check for third row
            if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            //Check for first column
            if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }
            //Check for second column
            if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            //Check for third column
            if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            //Check for first diagonal
            if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }
            //Check for second diagonal
            if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then any player has won the match
            if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
            {
                return -1;
            }
            return 0;
        }

        internal static int CheckBoard(int choice, int player)
        {
            //Checks if the board cell is filled or not if not then fill with player choice
            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                MarkCell(choice, player);
                player++;
                return player;
            }
            //Print that cell is already filled.          
            AppUI.CheckCell(choice, board[choice - 1]);
            return player;
            }

        //It put the values with respect to player in player choice
        private static void MarkCell(int choice, int player)
        {
            if (player % 2 == 0)
            {
                board[choice - 1] = 'O';
            }
            else
            {
                board[choice - 1] = 'X';
            }
        }

        //Reset the values of board with initial values
        internal static void ResetBoard()
        {
            char[] initialBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            board = initialBoard;
            Services.Reset();
        }
    }
}

