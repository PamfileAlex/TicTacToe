using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.ViewModels;

namespace TicTacToe.Models
{
    class Cell : BaseNotification
    {
        public enum Type : byte
        {
            None, X, O
        }

        public byte Row { get; }
        public byte Column { get; }

        private Type type;
        public Type CellType
        {
            get { return type; }
            set
            {
                type = value;
                NotifyPropertyChanged("CellTypeString");
                NotifyPropertyChanged("Color");
            }
        }
        public String CellTypeString
        {
            get
            {
                return type == Type.None ? String.Empty : type == Type.X ? "X" : "O";
            }
        }
        public String Color
        {
            get
            {
                return type == Type.None ? String.Empty : type == Type.X ? "#3399ff" : "#ff3333";
            }
        }

        public Cell(byte row, byte column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
