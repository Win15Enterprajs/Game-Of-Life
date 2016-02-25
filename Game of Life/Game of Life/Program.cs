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
            Menue.Intro();
            Console.ReadLine();
            int[,] testArray = new int[5, 5];
            Board test = new Board();
            Cells Game = new Cells();
            //test.addRandomValues(testArray);
            testArray[0, 0] = 1;
            testArray[0, 1] = 1;
            testArray[0, 2] = 1;
            test.PrintTheArray(testArray);
            Console.ReadLine();
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
