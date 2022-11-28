using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotState
{
    public abstract class State
    {
        protected IRobot _Robot;

        public void SetContext(IRobot robot)
        {
            this._Robot = robot;
        }

        public abstract void TurnRight();
        public abstract void TurnLeft();
        public abstract void Move();
        public abstract string GetState();
    }
}
