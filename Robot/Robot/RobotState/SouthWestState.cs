using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class SouthWestState : State
    {
        public override void Move()
        {
            if (this._Robot.Y < this._Robot.Board.MAX_Y && this._Robot.X > 1)
            {
                this._Robot.Y = this._Robot.Y + 1;
                this._Robot.X = this._Robot.X - 1;
            }
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new SouthState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new WestState());
        }

        public override string GetState()
        {
            return "SouthWest";
        }
    }
}
