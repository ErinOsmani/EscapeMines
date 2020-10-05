using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscapeMines
{
    public class InputValidator : IDisposable
    {
        public bool IsValid { get; set; }
        public InputValidator() 
        {
            Console.WriteLine("Validation: Begin");
            IsValid = true;
        }

        public void Dispose()
        {
            Console.WriteLine("Validation: End");
        }

        public bool IsBoardSizeValid(string input)
        {
            string[] dims = input.Trim().Split(' '); 
            if(dims.Length != 2)
            {
                Console.WriteLine($"Validation: The numbers for defining the board size should be 2 -> {input.Trim()}");
                IsValid = false;
            }
            if(!int.TryParse(dims[0],out int x) || !int.TryParse(dims[1], out int y))
            {
                Console.WriteLine("Validation: Input not valid number");
                IsValid = false;
            }

            return IsValid;
        }


        private bool IsCoordinatesValid(string input, char sep)
        {
            bool IsValid = true;
            string[] coos = input.Trim().Split(sep);
            if (coos.Length != 2)
            {
                Console.WriteLine($"Validation: The coordinates should be a pair of 2 -> {input.Trim()}" );
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
            string[] coordinates = input.Trim().Split(' ');
           
            foreach(string c in coordinates)
            {
                if (!IsCoordinatesValid(c, ','))
                    IsValid = false;
            }

            return IsValid;
        }

        public bool IsExitPointValid(string input)
        {
            string coordinates = input.Trim();

            if (!IsCoordinatesValid(coordinates, ' '))
                IsValid = false;

            return IsValid;
        }

        public bool IsStartPositionValid(string input)
        {
            string[] s = input.Trim().Split(' ');
            if (s.Length != 3)
            {
                Console.WriteLine($"Validation: The start position should be 3 elements -> {input.Trim()}");
                IsValid = false;
            }
            string coordinates = string.Concat(s[0], ' ', s[1]);
            if (!IsCoordinatesValid(coordinates, ' '))
                IsValid = false;

            if (!IsValidOrientation(s[2]))
                IsValid = false;


            return IsValid;
        }


        private bool IsValidOrientation(string o)
        {
            bool IsValid = true;
            char[] validOrientations = { 'W', 'E', 'S', 'N' };

            if (!char.TryParse(o, out char c))
                IsValid = false;

            if (!validOrientations.Where(x => x.Equals(c)).Any())
            {
                Console.WriteLine($"Validation: Orientation not valid -> {o.Trim()}");
                IsValid = false;
            }
                

            return IsValid;
        }


    }
}
