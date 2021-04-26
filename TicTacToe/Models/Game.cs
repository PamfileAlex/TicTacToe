using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    class Game
    {
        public List<List<Cell>> GameBoard { get; }

        public Game(List<List<Cell>> gameBoard)
        {
            this.GameBoard = gameBoard;
        }
    }
}
