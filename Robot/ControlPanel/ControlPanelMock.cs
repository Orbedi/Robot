using Robot.Robot;
using Robot.Robot.RobotState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.ControlPanel
{

    public class ControlPanelMock : IControlPanel
    {
        private char[] _Directions;
        private IRobot _Robot;

        public void ReadCommand(string command = "")
        {
            IBoard board = new Board(5, 5);

            _Robot = new MyRobot(new NorthState(), 1, 1, board);

            _Directions = command.ToCharArray();
        }

        public void ExecuteCommand()
        {
            foreach (char direction in _Directions)
            {
                switch (direction)
                {
                    case 'F': _Robot.Move(); break;
                    case 'R': _Robot.TurnRight(); break;
                    case 'L': _Robot.TurnLeft(); break;
                }
            }
        }

        public string GetRobotPosition()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0},", _Robot.X);
            str.AppendFormat("{0},", _Robot.Y);
            str.AppendFormat("{0}", _Robot.State.GetState());
            return str.ToString();
        }
    }
}
