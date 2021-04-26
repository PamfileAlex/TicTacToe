using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;

namespace TicTacToe.ViewModels
{
    class GameVM
    {
        public Game Game { get; }
        public List<List<CellVM>> GameBoard { get; }

        public GameVM()
        {
            Game = new Game();

        }

        private List<List<CellVM>> CellBoardToCellVMBoard(List<List<Cell>> gameBoard)
        {
            return gameBoard.Select(row => row.Select(cell => new CellVM()).ToList()).ToList();
        }
    }
}
