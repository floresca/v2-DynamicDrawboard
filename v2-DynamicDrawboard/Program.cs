using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Challenge, game class that stores the game itself.
/*
Create class that stores the game data.. will be the parameter
This will revolve with the players.. Player 1 & Player 2
And the state of the Board itself.. such like the location of the next | MOVE |
     
 */


// This will be for the Boardgame called, Connect4

namespace game
{

    public class drawBoard
    {
        string drawboardChar = " ";
        char width = '|';
        string height = "-+";


        static void Main(string[] args)
        {

            drawBoard db = new drawBoard();
            db.draw_board(6, 7);

        }

        private void draw_board(int x, int y)
        {
            //Column
            for (int j = 0; j < y * 2; j++)
            {
                Console.Write("\n");

                //Row
                for (int i = 0; i < x; i++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(drawboardChar + width);
                    }

                    if (j % 2 == 1)
                    {
                        Console.Write(height);
                    }
                }

            }
            Console.ReadLine();
        }
    }

    public class ConnectGame
    {
        public void Players(int[] players)
        {
            int redc = 0;
            int bluec = 0;
        }

        public void Move(int l, int r)
        {
            string CheckWin;
        }

    }
}