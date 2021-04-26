using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;

namespace TicTacToe.Utils
{
    class GameLogic
    {
        private Game game;

        public GameLogic(Game game)
        {
            this.game = game;
        }

        public void Pressed(Cell cell)
        {
            cell.CellType = game.Turn;
            game.NextTurn();
        }
    }
}
