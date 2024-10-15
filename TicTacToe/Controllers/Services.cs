using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Presentation;

namespace TicTacToe.Controllers
{
    internal class Services
    {
        //If win=1 then plyer win the game
        //If win=0 then the game is ongoing
        //If win=-1 then match is draw
        static int win = 0;
        static int player = 1;
        static int choice;

        internal static void PlayGame()
        {
            //checks if the match is not completed or draw
            while (win != 1 && win != -1)
            {
                AppUI.PlayerChoice();
                choice = int.Parse(Console.ReadLine());

                //checks if the specific cell is filled or not if it is filled then it indicate the player else it fill with player move
                player = Board.CheckBoard(choice, player);
                Board.ShowBoard();

                //checks all winning and draw condition every time 
                win = Board.CheckWin();
                AppUI.WinSwitch(win, player);
            }
        }

        public static string PlayerChance()
        {
            //Shows the current player chance
            if (player % 2 == 0)
            {
                return "Player 2 chance";
            }

            return "Player 1 chance";
        }

        internal static void PlayAgain()
        {
            AppUI.Play();
            choice = int.Parse(Console.ReadLine());
            switch (choice) 
            {
                case 1:
                    Console.Clear();//clear the console
                    AppUI.StartApp();//If player wants to play again then it again start the app from beginning
                    break;
                case 2:
                    Environment.Exit(0);//If player does not want to play again then it exits the game
                    break;
            }
        }

        //Resets all value to play again
        internal static void Reset()
        {
            win = 0;
            player = 1;
        }
    }
}
