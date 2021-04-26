using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils
{
    class GameLogic
    {
        public static GameLogic Instance { get; } = new GameLogic();

        static GameLogic() { }
        private GameLogic() { }
    }
}
