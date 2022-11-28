using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class NorthState : State
    {
        public override void Move()
        {
            this._Robot.Y = this._Robot.Y >= this._Robot.Board.MAX_Y ? this._Robot.Y : this._Robot.Y + 1;
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new NorthWestState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new NorthEastState());
        }

        public override string GetState()
        {
            return "North";
        }
    }
}
