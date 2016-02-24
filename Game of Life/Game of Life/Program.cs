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
            int[,] testArray = new int[50, 50];
            Board test = new Board();
            test.addRandomValues(testArray);
            test.printArr(testArray);
            Console.WriteLine(test.CountNeighbour(0,49,testArray));

        }
    }
}
