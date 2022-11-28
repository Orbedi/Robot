using Robot.Robot;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class MyRobot : IRobot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public IBoard Board { get; private set; }
        public State State { get; set; }

        public MyRobot(State state, int x, int y, IBoard board)
        {
            this.TransitionTo(state);
            X = x;
            Y = y;
            Board = board;
        }

        public void Move()
        {
            this.State.Move();
        }

        public void TurnRight()
        {
            this.State.TurnRight();
        }

        public void TurnLeft()
        {
            this.State.TurnLeft();
        }

        public void TransitionTo(State state)
        {
            this.State = state;
            this.State.SetContext(this);
        }
    }
}
