using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(76, 27);
            Console.SetBufferSize(76, 27);

            Board gameBoard = new Board(25,75);
            Cells Game = new Cells();
            
            gameBoard.addRandomValues(gameBoard.GameBoard);
            
            Menue.Intro();
            gameBoard.printGameBoard(gameBoard.GameBoard);
            Console.WriteLine("\r\nThis is the seed. Press any key to start game of life...");
            Console.ReadKey(true);

            do
            {
                Console.Clear();
                gameBoard.GameBoard = Game.ManipulateCells(gameBoard.GameBoard);
                gameBoard.printGameBoard(gameBoard.GameBoard); 
                Console.ReadLine();

            } while (true);

        }
    }
}
