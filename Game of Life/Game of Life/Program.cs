using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testArray = new int[15 , 15];
            Board test = new Board();
            Cells Game = new Cells();
            test.addRandomValues(testArray);
            test.PrintTheArray(testArray);
            do
            {
                Console.Clear();
                testArray = Game.ManipulateCells(testArray);
                test.PrintTheArray(testArray);
                Console.ReadKey();

            } while (true);
            // random comment here smilyface

        }
    }
}
