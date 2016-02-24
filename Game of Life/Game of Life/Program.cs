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
            int[,] testArray = new int[50, 50];
            Board test = new Board();
            test.addRandomValues(testArray);
            test.printArr(testArray);
            int number = test.CountNeighbour(2, 5, testArray);
            Console.WriteLine(number);

        }
    }
}
