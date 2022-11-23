using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Robot.Robot.FacingDirection;
using static Robot.Robot.TurnDirection;

namespace Robot.Robot
{
    public interface IRobot
    {
        int X { get; }
        int Y { get; }
        FacingDirections FacingDirection { get; }
        IBoard Board { get; }

        void Move();
        void ChangeDirection(Turn turn);
    }
}
