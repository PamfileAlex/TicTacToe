using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.Models;

namespace TicTacToe.Utils
{
    static class BoardGenerator
    {
        public static int SIZE { get; } = 3;

        public static List<List<Cell>> NewGame()
        {
            List<List<Cell>> board = new List<List<Cell>>(SIZE);
            for (byte row = 0; row < SIZE; ++row)
            {
                List<Cell> line = new List<Cell>(SIZE);
                for (byte column = 0; column < SIZE; ++column)
                {
                    line.Add(new Cell(row, column));
                }
                board.Add(line);
            }
            return board;
        }

        public static void Reset(Game game)
        {
            game.Turn = Cell.Type.X;
            game.GameBoard.ForEach(line => line.ForEach(cell => cell.CellType = Cell.Type.None));
        }
    }
}
