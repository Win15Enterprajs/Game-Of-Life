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
            Alive,
            aboutToDie,
            aboutToBeReborn
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
        public int[,] ManipulateCells(Board gameBoard)
        {
            var array = gameBoard.GameBoard;
            var tempArray = MakeTheTempArray(gameBoard.GameBoard);
            int numberOfNeighbours = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    numberOfNeighbours = gameBoard.CountNeighbour(i, j, array);
                    if (array[i,j] == (int)CellState.aboutToDie)
                    {
                        tempArray[i, j] = 0;
                    }   
                    else if (array[i,j] == (int)CellState.aboutToBeReborn)
                    {
                        tempArray[i, j] = 1;
                    } 
                    else if (array[i, j] == (int)CellState.Alive)
                    {
                        if (numberOfNeighbours < 2 || numberOfNeighbours > 3)
                        {
                            tempArray[i, j] = (int)CellState.aboutToDie;
                        }

                        
                    }
                    else if (numberOfNeighbours == 3)
                    {
                        tempArray[i, j] = (int)CellState.aboutToDie;
                    }
                }
            }

            return tempArray;
        }
        public int[,] addRandomValuesTo(Board gameBoard)
        {

            int amountToAdd = (gameBoard.GameBoard.GetLength(0) * gameBoard.GameBoard.GetLength(1)) / 4;
            int[,] tempArray = gameBoard.GameBoard;
            Random rnd = new Random();
            for (int i = 0; i < amountToAdd; i++)
            {
                tempArray[rnd.Next(0, gameBoard.GameBoard.GetLength(0)), rnd.Next(0, gameBoard.GameBoard.GetLength(1))] = rnd.Next(0, 2);
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
            
        } // not Implemented
    }
}
