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
        /// Manipulates the cells in the matrix according to the rules of the Game of Life
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="tempArray"></param>
        /// <param name="array"></param>
        /// <param name="neighbours"></param>
        /// <returns></returns>
        public int[,] ManipulateCells(int x, int y,int[,] tempArray,int[,] array, int neighbours)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[x, y] == 1)
                    {
                        if (neighbours == 2 || neighbours == 3)
                        {
                            return tempArray;
                        }
                        else
                        {
                            tempArray[x, y] = 0;
                            return tempArray;
                        }
                    }
                    else
                    {
                        if (neighbours == 2 || neighbours == 3)
                        {
                            tempArray[x, y] = 1;
                            return tempArray;
                        }
                        else
                        {
                            return tempArray;
                        }
                    }
                }
            }
            array = tempArray;
            return array;
        }
        public void AutomatedCellUpdate()
        {
            Console.WriteLine("Type in the number of seconds you wish inbetween each cellupdate, or press R for [R]ecommended cellupdate timer");
            string userChoice = Console.ReadLine();
            int userSeconds = 0;
            if (userChoice.ToLower() == "r")
            {
                while (true)
                    Thread.Sleep(400);
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

                }
            }
            
        }
    }
}
