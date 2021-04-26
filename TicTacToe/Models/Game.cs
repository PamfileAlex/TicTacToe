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
        public byte Occupied { get; private set; }
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
            this.Occupied = 0;
        }

        public void NextTurn()
        {
            ++Occupied;
            Turn = Turn == Cell.Type.X ? Cell.Type.O : Cell.Type.X;
        }

        public void Reset()
        {
            Occupied = 0;
            Turn = Cell.Type.X;
            GameBoard.ForEach(line => line.ForEach(cell => cell.CellType = Cell.Type.None));
        }
    }
}
