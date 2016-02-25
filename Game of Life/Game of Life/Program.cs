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
            int[,] testArray = new int[25, 50];
            Board test = new Board();
            Cells Game = new Cells();
            test.addRandomValues(testArray);
            //testArray[0, 0] = 1;
            //testArray[0, 1] = 1;
            //testArray[0, 2] = 1;
            //test.PrintTheArray(testArray);
            test.printArr(testArray);
            Console.WriteLine("Press any key to start game of life...");
            Console.ReadKey(true);
            do
            {
                testArray = Game.ManipulateCells(testArray);
                //test.PrintTheArray(testArray);
                test.printArr(testArray);
                Console.ReadKey(true);
                Console.Clear();

            } while (true);
            // random comment here smilyface

        }
    }
}
