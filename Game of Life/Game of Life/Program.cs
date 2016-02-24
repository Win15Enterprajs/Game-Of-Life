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
            int[,] testArray = new int[5, 5];
            Board test = new Board();
            test.addRandomValues(testArray);
            test.printArr(testArray);
            int number = test.CountNeighbour(0 ,4 , testArray);
            Console.WriteLine(number);
            Console.ReadKey();
            // random comment here smilyface

        }
    }
}
