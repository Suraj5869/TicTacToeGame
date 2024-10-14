using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controllers;

namespace TicTacToe.Presentation
{
    internal class AppUI
    {
        public static void StartApp()
        {
            Board.ResetBoard();
            Console.WriteLine("----- Tic-Tac-Toe -----");
            Console.WriteLine("Player 1: X and Player 2: O");
            Board.ShowBoard();

            Services.PlayGame();
        }

        internal static void CheckCell(int choice, char cell)
        {
            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, cell);
        }

        internal static void PlayerChoice()
        {
            Console.WriteLine(Services.PlayerChance());

            Console.WriteLine("Enter your choice between (1 to 9):");
            
        }

        internal static void PrintBoard(char[] array)
        {
            Console.WriteLine($"     |     |      \n" +
                              $"  {array[0]}  |  {array[1]}  |  {array[2]}\n" +
                              $"-----|-----|-----\n" +
                              $"  {array[3]}  |  {array[4]}  |  {array[5]}\n" +
                              $"-----|-----|-----\n" +
                              $"  {array[6]}  |  {array[7]}  |  {array[8]}\n" +
                              $"     |     |     \n");
        }

        public static void WinSwitch(int win, int player)
        {
            switch (win)
            {
                case 1:
                    Console.WriteLine($"Player {(player % 2) + 1} win the game\n");
                    Services.PlayAgain();
                    break;
                case -1:
                    Console.WriteLine("Match draw\n");
                    Services.PlayAgain();
                    break;
            }
        }

        internal static void Play()
        {
            Console.WriteLine("Wants to play again:\n" +
                "1. Yes\n" +
                "2. No");
        }
    }
}
