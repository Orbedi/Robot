using Robot.ControlPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robot.RobotCommand
{
    public class MoveCommand : Command
    {
        public MoveCommand(IRobot robot) : base(robot)
        {
        }

        public override void Execute()
        {
            Robot.Move();
        }
    }
}
