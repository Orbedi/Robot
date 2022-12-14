using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class SouthEastState : State
    {
        public override void Move()
        {
            if (this._Robot.Y > 1 && this._Robot.X < this._Robot.Board.MAX_X)
            {
                this._Robot.Y = this._Robot.Y - 1;
                this._Robot.X = this._Robot.X + 1;
            }
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new EastState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new SouthState());
        }

        public override string GetState()
        {
            return "SouthEast";
        }
    }
}
