using Robot.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Robot.Robot.FacingDirection;
using static Robot.Robot.TurnDirection;

namespace Robot
{
    public class MyRobot
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public IBoard Board { get; private set; }
        public FacingDirections FacingDirection { get; private set; }

        public MyRobot(int x, int y, IBoard board, FacingDirections facingDirection)
        {
            X = x;
            Y = y;
            Board = board;
            FacingDirection = facingDirection;
        }

        public void Move()
        {
            switch (this.FacingDirection)
            {
                case FacingDirections.North: Y = Y + 1 > this.Board.MAX_Y ? Y : Y + 1; break;
                case FacingDirections.South: Y = Y - 1 > 0 ? Y - 1 : Y; break;
                case FacingDirections.East: X = X + 1 > this.Board.MAX_X ? X : X + 1; break;
                case FacingDirections.West: X = X - 1 > 0 ? X - 1 : X; break;
            }
        }

        public void ChangeDirection(Turn turn)
        {
            this.FacingDirection = NewFacingDirection[this.FacingDirection][(int)turn];
        }

        private Dictionary<FacingDirections, FacingDirections[]> NewFacingDirection = new Dictionary<FacingDirections, FacingDirections[]>()
        {
            { FacingDirections.North, new FacingDirections[] { FacingDirections.East, FacingDirections.West } },
            { FacingDirections.South, new FacingDirections[] { FacingDirections.West, FacingDirections.East } },
            { FacingDirections.West, new FacingDirections[] { FacingDirections.North, FacingDirections.South } },
            { FacingDirections.East, new FacingDirections[] { FacingDirections.South, FacingDirections.North } }
        };
    }
}
