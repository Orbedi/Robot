using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Board : IBoard
    {

        public int MAX_X { get; private set; }
        public int MAX_Y { get; private set; }

        public Board(int max_X, int max_Y)
        {
            MAX_X = max_X;
            MAX_Y = max_Y;
        }
    }
}
