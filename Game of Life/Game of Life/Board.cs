using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Board
    {
        public int[,] GameBoard { get; set; }
        
        /// <summary>
        /// Constructor that creates the gameboard.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Board (int x, int y)
        {
            this.GameBoard = new int[x, y];
        }
        public Board() { } // empty contructor
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
            if (x != 0)                            /// Makes sure that you cant check below the limit of the X -axis.
            {
                if (arrayToCheck[x - 1, y] == (int)Cells.CellState.Alive || arrayToCheck[x - 1, y] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (y != 0)                            /// Makes sure that you can't check below the limit of the Y -axis.
            {
                if (arrayToCheck[x, y - 1] == (int)Cells.CellState.Alive || arrayToCheck[x, y - 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != arrayToCheck.GetLength(0) - 1) /// Makes sure that you can't check above the limit of the X -axis.
            {
                if (arrayToCheck[x + 1, y] == (int)Cells.CellState.Alive || arrayToCheck[x + 1, y] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check above the limit of the Y -axis.
            {
                if (arrayToCheck[x, y + 1] == (int)Cells.CellState.Alive || arrayToCheck[x, y + 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != arrayToCheck.GetLength(0) - 1 && y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check above the limit of the X and Y -axis.
            {                                                                            ///  Which means the bottom right corner of the matrix.
                if (arrayToCheck[x + 1, y + 1] == (int)Cells.CellState.Alive || arrayToCheck[x + 1, y + 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != 0 && y != 0)                           /// Makes sure that you can't check below the limit of the Y and X -axis.
            {                                               /// Which means the upper left corner of the matrix.    
                if (arrayToCheck[x - 1, y - 1] == (int)Cells.CellState.Alive || arrayToCheck[x - 1, y - 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (x != 0 && y != arrayToCheck.GetLength(1) - 1) /// Makes sure that you can't check below the limit of the X -axis or above the limit of the Y -axis.
            {                                                /// Which means the upper right corner of the matrix.
                if (arrayToCheck[x - 1, y + 1] == (int)Cells.CellState.Alive || arrayToCheck[x - 1, y + 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            if (y != 0 && x != arrayToCheck.GetLength(0) - 1) /// Makes sure that you can't check below the limit of the X -axis or above the limit of the Y -axis.
            {                                                /// Which means the bottom left corner of the matrix.
                if (arrayToCheck[x + 1, y - 1] == (int)Cells.CellState.Alive || arrayToCheck[x + 1, y - 1] == (int)Cells.CellState.aboutToDie)
                {
                    amountOfNeighbours++;
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            return amountOfNeighbours;
        }

        /// <summary>
        /// This takes a gameboard in the form of a 2D int array
        /// and prints it in the console.
        /// </summary>
        /// <param name="array">2D int array gameboard</param>
        public void printGameBoard(int[,] array)
        {
            char asciiAlive = '█';
            char asciiDead = ' ';
            char asciiAboutToDie = '░';
            char asciiAboutToBeReborn = '▒';
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == (int)Cells.CellState.Alive)
                    {

                        if (j == array.GetLength(1) - 1)
                        {
                            sb.AppendFormat("{0}\n", asciiAlive);
                        }
                        else
                        {
                            sb.AppendFormat("{0}", asciiAlive);
                        }
                    }
                    else if (array[i, j] == (int)Cells.CellState.aboutToBeReborn)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            sb.AppendFormat("{0}\n", asciiAboutToBeReborn);
                        }
                        else
                        {
                            sb.AppendFormat("{0}", asciiAboutToBeReborn);
                        }
                    }
                    else if (array[i, j] == (int)Cells.CellState.aboutToDie)
                    {
                        if (j == array.GetLength(1) - 1)
                        {
                            sb.AppendFormat("{0}\n", asciiAboutToDie);
                        }
                        else
                        {
                            sb.AppendFormat("{0}", asciiAboutToDie);
                        }
                    }
                    else if (array[i, j] == 0 && j == array.GetLength(1) - 1)
                    {
                        sb.AppendFormat("{0}\n", asciiDead);
                        break;
                    }
                    else if (array[i, j] == 0)
                    {
                        sb.AppendFormat("{0}", asciiDead);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Adds the int 1 to random x,y positions in a 2D int array.
        /// </summary>
        /// <param name="arrayInput">The array you want to fill with random values.</param>
        /// <returns></returns>
        public int[,] addRandomValues(int[,] arrayInput)
        {
            
            int amountToAdd = (arrayInput.GetLength(0) * arrayInput.GetLength(1)) / 4;
            int[,] tempArray = arrayInput;
            Random rnd = new Random();
            for (int i = 0; i < amountToAdd; i++)
            {
                tempArray[rnd.Next(0 , arrayInput.GetLength(0)),rnd.Next(0, arrayInput.GetLength(1))] = rnd.Next(0, 2);
            }
            return tempArray;
        }
        public void PrintTheArray(int[,] array) //For visual testing purposes.
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("|");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" " + array[i, j] + " |");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
