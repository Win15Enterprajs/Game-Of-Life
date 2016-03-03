using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_of_Life
{
    class Menue
    {
        /// <summary>
        /// Prints out the a title screen.
        /// </summary>
        public static void Intro()
        {
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("  TTTTTT  H   H  EEEEE        GGG      A          M       M       EEEEE                     ".TrimEnd());
            Console.WriteLine("    TT    H   H  E          G         A A        M M     M M      E                         ".TrimEnd());
            Console.WriteLine("    TT    HHHHH  EEE        G  GG    AAAAA      M   M   M   M     EEE                       ".TrimEnd());
            Console.WriteLine("    TT    H   H  E          G   G   A     A    M     M M     M    E                         ".TrimEnd());
            Console.WriteLine("    TT    H   H  EEEEE       GGGG  A       A  M       M       M   EEEEE                     ".TrimEnd());
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("                                                                                            ".TrimEnd());
            Console.WriteLine("                O      FFFFF    L       I   ´FFFFF  EEEEE                                   ".TrimEnd());
            Console.WriteLine("               O  O    F        L       I    F      E                                       ".TrimEnd());
            Console.WriteLine("              O    O   FFF      L       I    FFF    EEE                                     ".TrimEnd());
            Console.WriteLine("               O  O    F        L       I    F      E                                       ".TrimEnd());
            Console.WriteLine("                O      F        LLLLL   I    F      EEEEE                                   ".TrimEnd());
            Console.ReadKey();
            Console.Clear();

        }
        public void MainMenue()
        {
            Console.WriteLine("Welcome to the Game of Life - version by Kevin and Robin");
            Console.WriteLine("Please choose one of the following");
            Console.WriteLine("To start the game of life, press S for [S]tart");
            Console.WriteLine("To change the settings, press C for [C]hange");
        } // Not implemented.
        public void ChangeMenue()
        {
            Console.WriteLine("You have selected Change");
            Console.WriteLine("To change the boards starting position, press B for [B]oard");
            Console.WriteLine("To change the refresh rate, press R for [R]efresh");
        } // Not implemented.
        public void RefreshMenue()
        {
            var cell = new Cells();
            cell.AutomatedCellUpdate();
        } // Not implemented.
        public void BoardMenue()
        {
            Console.WriteLine("To select from any of the pre-existing boards, press E for [E]xisting");
            Console.WriteLine("To create your own board, press C for [C]reate");
        } // Not implemented.
        public void ExistingBoards(List<int[,]> boards)
        {
            var mybord = new Board();
            Console.WriteLine("Press Enter to flip through the avialable boards");
            for (int i = 0; i < boards.Count; i++)
            {
                Console.WriteLine($"--------------------Board number {i} --------------------");
                mybord.printGameBoard(boards[i]);
                Console.ReadLine();
            }
            Console.WriteLine("To choose a board, please enter the number of the board you wish to select");
            int selection = 0;
            while (!int.TryParse(Console.ReadLine(), out selection))
                Console.WriteLine("You did not enter a correct number, please try again");
        } // Not implemented.
    }
}
