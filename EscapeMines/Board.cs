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
        public Element[] BoardSet { get; set; } // possibile positions


        public Board(int x1, int y1)
        {
            X = x1;
            Y = y1;
            Dimension = X * Y;
            BoardSet = new Element[X * Y];
        }


        internal void AddTurtle(int position, char orientation ) 
        {
            BoardSet[position] = new Element { ElementType = (int)PieceType.Turtle, Orientation = orientation };
        }

        internal void AddMine(int position)
        {
            BoardSet[position] = new Element { ElementType = (int)PieceType.Mine};
        }

        internal void AddExit(int position)
        {
            BoardSet[position] = new Element { ElementType = (int)PieceType.Exit };
        }


    }
}
