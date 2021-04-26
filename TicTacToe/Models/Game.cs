using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.ViewModels;

namespace TicTacToe.Models
{
    class Game : BaseNotification
    {
        public List<List<Cell>> GameBoard { get; }
        public Cell.Type turn;
        public Cell.Type Turn
        {
            get { return turn; }
            set
            {
                turn = value;
                NotifyPropertyChanged("Player");
            }
        }

        public String Player
        {
            get
            {
                return Turn == Cell.Type.None ? "Error" : Turn == Cell.Type.X ? "Player X" : "Player O";
            }
        }

        public Game(List<List<Cell>> gameBoard)
        {
            this.GameBoard = gameBoard;
            this.Turn = Cell.Type.X;
        }
    }
}
