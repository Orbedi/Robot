using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Robot.RobotState;

namespace Robot.Robot
{
    public interface IRobot
    {
        State State { get; set; }
        int X { get; set; }
        int Y { get; set; }
        IBoard Board { get; }

        void Move();
        void TurnRight();
        void TurnLeft();
        void TransitionTo(State state);
    }
}
