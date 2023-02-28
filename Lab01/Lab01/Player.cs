using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Player
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string symbol, string name, int score = 0)
        {
            Symbol = symbol;
            Name = name;
            Score = score;
        }

        public void PrintScore()
        {
            Console.WriteLine($"{Name} score is: {Score}");
        }
    }
}
