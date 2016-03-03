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

            Board gameBoard = new Board(25,75); // Creates a gameboard with the dimensions x = 25 y = 75.
            Cells Game = new Cells(); // Makes an instances of the cell class which manipulates the individual cells on the gameboard.
            
            Game.addRandomValuesTo(gameBoard); // Adds random live and dead cells to the gameBoard
            
            Menue.Intro(); // Prints a title screen.
            gameBoard.printGameBoard(gameBoard.GameBoard); // Prints the gameBoard in the console.
            Console.WriteLine("\r\nThis is the seed. Press any key to start game of life...");
            Console.ReadKey(true);

            do
            {
                Console.Clear();
                gameBoard.GameBoard = Game.ManipulateCells(gameBoard); // Manipulates the values according to the rules of game of life.
                gameBoard.printGameBoard(gameBoard.GameBoard); // Prints the gameboard in the console.
                Console.ReadLine();

            } while (true);

        }
    }
}
