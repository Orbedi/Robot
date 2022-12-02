using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class WestState : State
    {
        public override void Move()
        {
            this._Robot.X = this._Robot.X > 1 ? this._Robot.X - 1 : this._Robot.X;
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new SouthWestState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new NorthWestState());
        }

        public override string GetState()
        {
            return "West";
        }
    }
}
