using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public class EastState : State
    {
        public override void Move()
        {
            this._Robot.X = this._Robot.X >= this._Robot.Board.MAX_X ? this._Robot.X : this._Robot.X + 1;
        }

        public override void TurnLeft()
        {
            this._Robot.TransitionTo(new NorthEastState());
        }

        public override void TurnRight()
        {
            this._Robot.TransitionTo(new SouthEastState());
        }

        public override string GetState()
        {
            return "East";
        }
    }
}
