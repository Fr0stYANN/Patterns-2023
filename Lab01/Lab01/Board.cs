using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Board
    {
        public string[] grid;

        public Board()
        {
            grid = new string[9];

            InitializeBoard();
        }

        public void Display()
        {
            Console.WriteLine($"0 {grid[0]}|{grid[1]}|{grid[2]}");
            Console.WriteLine("  -----");
            Console.WriteLine($"1 {grid[3]}|{grid[4]}|{grid[5]}");
            Console.WriteLine("  -----");
            Console.WriteLine($"2 {grid[6]}|{grid[7]}|{grid[8]}");
            Console.WriteLine();
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                grid[i] = $"{i + 1}";
            }
        }

        public bool MakeMove(int cell, string symbol)
        {
            grid[cell] = symbol;

            return true;
        }

        public bool CheckForWin()
        {
            if (grid[0] == grid[1] && grid[1] == grid[2])
                return true;

            if (grid[3] == grid[4] && grid[4] == grid[5])
                return true;

            if (grid[6] == grid[7] && grid[7] == grid[8])
                return true;

            if (grid[0] == grid[3] && grid[3] == grid[6])
                return true;

            if (grid[1] == grid[4] && grid[4] == grid[7])
                return true;

            if (grid[2] == grid[5] && grid[5] == grid[8])
                return true;

            if (grid[0] == grid[4] && grid[4] == grid[8])
                return true;

            if (grid[2] == grid[4] && grid[4] == grid[6])
                return true;

            return false;
        }

        public bool CheckForTie()
        {
            if (grid[0] != "1" && grid[1] != "2" && grid[2] != "3" && grid[3] != "4" &&
                grid[4] != "5" && grid[5] != "6" && grid[6] != "7" && grid[7] != "8" &&
                grid[8] != "9")
                return true;

            return false;
        }
    }
}
