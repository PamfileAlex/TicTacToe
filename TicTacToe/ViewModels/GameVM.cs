using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using TicTacToe.Models;
using TicTacToe.Utils;
using TicTacToe.Commands;

namespace TicTacToe.ViewModels
{
    class GameVM
    {
        private GameLogic gameLogic;
        public Game Game { get; }
        public GameInfo GameInfo { get { return GameInfo.Instance; } }
        public List<List<CellVM>> GameBoard { get; }
        public ICommand NewGameCommand { get; }
        public ICommand ExitCommand { get; }

        public GameVM()
        {
            Game = new Game(BoardGenerator.NewGame());
            gameLogic = new GameLogic(Game);
            GameBoard = CellBoardToCellVMBoard(Game.GameBoard);

            NewGameCommand = new ActionCommand(Game.Reset);
            ExitCommand = new ActionCommand(WindowManager.Close);
        }

        private List<List<CellVM>> CellBoardToCellVMBoard(List<List<Cell>> gameBoard)
        {
            return gameBoard.Select(row => row.Select(cell => new CellVM(cell, gameLogic)).ToList()).ToList();
        }
    }
}
