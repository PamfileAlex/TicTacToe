using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;
using TicTacToe.Commands;
using System.Windows.Input;
using TicTacToe.Utils;

namespace TicTacToe.ViewModels
{
    class CellVM
    {
        private GameLogic gameLogic;
        public Cell CellObj { get; }

        public CellVM(Cell cell, GameLogic gameLogic)
        {
            this.CellObj = cell;
            this.gameLogic = gameLogic;
        }

        private ICommand pressedCommand;
        public ICommand PressedCommand
        {
            get
            {
                if (pressedCommand == null)
                {
                    pressedCommand = new RelayCommand<Cell>(gameLogic.Pressed);
                }
                return pressedCommand;
            }
        }
    }
}
