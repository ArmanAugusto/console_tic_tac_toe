using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{
    class Player
    {
        private static string name;
        private bool active;
        private static string mark;
        private string choice;

        public string Name { get; set; }
        public bool Active { get; set; }
        public string Mark { get; set; }
        public string Choice { get; set; }
    }
}
