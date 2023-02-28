using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public static class TicTacToeInputValidator
    {
        public static (bool validationResult, int value) Validate(string input, string[] grid)
        {
            (var result, var value) = ValidateType(input);
            if (!result)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Current type is not a number. Please, enter valid number value(1-9)");
                Console.ResetColor();
                return (false, 0);
            }

            var range = ValidateRange(value);
            if (!range)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"There is no cell {value} on the board");
                Console.ResetColor();
                return (false, 0);
            }

            var cellExists = ValidateCellTaken(grid, value);

            if (!cellExists)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Cell {value} is taken, choose another one");
                Console.ResetColor();
                return (false, 0);
            }

            return (true, value);
        }

        public static bool ValidateRange(int cell)
        {
            if (cell <= 0 || cell > 9)
                return false;

            return true;
        }

        public static (bool result, int value) ValidateType(string content)
        {
            var result = Int32.TryParse(content, out int value);

            return (result, value);
        }

        public static bool ValidateCellTaken(string[] grid, int cell)
        {
            if (grid[cell - 1] == "X" || grid[cell - 1] == "Y")
                return false;

            return true;
        }
    }
}
