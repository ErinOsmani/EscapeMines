using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Principal;
using System.Text;

namespace EscapeMines
{
    public class Board
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int Dimension { get; set; }
        public int[] BoardSet { get; set; } // possibile positions


        public Board(int x1, int y1)
        {
            X = x1;
            Y = y1;
            Dimension = X * Y;
            BoardSet = new int[X * Y];
        }


        internal void AddTurtle(int position) 
        {
            BoardSet[position] = (int)PieceType.Turtle;
        }

        internal void AddMine(int position)
        {
            BoardSet[position] = (int)PieceType.Mine;
        }

        internal void AddExit(int position)
        {
            BoardSet[position] = (int)PieceType.Exit;
        }




    }
}
