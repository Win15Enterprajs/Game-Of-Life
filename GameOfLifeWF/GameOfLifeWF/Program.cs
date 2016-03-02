using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Board board = new Board();
            Cells cells = new Cells();
            int[,] gameBoard = new int[15, 65];
            board.addRandomValues(gameBoard);
            board.printArr(gameBoard);

            Application.Run(new Form1());
        }
    }
}
