using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;

namespace TicTacToe.ViewModels
{
    class CellVM
    {
        public Cell CellObj { get; }

        public CellVM(Cell cell)
        {
            this.CellObj = cell;
        }
    }
}
