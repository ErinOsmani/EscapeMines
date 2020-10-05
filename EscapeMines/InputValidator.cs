using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeMines
{
    public class InputValidator : IDisposable
    {
        public InputValidator() 
        {
            Console.WriteLine("Validation: Begin");
        }

        public void Dispose()
        {
            Console.WriteLine("Validation: End");
        }

        public bool IsBoardSizeValid(string input)
        {
            bool IsValid = true;
            string[] dims = input.Trim().Split(' '); 
            if(dims.Length != 2)
            {
                Console.WriteLine("Validation: The numbers for defining the board size should be 2");
                IsValid = false;
            }
            if(!int.TryParse(dims[0],out int x) || !int.TryParse(dims[1], out int y))
            {
                Console.WriteLine("Validation: Input not valid number");
                IsValid = false;
            }

            return IsValid;
        }


        public bool IsCoordinatesValid(string input)
        {
            bool IsValid = true;
            string[] coos = input.Trim().Split(',');
            if (coos.Length != 2)
            {
                Console.WriteLine($"Validation: The coordinates should be a pair of 2, {coos}" );
                IsValid = false;
            }
            if (!int.TryParse(coos[0], out int x) || !int.TryParse(coos[1], out int y))
            {
                Console.WriteLine("Validation: Input not valid number");
                IsValid = false;
            }

            return IsValid;
        }

        public bool IsListofMinesValid(string input)
        {
            bool IsValid = true;
            string[] coordinates = input.Trim().Split(' ');
           
            foreach(string c in coordinates)
            {
                if (!IsCoordinatesValid(c))
                    IsValid = false;
            }

            return IsValid;
        }
    }
}
