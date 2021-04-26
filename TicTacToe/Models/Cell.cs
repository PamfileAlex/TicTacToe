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

        private Type type;
        public Type CellType
        {
            get { return type; }
            set
            {
                type = value;
                NotifyPropertyChanged("CellTypeString");
            }
        }
        public String CellTypeString
        {
            get
            {
                return type == Type.None ? String.Empty : type == Type.X ? "X" : "O";
            }
        }
    }
}
