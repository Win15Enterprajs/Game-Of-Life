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
            int[,] testArray = new int[10 , 10];
            Board test = new Board();
            Cells Game = new Cells();
            test.addRandomValues(testArray);
            test.PrintTheArray(testArray);
            do
            {
                testArray = Game.ManipulateCells(testArray);
                test.PrintTheArray(testArray);
                Console.ReadKey();

            } while (true);
            // random comment here smilyface

        }
    }
}
