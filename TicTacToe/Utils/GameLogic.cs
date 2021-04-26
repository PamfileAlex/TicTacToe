using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TicTacToe.Models;

namespace TicTacToe.Utils
{
    class GameLogic
    {
        private readonly Game game;

        public GameLogic(Game game)
        {
            this.game = game;
        }

        public void Pressed(Cell cell)
        {
            if (cell.CellType != Cell.Type.None) { return; }
            cell.CellType = game.Turn;
            if (CheckForWin(cell))
            {
                game.Reset();
                return;
            }
            game.NextTurn();
        }

        public bool CheckForWin(Cell cell)
        {
            if (game.Occupied == BoardGenerator.SIZE * BoardGenerator.SIZE - 1)
            {
                MessageBox.Show("DRAW");
                return true;
            }
            if (game.GameBoard[cell.Row].All(cellObj => cellObj.CellType == game.Turn)
                || CheckVertical(cell) || CheckDiagonal(cell))
            {
                MessageBox.Show(game.Turn == Cell.Type.X ? "Player X won" : "Player O won");
                return true;
            }
            return false;
        }

        public bool CheckVertical(Cell cell)
        {
            for (byte row = 0; row < BoardGenerator.SIZE; ++row)
            {
                if (game.GameBoard[row][cell.Column].CellType != game.Turn)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckDiagonal(Cell cell)
        {
            if (cell.Row != cell.Column && cell.Row + cell.Column != BoardGenerator.SIZE - 1)
            {
                return false;
            }
            return PrincipalDiagonal() || SecondaryDiagonal();
        }

        public bool PrincipalDiagonal()
        {
            for (byte index = 0; index < BoardGenerator.SIZE; ++index)
            {
                if (game.GameBoard[index][index].CellType != game.Turn)
                {
                    return false;
                }
            }
            return true;
        }

        public bool SecondaryDiagonal()
        {
            for (byte index = 0; index < BoardGenerator.SIZE; ++index)
            {
                if (game.GameBoard[index][BoardGenerator.SIZE - index - 1].CellType != game.Turn)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
