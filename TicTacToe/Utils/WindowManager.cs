using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils
{
    static class WindowManager
    {
        private static MainWindow instance;
        public static MainWindow Instance
        {
            private get { return instance; }
            set
            {
                if (instance == null)
                {
                    instance = value;
                }
            }
        }

        public static void Close()
        {
            if (Instance == null) { return; }
            Instance.Close();
        }
    }
}
