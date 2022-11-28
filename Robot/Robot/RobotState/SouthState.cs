using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class SouthState : State
    {
        public override void Move()
        {
            this._Robot.Y = this._Robot.Y > 1 ? this._Robot.Y - 1 : this._Robot.Y;
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new SouthEastState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new SouthWestState());
        }

        public override string GetState()
        {
            return "South";
        }
    }
}
