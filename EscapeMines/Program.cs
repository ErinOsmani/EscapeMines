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
            Console.WriteLine("Hello World!");

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
            using (InputValidator validator = new InputValidator())
            {
                validator.IsBoardSizeValid(inputs[0]);
                validator.IsListofMinesValid(inputs[1]);
            }



            // setup field 


            // moving 



            // results 

        }
    }
}
