using Robot.ControlPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotCommand
{
    public abstract class Command
    {
        protected IRobot Robot { get; set; }

        protected Command(IRobot robot)
        {
            Robot = robot;
        }

        public abstract void Execute();
    }
}
