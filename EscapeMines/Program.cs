using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EscapeMines
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading from file
            /**
             * File Format:
             * Number of Tiles: x y 
             * Mines Coordinates: 1,3 3,3,
             * Exit Point Coordinates: x y 
             * Start Position Turtle: xt yt dt
             * List of moves: 
             *      R = Right by 90 degrees
             *      L = Left 
             *      M = Move ahead. The direction will be decided from the oriention
             *    
             */ 
            string[] inputs = FileReader.GetLinesFromFile(@"Example\input.txt");
            string[] moves = inputs.Skip(4).ToArray();

            //validation
            using (InputValidator validator = new InputValidator())
            {
                validator.IsBoardSizeValid(inputs[0]);
                validator.IsListofMinesValid(inputs[1]);
                validator.IsExitPointValid(inputs[2]);
                validator.IsStartPositionValid(inputs[3]);

                validator.IsListofMovesValid(string.Join(' ', moves));

                if (!validator.IsValid)
                    return;
            }
            // setup field 
            Console.WriteLine("hmmmm");
            string[] dims = inputs[0].Trim().Split(' ');






            // moving 



            // results 

        }
    }
}
