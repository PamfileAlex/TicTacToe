using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TicTacToe.ViewModels;

namespace TicTacToe.Models
{
    sealed class GameInfo : BaseNotification
    {
        private int xWins;
        private int oWins;
        public int X_Wins
        {
            get { return xWins; }
            private set
            {
                xWins = value;
                NotifyPropertyChanged("X_Wins");
            }
        }
        public int O_Wins
        {
            get { return oWins; }
            private set
            {
                oWins = value;
                NotifyPropertyChanged("O_Wins");
            }
        }
        public static GameInfo Instance { get; } = new GameInfo();

        static GameInfo() { }
        private GameInfo()
        {
            try
            {
                using (TextReader reader = File.OpenText("../../../gameInfo.txt"))
                {
                    string line = reader.ReadLine();
                    string[] separated = line.Split(' ');
                    this.X_Wins = int.Parse(separated[0]);
                    this.O_Wins = int.Parse(separated[1]);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error reading GameInfo from file");
                Console.WriteLine(exc.Message);
                this.X_Wins = 0;
                this.O_Wins = 0;
            }
        }

        ~GameInfo()
        {
            try
            {
                File.WriteAllText("../../../gameInfo.txt", X_Wins + " " + O_Wins);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error writing GameInfo to file");
                Console.WriteLine(exc.Message);
            }
        }

        public void AddWin(Cell.Type type)
        {
            _ = type == Cell.Type.X ? ++X_Wins : ++O_Wins;
        }
    }
}
