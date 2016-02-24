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
        /// <summary>
        ///  Manipulates the cells in the matrix according to the rules of the Game of Life
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[,] ManipulateCells(int[,] array)
        {
            var board = new Board();
            var tempArray = new int[array.GetLength(0), array.GetLength(1)];
            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    temp = board.CountNeighbour(i, j, array);
                        
                    if (array[i, j] == 1)
                    {
                        //  if (board.CountNeighbour(i,j,array) != 2 || board.CountNeighbour(i, j, array) != 3)
                        if (temp < 2 || temp > 3)
                        {
                            tempArray[i, j] = 0;
                        }
                        
                    }
                    else
                    {
                        //if (board.CountNeighbour(i, j, array) == 2 || board.CountNeighbour(i, j, array) == 3)
                        if (temp == 3)
                        {
                            tempArray[i, j] = 1;
                        }
                    }
                }
            }
            array = tempArray;
            return array;
        }
        /// <summary>
        /// Offers the user an option to automate the cellupdates according to a pre-set or use decided pace
        /// </summary>
        public void AutomatedCellUpdate(int[,] array)
        {
            var board = new Board();
            Console.WriteLine("Type in the number of seconds you wish inbetween each cellupdate, or press R for [R]ecommended cellupdate timer");
            string userChoice = Console.ReadLine();
            int userSeconds = 0;
            if (userChoice.ToLower() == "r")
            {
                while (true)
                {
                    Thread.Sleep(400);
                    Console.Clear();
                    array = ManipulateCells(array);
                    board.printArr(array);
                    
                }
            }
            else
            {
                while (!int.TryParse(userChoice, out userSeconds))
                {
                    Console.WriteLine("You did not enter a correct format, please try again");
                    userChoice = Console.ReadLine();
                }
                while (true)
                {
                    Thread.Sleep(userSeconds * 1000);
                    Console.Clear();
                    array = ManipulateCells(array);
                    board.printArr(array);
                }
            }
            
        }
    }
}
