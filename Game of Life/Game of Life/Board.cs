using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Board
    {
        public int[,] addRandomValues(int[,] arrayInput)
        {
            int[,] temp = arrayInput;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                temp[rnd.Next(0 , arrayInput.GetLength(0)),rnd.Next(0, arrayInput.GetLength(1))] = rnd.Next(0, 2);
            }
            return temp;
        }
        public void printArr(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 1)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            Console.Write("*\r\n");
                        }
                        Console.Write("*");
                    }
                    else if (j == array.GetLength(1) - 1)
                    {
                        Console.Write(" \r\n");
                        break;
                    }
                    else if (array[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
        /// <summary>
        /// Counts the neighbours which have the value of 1 surrounding the x and y coordinates.
        /// </summary>
        /// <param name="x">Coordinate of x-axis.</param>
        /// <param name="y">Coordinate of y-axis.</param>
        /// <param name="arrayToCheck">2D int Array of which to count from.</param>
        /// <returns>Number of live neighbours the x and y coordinate has.</returns>
        public int CountNeighbour(int x, int y, int[,] arrayToCheck)
        {
            int amountOfNeighbours = 0;
            if ( x != 0)                            /// Makes sure that you cant check below the limit of the X -axis.
            {
                if (arrayToCheck[x - 1, y] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if ( y != 0)                            /// Makes sure that you can't check below the limit of the Y -axis.
            {
                if (arrayToCheck[x, y - 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != arrayToCheck.GetLength(0) - 1) /// Makes sure that you can't check above the limit of the X -axis.
            {
                if (arrayToCheck[x + 1, y] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if (y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check above the limit of the Y -axis.
            {
                if (arrayToCheck[x, y + 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != arrayToCheck.GetLength(0) - 1 && y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check above the limit of the X and Y -axis.
            {                                                                            ///  Which means the bottom right corner of the matrix.
                if (arrayToCheck[x + 1, y + 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != 0 && y != 0)                           /// Makes sure that you can't check below the limit of the Y and X -axis.
            {                                               /// Which means the upper left corner of the matrix.    
                if (arrayToCheck[x - 1, y - 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if(x != 0 && y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check below the limit of the X -axis or above the limit of the Y -axis.
            {                                                /// Which means the upper right corner of the matrix.
                if (arrayToCheck[x - 1, y + 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
            if(y != 0 && x != arrayToCheck.GetLength(0) - 1) /// Makes sure that you can't check below the limit of the X -axis or above the limit of the Y -axis.
            {                                                /// Which means the bottom left corner of the matrix.
                if (arrayToCheck[x + 1, y - 1] == 1)
                {
                    amountOfNeighbours++;
                }
            }
////////////////////////////////////////////////////////////////////////////////////////////////////

            return amountOfNeighbours;
        }
    }
}
