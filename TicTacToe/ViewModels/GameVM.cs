using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;
using TicTacToe.Utils;

namespace TicTacToe.ViewModels
{
    class GameVM
    {
        private GameLogic gameLogic;
        public Game Game { get; }
        public List<List<CellVM>> GameBoard { get; }

        public GameVM()
        {
            Game = new Game(BoardGenerator.NewGame());
            gameLogic = new GameLogic(Game);
            GameBoard = CellBoardToCellVMBoard(Game.GameBoard);
        }

        private List<List<CellVM>> CellBoardToCellVMBoard(List<List<Cell>> gameBoard)
        {
            return gameBoard.Select(row => row.Select(cell => new CellVM(cell, gameLogic)).ToList()).ToList();
        }
    }
}
