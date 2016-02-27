using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_of_Life
{
    class Cells
    {
        public enum CellState
        {
            Dead,
            aboutToDie,
            aboutToBeReborn,
            Alive
        }
        public int[,] MakeTheTempArray(int[,] array)
        {
            var tempArray = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[i, j] = array[i, j];
                }
            }
            return tempArray;
        }
        /// <summary>
        ///  Manipulates the cells in the matrix according to the rules of the Game of Life
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[,] ManipulateCells(int[,] array)
        {
            var board = new Board();
            var tempArray = MakeTheTempArray(array);
            int numberOfNeighbours = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    numberOfNeighbours = board.CountNeighbour(i, j, array);
                        
                    if (array[i, j] == 1)
                    {
                        //  if (board.CountNeighbour(i,j,array) != 2 || board.CountNeighbour(i, j, array) != 3)
                        if (numberOfNeighbours < 2 || numberOfNeighbours > 3)
                        {
                            tempArray[i, j] = 0; //=(int)CellState.aboutToDie;
                        }
                        
                    }
                    else if (numberOfNeighbours == 3)
                    {
                        tempArray[i, j] = 1; //=(int)CellState.aboutToBeReborn;
                    }
                }
            }

            return tempArray;
        }
        /// <summary>
        /// Offers the user an option to automate the cellupdates according to a pre-set or use decided pace
        /// </summary>
        public int AutomatedCellUpdate()
        {
            var board = new Board();
            Console.WriteLine("Type in the number of miliseconds you wish inbetween each cellupdate, or press R for [R]ecommended cellupdate timer");
            string userChoice = Console.ReadLine();
            int miliseconds = 0;
            if (userChoice.ToLower() == "r")
            {
                return 400;
            }
            else
            {
                while (!int.TryParse(userChoice, out miliseconds))
                {
                    Console.WriteLine("You did not enter a correct format, please try again");
                    userChoice = Console.ReadLine();
                }
                return miliseconds;
            }
            
        }
    }
}
